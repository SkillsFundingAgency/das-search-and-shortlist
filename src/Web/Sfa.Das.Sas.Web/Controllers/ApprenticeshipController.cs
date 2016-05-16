﻿using System;
using System.Linq;
using System.Web.Mvc;
using Sfa.Das.Sas.ApplicationServices;
using Sfa.Das.Sas.ApplicationServices.Models;
using Sfa.Das.Sas.Core.Collections;
using Sfa.Das.Sas.Core.Domain.Model;
using Sfa.Das.Sas.Core.Domain.Services;
using Sfa.Das.Sas.Core.Logging;
using Sfa.Das.Sas.Web.Common;
using Sfa.Das.Sas.Web.Extensions;
using Sfa.Das.Sas.Web.Models;
using Sfa.Das.Sas.Web.Services;
using Sfa.Das.Sas.Web.ViewModels;
using RedirectResult = System.Web.Mvc.RedirectResult;

namespace Sfa.Das.Sas.Web.Controllers
{
    using System.Web.Routing;

    public sealed class ApprenticeshipController : Controller
    {
        private readonly ILog _logger;

        private readonly IMappingService _mappingService;
        private readonly IListCollection<int> _listCollection;

        private readonly IProfileAStep _profiler;

        private readonly IApprenticeshipSearchService _searchService;
        private readonly IGetStandards _getStandards;
        private readonly IGetFrameworks _getFrameworks;
        public ApprenticeshipController(
            IApprenticeshipSearchService searchService,
            IGetStandards getStandards,
            IGetFrameworks getFrameworks,
            ILog logger,
            IMappingService mappingService,
            IProfileAStep profiler,
            IListCollection<int> listCollection)
        {
            _searchService = searchService;
            _getStandards = getStandards;
            _getFrameworks = getFrameworks;
            _logger = logger;
            _mappingService = mappingService;
            _profiler = profiler;
            _listCollection = listCollection;
        }

        public ActionResult Search()
        {
            return View();
        }

        [System.Web.Mvc.HttpGet]
        public ActionResult SearchResults(ApprenticeshipSearchCriteria criteria)
        {
            ApprenticeshipSearchResults searchResults;
            ApprenticeshipSearchResultViewModel viewModel;
            criteria.Page = criteria.Page == 0 ? 1 : criteria.Page;

            using (_profiler.CreateStep("Search by keyword"))
            {
                searchResults = _searchService.SearchByKeyword(criteria.Keywords, criteria.Page, criteria.Take, criteria.Order, criteria.SelectedLevels);
            }

            using (_profiler.CreateStep("Map to view model"))
            {
                viewModel = _mappingService.Map<ApprenticeshipSearchResults, ApprenticeshipSearchResultViewModel>(searchResults);
            }

            if (viewModel == null)
            {
                return View(default(ApprenticeshipSearchResultViewModel));
            }

            if (viewModel.ResultsToTake != 0)
            {
                viewModel.LastPage = (int)Math.Ceiling((double)viewModel.TotalResults / viewModel.ResultsToTake);
            }

            if (viewModel?.TotalResults > 0 && !viewModel.Results.Any())
            {
                var rv = new RouteValueDictionary { { "keywords", criteria.Keywords }, { "page", viewModel.LastPage } };
                var index = 0;
                foreach (var level in viewModel.AggregationLevel.Where(m => m.Checked))
                {
                    rv.Add("SelectedLevels[" + index + "]", level.Value);
                    index++;
                }

                var url = Url.Action(
                    "SearchResults",
                    "Apprenticeship",
                    rv);
                return new RedirectResult(url);
            }

            viewModel.SortOrder = criteria.Order == 0 ? "1" : criteria.Order.ToString();
            viewModel.ActualPage = criteria.Page;

            return View(viewModel);
        }

        // GET: Standard
        public ActionResult Standard(int id, string hasError)
        {
            return Standard(id, hasError, null);
        }
        
        // GET: Standard
        public ActionResult Standard(int id, string hasError, string linkUrl)
        {
            if (id < 0)
            {
                Response.StatusCode = 400;
            }

            var standardResult = _getStandards.GetStandardById(id);

            if (standardResult == null)
            {
                var message = $"Cannot find standard: {id}";
                _logger.Warn($"404 - {message}");

                return new HttpNotFoundResult(message);
            }

            var shortListStandards = _listCollection.GetAllItems(Constants.StandardsShortListCookieName);

            var viewModel = _mappingService.Map<Standard, StandardViewModel>(standardResult);

            viewModel.IsShortlisted = shortListStandards?.Contains(id) ?? false;
            viewModel.HasError = !string.IsNullOrEmpty(hasError) && bool.Parse(hasError);
            viewModel.PreviousPageLink = GetPreviousPageLinkViewModel(linkUrl);

            return View(viewModel);
        }

        public ActionResult Framework(int id, string hasError)
        {
            if (id < 0)
            {
                Response.StatusCode = 400;
            }

            var frameworkResult = _getFrameworks.GetFrameworkById(id);

            if (frameworkResult == null)
            {
                var message = $"Cannot find framework: {id}";
                _logger.Warn($"404 - {message}");

                return new HttpNotFoundResult(message);
            }

            var viewModel = _mappingService.Map<Framework, FrameworkViewModel>(frameworkResult);

            viewModel.HasError = !string.IsNullOrEmpty(hasError) && bool.Parse(hasError);
            viewModel.SearchResultLink = Request.UrlReferrer.GetSearchResultUrl(Url.Action("Search", "Apprenticeship"));

            return View(viewModel);
        }

        private LinkViewModel GetPreviousPageLinkViewModel(string linkUrl)
        {
            if (linkUrl != null)
            {
                return new LinkViewModel
                {
                    Title = "Back",
                    Url = linkUrl
                };
            }

            if (!string.IsNullOrWhiteSpace(Request?.UrlReferrer?.OriginalString))
            {
                return new LinkViewModel
                {
                    Title = "Back",
                    Url = Request.UrlReferrer.OriginalString
                };
            }

            return new LinkViewModel
            {
                Title = "Back to search page",
                Url = Url.Action("Search", "Apprenticeship")
            };
        }
    }
}