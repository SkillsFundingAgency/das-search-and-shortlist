﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sfa.Das.Sas.Web.Views.Apprenticeship
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Sfa.Das.Sas.Web;
    
    #line 2 "..\..\Views\Apprenticeship\SearchResults.cshtml"
    using Sfa.Das.Sas.Web.Extensions;
    
    #line default
    #line hidden
    
    #line 1 "..\..\Views\Apprenticeship\SearchResults.cshtml"
    using Sfa.Das.Sas.Web.ViewModels;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Apprenticeship/SearchResults.cshtml")]
    public partial class SearchResults : System.Web.Mvc.WebViewPage<ApprenticeshipSearchResultViewModel>
    {

#line 89 "..\..\Views\Apprenticeship\SearchResults.cshtml"
public System.Web.WebPages.HelperResult GetPaginationBackLink()
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 90 "..\..\Views\Apprenticeship\SearchResults.cshtml"
 
    if (Model.ActualPage <= 1)
    {
        return;
    }

    var previousPage = @Model.ActualPage - 1;
    var url = @Url.Action("SearchResults", "Apprenticeship", GetNavigationRouteValues(previousPage, Model.AggregationLevel, Model.SortOrder), null);
    

#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "<a");

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 4086), Tuple.Create("\"", 4097)

#line 98 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 4093), Tuple.Create<System.Object, System.Int32>(url

#line default
#line hidden
, 4093), false)
);

WriteLiteralTo(__razor_helper_writer, " style=\"visibility: visible\"");

WriteLiteralTo(__razor_helper_writer, " class=\"page-navigation__btn prev\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n        <i");

WriteLiteralTo(__razor_helper_writer, " class=\"arrow-button fa fa-angle-left\"");

WriteLiteralTo(__razor_helper_writer, "></i>\r\n        <span");

WriteLiteralTo(__razor_helper_writer, " class=\"description\"");

WriteLiteralTo(__razor_helper_writer, ">Previous <span");

WriteLiteralTo(__razor_helper_writer, " class=\"hide-mob\"");

WriteLiteralTo(__razor_helper_writer, ">page</span></span>\r\n        <span");

WriteLiteralTo(__razor_helper_writer, " class=\"counter\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 101 "..\..\Views\Apprenticeship\SearchResults.cshtml"
WriteTo(__razor_helper_writer, previousPage);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " of ");


#line 101 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                 WriteTo(__razor_helper_writer, Model.LastPage);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</span>\r\n    </a>\r\n");


#line 103 "..\..\Views\Apprenticeship\SearchResults.cshtml"


#line default
#line hidden
});

#line 103 "..\..\Views\Apprenticeship\SearchResults.cshtml"
}
#line default
#line hidden

#line 106 "..\..\Views\Apprenticeship\SearchResults.cshtml"
public System.Web.WebPages.HelperResult GetPaginationNextLink()
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 107 "..\..\Views\Apprenticeship\SearchResults.cshtml"
 
    if (Model.ActualPage >= Model.LastPage || Model.ActualPage < 0)
    {
        return;
    }

    var nextPage = @Model.ActualPage + 1;

    var url = @Url.Action("SearchResults", "Apprenticeship", GetNavigationRouteValues(nextPage, Model.AggregationLevel, Model.SortOrder), null);
    

#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "<a");

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 4727), Tuple.Create("\"", 4738)

#line 116 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 4734), Tuple.Create<System.Object, System.Int32>(url

#line default
#line hidden
, 4734), false)
);

WriteLiteralTo(__razor_helper_writer, " style=\"visibility: visible\"");

WriteLiteralTo(__razor_helper_writer, " class=\"page-navigation__btn next\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n        <i");

WriteLiteralTo(__razor_helper_writer, " class=\"arrow-button fa fa-angle-right\"");

WriteLiteralTo(__razor_helper_writer, "></i>\r\n        <span");

WriteLiteralTo(__razor_helper_writer, " class=\"description\"");

WriteLiteralTo(__razor_helper_writer, ">Next <span");

WriteLiteralTo(__razor_helper_writer, " class=\"hide-mob\"");

WriteLiteralTo(__razor_helper_writer, ">page</span></span>\r\n        <span");

WriteLiteralTo(__razor_helper_writer, " class=\"counter\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 119 "..\..\Views\Apprenticeship\SearchResults.cshtml"
WriteTo(__razor_helper_writer, nextPage);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " of ");


#line 119 "..\..\Views\Apprenticeship\SearchResults.cshtml"
             WriteTo(__razor_helper_writer, Model.LastPage);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</span>\r\n    </a>\r\n");


#line 121 "..\..\Views\Apprenticeship\SearchResults.cshtml"


#line default
#line hidden
});

#line 121 "..\..\Views\Apprenticeship\SearchResults.cshtml"
}
#line default
#line hidden

        #line 125 "..\..\Views\Apprenticeship\SearchResults.cshtml"
 
    RouteValueDictionary GetNavigationRouteValues(int page, IEnumerable<LevelAggregationViewModel> selectedLevels, string order)
    {

        var rv = new RouteValueDictionary { { "keywords", Model.SearchTerm }, { "page", page }, { "order", order }, { "take", Model.ResultsToTake } };
        var i = 0;
        foreach (var level in selectedLevels.Where(m => m.Checked))
        {
            rv.Add("SelectedLevels[" + i + "]", level.Value);
            i++;
        }
        return rv;
    }

        #line default
        #line hidden

#line 141 "..\..\Views\Apprenticeship\SearchResults.cshtml"
public System.Web.WebPages.HelperResult GetStandardTitle(ApprenticeshipSearchResultItemViewModel item)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 142 "..\..\Views\Apprenticeship\SearchResults.cshtml"
 


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <h2");

WriteLiteralTo(__razor_helper_writer, " class=\"result-title\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n");

WriteLiteralTo(__razor_helper_writer, "        ");


#line 144 "..\..\Views\Apprenticeship\SearchResults.cshtml"
WriteTo(__razor_helper_writer, Html.ActionLink(item.Title, "Standard", "Apprenticeship", new { @id = item.StandardId, @keywords = Model.SearchTerm }, null));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n        <span");

WriteLiteralTo(__razor_helper_writer, " class=\"tag tag-new\"");

WriteLiteralTo(__razor_helper_writer, ">New</span>\r\n    </h2>\r\n");


#line 147 "..\..\Views\Apprenticeship\SearchResults.cshtml"


#line default
#line hidden
});

#line 147 "..\..\Views\Apprenticeship\SearchResults.cshtml"
}
#line default
#line hidden

#line 149 "..\..\Views\Apprenticeship\SearchResults.cshtml"
public System.Web.WebPages.HelperResult GetFrameworkTitle(ApprenticeshipSearchResultItemViewModel item)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 150 "..\..\Views\Apprenticeship\SearchResults.cshtml"
 


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <h2");

WriteLiteralTo(__razor_helper_writer, " class=\"result-title\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n");

WriteLiteralTo(__razor_helper_writer, "        ");


#line 152 "..\..\Views\Apprenticeship\SearchResults.cshtml"
WriteTo(__razor_helper_writer, Html.ActionLink(item.Title, "Framework", "Apprenticeship", new { @id = item.FrameworkId, @keywords = Model.SearchTerm }, null));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n    </h2>\r\n");


#line 154 "..\..\Views\Apprenticeship\SearchResults.cshtml"


#line default
#line hidden
});

#line 154 "..\..\Views\Apprenticeship\SearchResults.cshtml"
}
#line default
#line hidden

#line 156 "..\..\Views\Apprenticeship\SearchResults.cshtml"
public System.Web.WebPages.HelperResult GetApprenticeshipDetailItem(string title, string id, string item, string unit = "")
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 157 "..\..\Views\Apprenticeship\SearchResults.cshtml"
 
    if (string.IsNullOrEmpty(item))
    {
        return;
    }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <dt><b>");


#line 162 "..\..\Views\Apprenticeship\SearchResults.cshtml"
WriteTo(__razor_helper_writer, title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</b></dt>\r\n");

WriteLiteralTo(__razor_helper_writer, "    <dd");

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 6320), Tuple.Create("\"", 6331)

#line 163 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 6328), Tuple.Create<System.Object, System.Int32>(id

#line default
#line hidden
, 6328), false)
);

WriteLiteralTo(__razor_helper_writer, ">");


#line 163 "..\..\Views\Apprenticeship\SearchResults.cshtml"
WriteTo(__razor_helper_writer, item);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " ");


#line 163 "..\..\Views\Apprenticeship\SearchResults.cshtml"
WriteTo(__razor_helper_writer, unit);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dd>\r\n");


#line 164 "..\..\Views\Apprenticeship\SearchResults.cshtml"


#line default
#line hidden
});

#line 164 "..\..\Views\Apprenticeship\SearchResults.cshtml"
}
#line default
#line hidden

#line 166 "..\..\Views\Apprenticeship\SearchResults.cshtml"
public System.Web.WebPages.HelperResult FilterForm(string className)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 167 "..\..\Views\Apprenticeship\SearchResults.cshtml"
 
    if (Model.TotalResults <= 0)
    {
        return;
    }



#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <div");

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 6472), Tuple.Create("\"", 6504)
, Tuple.Create(Tuple.Create("", 6480), Tuple.Create("filters-block", 6480), true)

#line 173 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create(" ", 6493), Tuple.Create<System.Object, System.Int32>(className

#line default
#line hidden
, 6494), false)
);

WriteLiteralTo(__razor_helper_writer, ">\r\n        <form");

WriteLiteralTo(__razor_helper_writer, " method=\"get\"");

WriteLiteralTo(__razor_helper_writer, " autocomplete=\"off\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n            <input");

WriteLiteralTo(__razor_helper_writer, " type=\"hidden\"");

WriteLiteralTo(__razor_helper_writer, " name=\"Keywords\"");

WriteAttributeTo(__razor_helper_writer, "value", Tuple.Create(" value=\"", 6604), Tuple.Create("\"", 6629)

#line 175 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 6612), Tuple.Create<System.Object, System.Int32>(Model.SearchTerm

#line default
#line hidden
, 6612), false)
);

WriteLiteralTo(__razor_helper_writer, " />\r\n            <input");

WriteLiteralTo(__razor_helper_writer, " type=\"hidden\"");

WriteLiteralTo(__razor_helper_writer, " name=\"order\"");

WriteAttributeTo(__razor_helper_writer, "value", Tuple.Create(" value=\"", 6680), Tuple.Create("\"", 6704)

#line 176 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 6688), Tuple.Create<System.Object, System.Int32>(Model.SortOrder

#line default
#line hidden
, 6688), false)
);

WriteLiteralTo(__razor_helper_writer, " />\r\n\r\n            <fieldset");

WriteLiteralTo(__razor_helper_writer, " class=\"filters filters-accordion\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n                <h2");

WriteLiteralTo(__razor_helper_writer, " class=\"toggler heading-small\"");

WriteLiteralTo(__razor_helper_writer, ">Apprenticeship level</h2>\r\n                <div");

WriteLiteralTo(__razor_helper_writer, " class=\"toggled-content\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n                    <ul");

WriteLiteralTo(__razor_helper_writer, " name=\"alist22\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n");


#line 182 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                        

#line default
#line hidden

#line 182 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                         foreach (var item in Model.AggregationLevel.OrderBy(m => m.Value))
                        {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "                            <li>\r\n                                <input");

WriteAttributeTo(__razor_helper_writer, "value", Tuple.Create(" value=\"", 7127), Tuple.Create("\"", 7146)

#line 185 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 7135), Tuple.Create<System.Object, System.Int32>(item.Value

#line default
#line hidden
, 7135), false)
);

WriteAttributeTo(__razor_helper_writer, "id", Tuple.Create(" id=\"", 7147), Tuple.Create("\"", 7180)
, Tuple.Create(Tuple.Create("", 7152), Tuple.Create("SelectedLevels_", 7152), true)

#line 185 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 7167), Tuple.Create<System.Object, System.Int32>(item.Value

#line default
#line hidden
, 7167), false)
);

WriteLiteralTo(__razor_helper_writer, " name=\"SelectedLevels\"");

WriteLiteralTo(__razor_helper_writer, " type=\"checkbox\"");

WriteLiteralTo(__razor_helper_writer, " ");


#line 185 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                                                                                                     WriteTo(__razor_helper_writer, Html.Raw(item.Checked ? "checked" : ""));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " ");


#line 185 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                                                                                                                                              WriteTo(__razor_helper_writer, Html.Raw(item.Count == 0 ? "disabled" : ""));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " />\r\n                                <label");

WriteAttributeTo(__razor_helper_writer, "for", Tuple.Create(" for=\"", 7348), Tuple.Create("\"", 7382)
, Tuple.Create(Tuple.Create("", 7354), Tuple.Create("SelectedLevels_", 7354), true)

#line 186 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 7369), Tuple.Create<System.Object, System.Int32>(item.Value

#line default
#line hidden
, 7369), false)
);

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 7383), Tuple.Create("\"", 7435)

#line 186 "..\..\Views\Apprenticeship\SearchResults.cshtml"
 , Tuple.Create(Tuple.Create("", 7391), Tuple.Create<System.Object, System.Int32>(Html.Raw(item.Count == 0 ? "disabled" : "")

#line default
#line hidden
, 7391), false)
);

WriteLiteralTo(__razor_helper_writer, ">level ");


#line 186 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                                                                                                       WriteTo(__razor_helper_writer, item.Value);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " (");


#line 186 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                                                                                                                    WriteTo(__razor_helper_writer, item.Count);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, ")</label>\r\n                            </li>\r\n");


#line 188 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                        }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "                    </ul>\r\n\r\n                    <details>\r\n                     " +
"   <summary>Explain levels</summary>\r\n                        <div");

WriteLiteralTo(__razor_helper_writer, " class=\"panel panel-border-narrow\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n                            <p>Apprenticeships are set at different levels of " +
"difficulty from the equivalent of GCSE (level 2) up to postgraduate (level 7)</p" +
">\r\n                            <p><a");

WriteLiteralTo(__razor_helper_writer, " href=\"https://www.gov.uk/what-different-qualification-levels-mean/overview\"");

WriteLiteralTo(__razor_helper_writer, " target=\"_blank\"");

WriteLiteralTo(__razor_helper_writer, " rel=\"external\"");

WriteLiteralTo(__razor_helper_writer, ">More about levels</a></p>\r\n                        </div>\r\n                    <" +
"/details>\r\n                    \r\n\r\n                </div>\r\n            </fieldse" +
"t>\r\n            <input");

WriteLiteralTo(__razor_helper_writer, " type=\"submit\"");

WriteLiteralTo(__razor_helper_writer, " class=\"button\"");

WriteLiteralTo(__razor_helper_writer, " value=\"Update results\"");

WriteLiteralTo(__razor_helper_writer, " />\r\n        </form>\r\n    </div>\r\n");


#line 205 "..\..\Views\Apprenticeship\SearchResults.cshtml"


#line default
#line hidden
});

#line 205 "..\..\Views\Apprenticeship\SearchResults.cshtml"
}
#line default
#line hidden

        public SearchResults()
        {
        }
        public override void Execute()
        {
            
            #line 5 "..\..\Views\Apprenticeship\SearchResults.cshtml"
  
    ViewBag.Title = "Search Results";

            
            #line default
            #line hidden
WriteLiteral("\r\n<main");

WriteLiteral(" id=\"content\"");

WriteLiteral(" role=\"main\"");

WriteLiteral(">\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteAttribute("value", Tuple.Create(" value=\"", 219), Tuple.Create("\"", 244)
            
            #line 9 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 227), Tuple.Create<System.Object, System.Int32>(Model.SearchTerm
            
            #line default
            #line hidden
, 227), false)
);

WriteLiteral(" id=\"ga-search-term\"");

WriteLiteral(" />\r\n    <p");

WriteLiteral(" class=\"small-btm-margin\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 11 "..\..\Views\Apprenticeship\SearchResults.cshtml"
   Write(Html.ActionLink("Start a new search", "Search", "Apprenticeship", new { }, new { @class = "link-back new-apprenticeship-search" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </p>\r\n    <hgroup");

WriteLiteral(" class=\"hgroup\"");

WriteLiteral(">\r\n        <h1");

WriteLiteral(" class=\"heading-xlarge\"");

WriteLiteral(">\r\n            Search results\r\n        </h1>\r\n");

            
            #line 17 "..\..\Views\Apprenticeship\SearchResults.cshtml"
        
            
            #line default
            #line hidden
            
            #line 17 "..\..\Views\Apprenticeship\SearchResults.cshtml"
          
            Html.RenderPartial("_SearchResultMessage");
        
            
            #line default
            #line hidden
WriteLiteral("\r\n    </hgroup>\r\n\r\n");

            
            #line 22 "..\..\Views\Apprenticeship\SearchResults.cshtml"
    
            
            #line default
            #line hidden
            
            #line 22 "..\..\Views\Apprenticeship\SearchResults.cshtml"
     if (Model.TotalResults == 0)
    {

            
            #line default
            #line hidden
WriteLiteral("        <p>You can:</p>\r\n");

WriteLiteral("        <ul");

WriteLiteral(" class=\"list-bullet\"");

WriteLiteral(">\r\n            <li>");

            
            #line 26 "..\..\Views\Apprenticeship\SearchResults.cshtml"
           Write(Html.ActionLink("start your job role or keyword search again", "Search", "Apprenticeship", new { }));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n        </ul>\r\n");

            
            #line 28 "..\..\Views\Apprenticeship\SearchResults.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n    <div");

WriteLiteral(" class=\"grid-row\"");

WriteLiteral(">\r\n\r\n");

            
            #line 32 "..\..\Views\Apprenticeship\SearchResults.cshtml"
        
            
            #line default
            #line hidden
            
            #line 32 "..\..\Views\Apprenticeship\SearchResults.cshtml"
         if (!Model.HasError && Model.TotalResults > 0)
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"column-one-third\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"editSearch\"");

WriteLiteral(">\r\n                    <h2");

WriteLiteral(" class=\"heading-medium\"");

WriteLiteral(">\r\n                        <a");

WriteLiteral(" href=\"#EditSearch\"");

WriteLiteral(">Filter results</a>\r\n                    </h2>\r\n                    <div");

WriteLiteral(" id=\"EditSearch\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 40 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                   Write(FilterForm("filter-box"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");

            
            #line 44 "..\..\Views\Apprenticeship\SearchResults.cshtml"


            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" id=\"apprenticeship-results\"");

WriteLiteral(" class=\"column-two-thirds\"");

WriteLiteral(">\r\n                <form");

WriteLiteral(" method=\"GET\"");

WriteLiteral(" id=\"search-results-order\"");

WriteLiteral(">\r\n                    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" name=\"Keywords\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1595), Tuple.Create("\"", 1620)
            
            #line 47 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 1603), Tuple.Create<System.Object, System.Int32>(Model.SearchTerm
            
            #line default
            #line hidden
, 1603), false)
);

WriteLiteral("/>\r\n                    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" name=\"page\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1677), Tuple.Create("\"", 1702)
            
            #line 48 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 1685), Tuple.Create<System.Object, System.Int32>(Model.ActualPage
            
            #line default
            #line hidden
, 1685), false)
);

WriteLiteral("/>\r\n                    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" name=\"take\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1759), Tuple.Create("\"", 1787)
            
            #line 49 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 1767), Tuple.Create<System.Object, System.Int32>(Model.ResultsToTake
            
            #line default
            #line hidden
, 1767), false)
);

WriteLiteral("/>\r\n");

            
            #line 50 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 50 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                     foreach (var level in Model.AggregationLevel.Where(level => level.Checked))
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" name=\"SelectedLevels\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1979), Tuple.Create("\"", 1999)
            
            #line 52 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 1987), Tuple.Create<System.Object, System.Int32>(level.Value
            
            #line default
            #line hidden
, 1987), false)
);

WriteLiteral("/>\r\n");

            
            #line 53 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"form-block\"");

WriteLiteral(">\r\n                        <label");

WriteLiteral(" for=\"select-order\"");

WriteLiteral(" class=\"form-label-bold\"");

WriteLiteral(">Sort by</label>\r\n                        <select");

WriteLiteral(" name=\"order\"");

WriteLiteral(" id=\"select-order\"");

WriteLiteral(" class=\"form-control form-control-1-3\"");

WriteLiteral(">\r\n                            <option");

WriteAttribute("selected", Tuple.Create(" selected=\"", 2302), Tuple.Create("\"", 2338)
            
            #line 57 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 2313), Tuple.Create<System.Object, System.Int32>(Model.SortOrder == "1"
            
            #line default
            #line hidden
, 2313), false)
);

WriteLiteral(" value=\"1\"");

WriteLiteral(">Best match</option>\r\n                            <option");

WriteAttribute("selected", Tuple.Create(" selected=\"", 2406), Tuple.Create("\"", 2442)
            
            #line 58 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 2417), Tuple.Create<System.Object, System.Int32>(Model.SortOrder == "2"
            
            #line default
            #line hidden
, 2417), false)
);

WriteLiteral(" value=\"2\"");

WriteLiteral(">Level (high to low)</option>\r\n                            <option");

WriteAttribute("selected", Tuple.Create(" selected=\"", 2519), Tuple.Create("\"", 2555)
            
            #line 59 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 2530), Tuple.Create<System.Object, System.Int32>(Model.SortOrder == "3"
            
            #line default
            #line hidden
, 2530), false)
);

WriteLiteral(" value=\"3\"");

WriteLiteral(">Level (low to high)</option>\r\n                        </select>\r\n               " +
"         <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" value=\"Sort\"");

WriteLiteral(" class=\"button\"");

WriteLiteral(">Sort</button>\r\n                    </div>\r\n                </form>\r\n\r\n\r\n");

            
            #line 66 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                
            
            #line default
            #line hidden
            
            #line 66 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                 foreach (var item in Model.Results)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <article");

WriteAttribute("class", Tuple.Create(" class=\"", 2879), Tuple.Create("\"", 2927)
, Tuple.Create(Tuple.Create("", 2887), Tuple.Create("result", 2887), true)
            
            #line 68 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create(" ", 2893), Tuple.Create<System.Object, System.Int32>(item.ApprenticeshipType
            
            #line default
            #line hidden
, 2894), false)
, Tuple.Create(Tuple.Create("", 2920), Tuple.Create("-result", 2920), true)
);

WriteAttribute("id", Tuple.Create(" id=\"", 2928), Tuple.Create("\"", 3032)
            
            #line 68 "..\..\Views\Apprenticeship\SearchResults.cshtml"
   , Tuple.Create(Tuple.Create("", 2933), Tuple.Create<System.Object, System.Int32>(item.ApprenticeshipType
            
            #line default
            #line hidden
, 2933), false)
, Tuple.Create(Tuple.Create("", 2959), Tuple.Create("-", 2959), true)
            
            #line 68 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                              , Tuple.Create(Tuple.Create("", 2960), Tuple.Create<System.Object, System.Int32>(!item.StandardId.IsNullOrEmpty() ? item.StandardId : item.FrameworkId
            
            #line default
            #line hidden
, 2960), false)
);

WriteLiteral(">\r\n                        <header>\r\n");

WriteLiteral("                            ");

            
            #line 70 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                        Write(!item.StandardId.IsNullOrEmpty() ? GetStandardTitle(item) : GetFrameworkTitle(item));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </header>\r\n                        <dl");

WriteLiteral(" class=\"result-data-list\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 73 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                       Write(GetApprenticeshipDetailItem("Level:", "level", item.Level));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                            ");

            
            #line 74 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                       Write(GetApprenticeshipDetailItem("Typical length:", "length", item.TypicalLengthMessage));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </dl>\r\n                    </article>\r\n");

            
            #line 77 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("\r\n                <div");

WriteLiteral(" class=\"page-navigation\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 80 "..\..\Views\Apprenticeship\SearchResults.cshtml"
               Write(GetPaginationBackLink());

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                    ");

            
            #line 81 "..\..\Views\Apprenticeship\SearchResults.cshtml"
               Write(GetPaginationNextLink());

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n            </div>\r\n");

            
            #line 84 "..\..\Views\Apprenticeship\SearchResults.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n</main>\r\n\r\n");

WriteLiteral("\r\n\r\n");

WriteLiteral("\r\n\r\n");

WriteLiteral("\r\n\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
