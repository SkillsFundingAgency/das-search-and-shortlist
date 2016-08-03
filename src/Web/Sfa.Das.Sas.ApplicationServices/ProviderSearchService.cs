﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;
using Sfa.Das.Sas.ApplicationServices.Exceptions;
using Sfa.Das.Sas.ApplicationServices.Logging;
using Sfa.Das.Sas.ApplicationServices.Models;
using Sfa.Das.Sas.ApplicationServices.Queries;
using Sfa.Das.Sas.ApplicationServices.Settings;
using Sfa.Das.Sas.Core.Domain.Model;
using Sfa.Das.Sas.Core.Domain.Services;
using Sfa.Das.Sas.Core.Logging;

namespace Sfa.Das.Sas.ApplicationServices
{
    public sealed class ProviderSearchService : IProviderSearchService
    {
        private const string ApprenticeshipLocation = "apprenticeshipLocation";
        private const string ApprenticeshipId = "apprenticeshipId";
        private const string ApprenticeshipLocationAndNationalProvider = "apprenticeshipLocationAndNationalProvider";
        private const string ApprenticeshipIdAndNationalProvider = "apprenticeshipIdAndNationalProvider";
        private readonly IProviderLocationSearchProvider _searchProvider;
        private readonly IGetStandards _getStandards;
        private readonly IGetFrameworks _getFrameworks;
        private readonly ILookupLocations _postCodeLookup;
        private readonly ILog _logger;
        private readonly IPaginationSettings _paginationSettings;

        public ProviderSearchService(
            IProviderLocationSearchProvider searchProvider,
            IGetStandards getStandards,
            IGetFrameworks getFrameworks,
            ILookupLocations postcodeLookup,
            ILog logger,
            IPaginationSettings paginationSettings)
        {
            _searchProvider = searchProvider;
            _getStandards = getStandards;
            _getFrameworks = getFrameworks;
            _postCodeLookup = postcodeLookup;
            _logger = logger;
            _paginationSettings = paginationSettings;
        }

        public async Task<ProviderStandardSearchResults> SearchStandardProviders(int standardId, string postCode, Pagination pagination, IEnumerable<string> deliveryModes, bool nationalProviders, bool showAll)
        {
            ProviderStandardSearchResults result;
            if (!showAll && !nationalProviders)
            {
                return await SearchStandardProviders(standardId, postCode, pagination, deliveryModes, ApprenticeshipLocation);
            }

            if (showAll && !nationalProviders)
            {
                return await SearchStandardProviders(standardId, postCode, pagination, deliveryModes, ApprenticeshipId);
            }

            if (!showAll && nationalProviders)
            {
                result = await SearchStandardProviders(standardId, postCode, pagination, deliveryModes, ApprenticeshipLocationAndNationalProvider);
                result.ShowNationalProvidersOnly = true;
                return result;
            }

            result = await SearchStandardProviders(standardId, postCode, pagination, deliveryModes, ApprenticeshipIdAndNationalProvider);
            result.ShowNationalProvidersOnly = true;
            return result;
        }

        public async Task<ProviderFrameworkSearchResults> SearchFrameworkProviders(int frameworkId, string postCode, Pagination pagination, IEnumerable<string> deliveryModes, bool nationalProviders, bool showAll)
        {
            if (!showAll & !nationalProviders)
            {
                return await SearchFrameworkProviders(frameworkId, postCode, pagination, deliveryModes, ApprenticeshipLocation);
            }

            if (showAll && !nationalProviders)
            {
                return await SearchFrameworkProviders(frameworkId, postCode, pagination, deliveryModes, ApprenticeshipId);
            }

            if (!showAll && nationalProviders)
            {
                return await SearchFrameworkProviders(frameworkId, postCode, pagination, deliveryModes, ApprenticeshipLocationAndNationalProvider);
            }

            return await SearchFrameworkProviders(frameworkId, postCode, pagination, deliveryModes, ApprenticeshipIdAndNationalProvider);
        }

        private static ProviderStandardSearchResults GetProviderStandardSearchResultErrorResponse(int standardId, string standardName, string postCode, string responseCode)
        {
            return new ProviderStandardSearchResults
            {
                TotalResults = 0,
                StandardId = standardId,
                StandardName = standardName,
                PostCode = postCode,
                Hits = new IApprenticeshipProviderSearchResultsItem[0],
                StandardResponseCode = responseCode
            };
        }

        private static ProviderFrameworkSearchResults GetProviderFrameworkSearchResultErrorResponse(int frameworkId, string postCode, string responseCode)
        {
            return new ProviderFrameworkSearchResults
            {
                TotalResults = 0,
                FrameworkId = frameworkId,
                FrameworkName = string.Empty,
                PathwayName = string.Empty,
                PostCode = postCode,
                Hits = new IApprenticeshipProviderSearchResultsItem[0],
                FrameworkResponseCode = responseCode
            };
        }

        private SearchResult<StandardProviderSearchResultsItem> GetStandardSearchResults(int standardId, Coordinate coordinates, int page, int takeElements, IEnumerable<string> deliveryModes, string selection)
        {
            switch (selection)
            {
                case ApprenticeshipLocation:
                    return _searchProvider.SearchByStandardLocation(standardId, coordinates, page, takeElements, deliveryModes);
                case ApprenticeshipId:
                    return _searchProvider.SearchByStandard(standardId, coordinates, page, takeElements, deliveryModes);
                case ApprenticeshipLocationAndNationalProvider:
                    return _searchProvider.SearchByStandardLocationAndNationalProvider(standardId, coordinates, page, takeElements, deliveryModes);
                case ApprenticeshipIdAndNationalProvider:
                    return _searchProvider.SearchByStandardAndNationalProvider(standardId, coordinates, page, takeElements, deliveryModes);
                default:
                    return new SearchResult<StandardProviderSearchResultsItem>();
            }
        }

        private SearchResult<FrameworkProviderSearchResultsItem> GetFrameworkSearchResults(int frameworkId, Coordinate coordinates, int page, int takeElements, IEnumerable<string> deliveryModes, string selection)
        {
            switch (selection)
            {
                case ApprenticeshipLocation:
                    return _searchProvider.SearchByFrameworkLocation(frameworkId, coordinates, page, takeElements, deliveryModes);
                case ApprenticeshipId:
                    return _searchProvider.SearchByFramework(frameworkId, coordinates, page, takeElements, deliveryModes);
                case ApprenticeshipLocationAndNationalProvider:
                    return _searchProvider.SearchByFrameworkLocationAndNationalProvider(frameworkId, coordinates, page, takeElements, deliveryModes);
                case ApprenticeshipIdAndNationalProvider:
                    return _searchProvider.SearchByFrameworkAndNationalProvider(frameworkId, coordinates, page, takeElements, deliveryModes);
                default:
                    return new SearchResult<FrameworkProviderSearchResultsItem>();
            }
        }

        private async Task<ProviderStandardSearchResults> SearchStandardProviders(int standardId, string postCode, Pagination pagination, IEnumerable<string> deliveryModes, string searchSelection)
        {
            if (string.IsNullOrEmpty(postCode))
            {
                return new ProviderStandardSearchResults { StandardId = standardId, PostCodeMissing = true };
            }

            var standardName = string.Empty;

            try
            {
                if (standardId < 0)
                {
                    throw new SearchException("Standard ID cannot be negative");
                }

                var standard = _getStandards.GetStandardById(standardId);
                standardName = standard?.Title;

                var coordinateResponse = await _postCodeLookup.GetLatLongFromPostCode(postCode);
                var coordinates = coordinateResponse.Coordinate;

                var responseCode = standard == null ? LocationLookupResponse.ApprenticeshipNotFound : coordinateResponse.ResponseCode;

                if (coordinateResponse.ResponseCode != LocationLookupResponse.Ok)
                {
                    return GetProviderStandardSearchResultErrorResponse(standardId, standardName, postCode, responseCode);
                }

                var takeElements = pagination.Take == 0 ? _paginationSettings.DefaultResultsAmount : pagination.Take;

                var logEntry = new ApprenticeshipSearchLogEntry
                {
                    Postcode = postCode,
                    Coordinates = new[] { coordinates.Lon, coordinates.Lat }
                };

                _logger.Info("Provider location search", logEntry);

                var searchResults = GetStandardSearchResults(standardId, coordinates, pagination.Page, takeElements, deliveryModes, searchSelection);

                var result = new ProviderStandardSearchResults
                {
                    TotalResults = searchResults.Total,
                    ResultsToTake = takeElements,
                    StandardId = standardId,
                    StandardName = standardName,
                    PostCode = postCode,
                    Hits = searchResults.Hits,
                    TrainingOptionsAggregation = searchResults.TrainingOptionsAggregation,
                    NationalProviders = searchResults.NationalProvidersAggregation,
                    SelectedTrainingOptions = deliveryModes,
                    StandardResponseCode = responseCode,
                    ShowNationalProvidersOnly = false,
                };

                return result;
            }
            catch (SearchException ex)
            {
                _logger.Error(ex, "Search for provider failed.");

                return GetProviderStandardSearchResultErrorResponse(standardId, standardName, postCode, ServerLookupResponse.InternalServerError);
            }
        }

        private async Task<ProviderFrameworkSearchResults> SearchFrameworkProviders(int frameworkId, string postCode, Pagination pagination, IEnumerable<string> deliveryModes, string searchSelection)
        {
            if (string.IsNullOrEmpty(postCode))
            {
                return new ProviderFrameworkSearchResults { FrameworkId = frameworkId, PostCodeMissing = true };
            }

            try
            {
                if (frameworkId < 0)
                {
                    throw new SearchException("Framework ID cannot be negative");
                }

                var framework = _getFrameworks.GetFrameworkById(frameworkId);

                var frameworkMissing = framework == null;

                var takeElements = pagination.Take <= 0 ? _paginationSettings.DefaultResultsAmount : pagination.Take;

                var coordinateResponse = await _postCodeLookup.GetLatLongFromPostCode(postCode);
                var coordinates = coordinateResponse.Coordinate;

                var responseCode = frameworkMissing ? LocationLookupResponse.ApprenticeshipNotFound : coordinateResponse.ResponseCode;

                if (coordinateResponse.ResponseCode != LocationLookupResponse.Ok || frameworkMissing)
                {
                    return GetProviderFrameworkSearchResultErrorResponse(frameworkId, postCode, responseCode);
                }

                var searchResults = GetFrameworkSearchResults(frameworkId, coordinates, pagination.Page, takeElements, deliveryModes, searchSelection);
                var hits = searchResults.Hits;
                var total = searchResults.Total;
                var trainingOptionsAggregation = searchResults.TrainingOptionsAggregation;

                return new ProviderFrameworkSearchResults
                {
                    Title = framework?.Title,
                    TotalResults = total,
                    ResultsToTake = takeElements,
                    FrameworkId = frameworkId,
                    FrameworkCode = framework?.FrameworkCode ?? 0,
                    FrameworkName = framework?.FrameworkName,
                    PathwayName = framework?.PathwayName,
                    FrameworkLevel = framework?.Level ?? 0,
                    FrameworkResponseCode = responseCode,
                    PostCode = postCode,
                    Hits = hits,
                    TrainingOptionsAggregation = trainingOptionsAggregation,
                    NationalProviders = searchResults.NationalProvidersAggregation,
                    SelectedTrainingOptions = deliveryModes,
                    ShowNationalProvidersOnly = false,
                };
            }
            catch (SearchException ex)
            {
                _logger.Error(ex, "Search for provider failed.");

                return GetProviderFrameworkSearchResultErrorResponse(frameworkId, postCode, ServerLookupResponse.InternalServerError);
            }
        }
    }
}
