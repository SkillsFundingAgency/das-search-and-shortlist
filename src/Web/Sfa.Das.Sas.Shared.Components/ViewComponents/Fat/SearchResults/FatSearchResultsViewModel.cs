﻿using Sfa.Das.Sas.Shared.Components.ViewModels;

namespace Sfa.Das.Sas.Shared.Components.ViewComponents.Fat
{
    public class FatSearchResultsViewModel : SearchResultsViewModel<FatSearchResultsItemViewModel,SearchQueryViewModel>
    {
        public FatSearchResultsViewModel()
        {
            SearchQuery = new SearchQueryViewModel();
        }

        public bool IsAllSearch => string.IsNullOrEmpty(SearchQuery.Keywords) || SearchQuery.Keywords == "*";
    }
}
