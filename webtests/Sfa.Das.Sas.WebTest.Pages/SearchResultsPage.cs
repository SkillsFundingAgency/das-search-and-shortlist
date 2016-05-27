﻿namespace Sfa.Das.Sas.WebTest.Pages
{
    using OpenQA.Selenium;

    using Sfa.Das.Sas.WebTest.Pages.Shared;

    using SpecBind.Pages;
    using SpecBind.Selenium;

    [PageNavigation("/Apprenticeship/SearchResults")]
    public class SearchResultsPage : SharedTemplatePage
    {
        [ElementLocator(CssSelector = "#apprenticeship-results .standard-result a")]
        public IWebElement FirstStandardResult { get; set; }

        [ElementLocator(CssSelector = "#apprenticeship-results .framework-result a")]
        public IWebElement FirstFrameworkResult { get; set; }

        [ElementLocator(Id="apprenticeship-results")]
        public IElementList<IWebElement, ApprenticeshipResultItem> ApprenticeshipResults { get; set; }

        [ElementLocator(Class = "result")]
        public class ApprenticeshipResultItem : WebElement
        {
            public ApprenticeshipResultItem(ISearchContext searchContext)
                : base(searchContext)
            {
            }

            [ElementLocator(CssSelector = ".result-title a")]
            public IWebElement Title { get; set; }
        }
    }
}