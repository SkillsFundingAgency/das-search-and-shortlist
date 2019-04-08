﻿using System;
using System.Linq;
using Sfa.Das.FatApi.Client.Model;

namespace Sfa.Das.Sas.Infrastructure.Mapping
{
    using System.Collections.Generic;
    using Sfa.Das.Sas.ApplicationServices.Models;
    public class ApprenticeshipSearchResultsMapping : IApprenticeshipSearchResultsMapping
    {
        private readonly IApprenticeshipSearchResultsItemMapping _apprenticeshipSearchResultsItemMapping;

        public ApprenticeshipSearchResultsMapping(IApprenticeshipSearchResultsItemMapping apprenticeshipSearchResultsItemMapping)
        {
            _apprenticeshipSearchResultsItemMapping = apprenticeshipSearchResultsItemMapping;
        }

        public ApprenticeshipSearchResults Map(SFADASApprenticeshipsApiTypesV2ApprenticeshipSearchResults document)
        {
            var apprenticeshipSearchResults = new ApprenticeshipSearchResults();

            if (document != null)
            {
                apprenticeshipSearchResults.ActualPage = document.PageNumber;
                apprenticeshipSearchResults.LevelAggregation = document.LevelAggregation?.ToDictionary(s => int.Parse(s.Key), s => s.Value as long?);
                apprenticeshipSearchResults.TotalResults = document.TotalResults;
                apprenticeshipSearchResults.ResultsToTake = document.PageSize;
                apprenticeshipSearchResults.LastPage = (int)(document.TotalResults / document.PageSize);


                if (document.Results.Any())
                {
                    apprenticeshipSearchResults.Results = document.Results.Select(_apprenticeshipSearchResultsItemMapping.Map);
                }

                return apprenticeshipSearchResults;
            }

            return null;
        }
    }
}