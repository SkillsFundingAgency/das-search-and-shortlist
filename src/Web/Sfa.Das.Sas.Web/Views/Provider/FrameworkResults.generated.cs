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

namespace Sfa.Das.Sas.Web.Views.Provider
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
    
    #line 1 "..\..\Views\Provider\FrameworkResults.cshtml"
    using Sfa.Das.Sas.Web.Extensions;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Provider\FrameworkResults.cshtml"
    using Sfa.Das.Sas.Web.ViewModels;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Provider/FrameworkResults.cshtml")]
    public partial class FrameworkResults : System.Web.Mvc.WebViewPage<ProviderFrameworkSearchResultViewModel>
    {

#line 77 "..\..\Views\Provider\FrameworkResults.cshtml"
public System.Web.WebPages.HelperResult GetPaginationBackLink()
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 78 "..\..\Views\Provider\FrameworkResults.cshtml"
 
if (Model.ActualPage > 1)
{
    var previousPage = @Model.ActualPage - 1;
    var url = @Url.Action("FrameworkResults", "Provider", GetNavigationRouteValues(previousPage, Model.DeliveryModes), null);

        

#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "<a");

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 2938), Tuple.Create("\"", 2949)

#line 84 "..\..\Views\Provider\FrameworkResults.cshtml"
, Tuple.Create(Tuple.Create("", 2945), Tuple.Create<System.Object, System.Int32>(url

#line default
#line hidden
, 2945), false)
);

WriteLiteralTo(__razor_helper_writer, " style=\"visibility: visible\"");

WriteLiteralTo(__razor_helper_writer, " class=\"page-navigation__btn prev\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n            <i");

WriteLiteralTo(__razor_helper_writer, " class=\"arrow-button fa fa-angle-left\"");

WriteLiteralTo(__razor_helper_writer, "></i>\r\n            <span");

WriteLiteralTo(__razor_helper_writer, " class=\"description\"");

WriteLiteralTo(__razor_helper_writer, ">Previous <span");

WriteLiteralTo(__razor_helper_writer, " class=\"hide-mob\"");

WriteLiteralTo(__razor_helper_writer, ">page</span></span>\r\n            <span");

WriteLiteralTo(__razor_helper_writer, " class=\"counter\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 87 "..\..\Views\Provider\FrameworkResults.cshtml"
    WriteTo(__razor_helper_writer, previousPage);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " of ");


#line 87 "..\..\Views\Provider\FrameworkResults.cshtml"
                     WriteTo(__razor_helper_writer, Model.LastPage);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</span>\r\n        </a>\r\n");


#line 89 "..\..\Views\Provider\FrameworkResults.cshtml"
}


#line default
#line hidden
});

#line 90 "..\..\Views\Provider\FrameworkResults.cshtml"
}
#line default
#line hidden

#line 93 "..\..\Views\Provider\FrameworkResults.cshtml"
public System.Web.WebPages.HelperResult GetPaginationNextLink()
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 94 "..\..\Views\Provider\FrameworkResults.cshtml"
 
if (Model.ActualPage < Model.LastPage)
{
    var nextPage = @Model.ActualPage + 1;

    var url = @Url.Action("FrameworkResults", "Provider", GetNavigationRouteValues(nextPage, Model.DeliveryModes), null);

        

#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "<a");

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 3522), Tuple.Create("\"", 3533)

#line 101 "..\..\Views\Provider\FrameworkResults.cshtml"
, Tuple.Create(Tuple.Create("", 3529), Tuple.Create<System.Object, System.Int32>(url

#line default
#line hidden
, 3529), false)
);

WriteLiteralTo(__razor_helper_writer, " style=\"visibility: visible\"");

WriteLiteralTo(__razor_helper_writer, " class=\"page-navigation__btn next\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n            <i");

WriteLiteralTo(__razor_helper_writer, " class=\"arrow-button fa fa-angle-right\"");

WriteLiteralTo(__razor_helper_writer, "></i>\r\n            <span");

WriteLiteralTo(__razor_helper_writer, " class=\"description\"");

WriteLiteralTo(__razor_helper_writer, ">Next <span");

WriteLiteralTo(__razor_helper_writer, " class=\"hide-mob\"");

WriteLiteralTo(__razor_helper_writer, ">page</span></span>\r\n            <span");

WriteLiteralTo(__razor_helper_writer, " class=\"counter\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 104 "..\..\Views\Provider\FrameworkResults.cshtml"
    WriteTo(__razor_helper_writer, nextPage);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " of ");


#line 104 "..\..\Views\Provider\FrameworkResults.cshtml"
                 WriteTo(__razor_helper_writer, Model.LastPage);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</span>\r\n        </a>\r\n");


#line 106 "..\..\Views\Provider\FrameworkResults.cshtml"
}


#line default
#line hidden
});

#line 107 "..\..\Views\Provider\FrameworkResults.cshtml"
}
#line default
#line hidden

#line 109 "..\..\Views\Provider\FrameworkResults.cshtml"
public System.Web.WebPages.HelperResult FilterForm(string cssClass)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 110 "..\..\Views\Provider\FrameworkResults.cshtml"
 
    if (!Model.DeliveryModes.IsNullOrEmpty())
    {
        var hideMenu = true;
        foreach (var deliveryMode in Model.DeliveryModes.Where(deliveryMode => deliveryMode.Count != 0))
        {
            hideMenu = false;
        }

        if (@Model.TotalResults != 0 || !hideMenu)
        {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "                <div");

WriteLiteralTo(__razor_helper_writer, " class=\"editSearch\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n                    <h2");

WriteLiteralTo(__razor_helper_writer, " class=\"heading-medium\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n                        <a");

WriteLiteralTo(__razor_helper_writer, " href=\"#EditSearch\"");

WriteLiteralTo(__razor_helper_writer, ">Edit search</a>\r\n                    </h2>\r\n                    <div");

WriteLiteralTo(__razor_helper_writer, " id=\"EditSearch\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n                        <div");

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 4438), Tuple.Create("\"", 4469)
, Tuple.Create(Tuple.Create("", 4446), Tuple.Create("filters-block", 4446), true)

#line 126 "..\..\Views\Provider\FrameworkResults.cshtml"
, Tuple.Create(Tuple.Create(" ", 4459), Tuple.Create<System.Object, System.Int32>(cssClass

#line default
#line hidden
, 4460), false)
);

WriteLiteralTo(__razor_helper_writer, ">\r\n                            <form");

WriteLiteralTo(__razor_helper_writer, " method=\"get\"");

WriteLiteralTo(__razor_helper_writer, " autocomplete=\"off\"");

WriteAttributeTo(__razor_helper_writer, "action", Tuple.Create(" action=\"", 4538), Tuple.Create("\"", 4566)

#line 127 "..\..\Views\Provider\FrameworkResults.cshtml"
, Tuple.Create(Tuple.Create("", 4547), Tuple.Create<System.Object, System.Int32>(Model.AbsolutePath

#line default
#line hidden
, 4547), false)
);

WriteLiteralTo(__razor_helper_writer, ">\r\n                                <input");

WriteLiteralTo(__razor_helper_writer, " type=\"hidden\"");

WriteLiteralTo(__razor_helper_writer, " name=\"PostCode\"");

WriteAttributeTo(__razor_helper_writer, "value", Tuple.Create(" value=\"", 4638), Tuple.Create("\"", 4661)

#line 128 "..\..\Views\Provider\FrameworkResults.cshtml"
, Tuple.Create(Tuple.Create("", 4646), Tuple.Create<System.Object, System.Int32>(Model.PostCode

#line default
#line hidden
, 4646), false)
);

WriteLiteralTo(__razor_helper_writer, " />\r\n                                <input");

WriteLiteralTo(__razor_helper_writer, " type=\"hidden\"");

WriteLiteralTo(__razor_helper_writer, " name=\"apprenticeshipid\"");

WriteAttributeTo(__razor_helper_writer, "value", Tuple.Create(" value=\"", 4743), Tuple.Create("\"", 4769)

#line 129 "..\..\Views\Provider\FrameworkResults.cshtml"
    , Tuple.Create(Tuple.Create("", 4751), Tuple.Create<System.Object, System.Int32>(Model.FrameworkId

#line default
#line hidden
, 4751), false)
);

WriteLiteralTo(__razor_helper_writer, "/>\r\n                                <input");

WriteLiteralTo(__razor_helper_writer, " type=\"hidden\"");

WriteLiteralTo(__razor_helper_writer, " name=\"ShowAll\"");

WriteAttributeTo(__razor_helper_writer, "value", Tuple.Create(" value=\"", 4841), Tuple.Create("\"", 4874)

#line 130 "..\..\Views\Provider\FrameworkResults.cshtml"
, Tuple.Create(Tuple.Create("", 4849), Tuple.Create<System.Object, System.Int32>(Model.ShowAll.ToString()

#line default
#line hidden
, 4849), false)
);

WriteLiteralTo(__razor_helper_writer, " />\r\n");


#line 131 "..\..\Views\Provider\FrameworkResults.cshtml"
                                

#line default
#line hidden

#line 131 "..\..\Views\Provider\FrameworkResults.cshtml"
                                  
                                    Html.RenderPartial("_FilterProviders", Model.DeliveryModes);
                                

#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n                                <input");

WriteLiteralTo(__razor_helper_writer, " type=\"submit\"");

WriteLiteralTo(__razor_helper_writer, " value=\"Update results\"");

WriteLiteralTo(__razor_helper_writer, " class=\"button margin-top-x2 postcode-search-button\"");

WriteLiteralTo(__razor_helper_writer, " />\r\n                            </form>\r\n                        </div>\r\n       " +
"             </div>\r\n                </div>\r\n");


#line 139 "..\..\Views\Provider\FrameworkResults.cshtml"
        }
    }


#line default
#line hidden
});

#line 141 "..\..\Views\Provider\FrameworkResults.cshtml"
}
#line default
#line hidden

        #line 144 "..\..\Views\Provider\FrameworkResults.cshtml"
 
    RouteValueDictionary GetNavigationRouteValues(int page, IEnumerable<DeliveryModeViewModel> deliveryModes)
    {

        var rv = new RouteValueDictionary { { "apprenticeshipid", Model.FrameworkId }, { "postcode", Model.PostCode }, { "page", page }, { "showall", Model.ShowAll } };
        int i = 0;
        foreach (var deliveryMode in deliveryModes.Where(m => m.Checked))
        {
            rv.Add("DeliveryModes[" + i + "]", deliveryMode.Value);
            i++;
        }
        return rv;
    }

        #line default
        #line hidden
        
        public FrameworkResults()
        {
        }
        public override void Execute()
        {
            
            #line 5 "..\..\Views\Provider\FrameworkResults.cshtml"
  
    ViewBag.Title = "Provider Search Results";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<main");

WriteLiteral(" id=\"content\"");

WriteLiteral(" role=\"main\"");

WriteLiteral(">\r\n");

            
            #line 10 "..\..\Views\Provider\FrameworkResults.cshtml"
    
            
            #line default
            #line hidden
            
            #line 10 "..\..\Views\Provider\FrameworkResults.cshtml"
     if (Model.Hits.Count() != 0)
    {

            
            #line default
            #line hidden
WriteLiteral("        <p");

WriteLiteral(" class=\"small-btm-margin\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 13 "..\..\Views\Provider\FrameworkResults.cshtml"
       Write(Html.ActionLink("Find providers for a different postcode", "SearchForFrameworkProviders", "Apprenticeship", new { @frameworkId = Model.FrameworkId, @keywords = Model.SearchTerms }, new { @class = "link-back new-postcode-search" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </p>\r\n");

            
            #line 15 "..\..\Views\Provider\FrameworkResults.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"grid-row\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"column-two-thirds\"");

WriteLiteral(">\r\n            <hgroup");

WriteLiteral(" class=\"hgroup\"");

WriteLiteral(">\r\n                <h1");

WriteLiteral(" class=\"heading-xlarge\"");

WriteLiteral(">\r\n                    Search results\r\n                </h1>\r\n\r\n                <" +
"p>\r\n");

            
            #line 24 "..\..\Views\Provider\FrameworkResults.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 24 "..\..\Views\Provider\FrameworkResults.cshtml"
                      
                        Html.RenderPartial("_FrameworkSearchResultMessage");
                    
            
            #line default
            #line hidden
WriteLiteral("\r\n                </p>\r\n            </hgroup>\r\n");

            
            #line 29 "..\..\Views\Provider\FrameworkResults.cshtml"
            
            
            #line default
            #line hidden
            
            #line 29 "..\..\Views\Provider\FrameworkResults.cshtml"
             if (Model.TotalResults == 0)
            {

            
            #line default
            #line hidden
WriteLiteral("                <div>\r\n                    You can:\r\n                    <ul");

WriteLiteral(" class=\"list list-bullet\"");

WriteLiteral(">\r\n");

            
            #line 34 "..\..\Views\Provider\FrameworkResults.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 34 "..\..\Views\Provider\FrameworkResults.cshtml"
                         if (Model.TotalProvidersCountry > 0)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <li");

WriteLiteral(" class=\"total-providers-country\"");

WriteLiteral(">");

            
            #line 36 "..\..\Views\Provider\FrameworkResults.cshtml"
                                                           Write(Html.ActionLink($"view all ({@Model.TotalProvidersCountry}) training providers", "FrameworkResults", "Provider", new { @apprenticeshipId = @Model.FrameworkId, @postcode = Model.PostCode, @showAll = true }, new { @class = "" }));

            
            #line default
            #line hidden
WriteLiteral(" for ");

            
            #line 36 "..\..\Views\Provider\FrameworkResults.cshtml"
                                                                                                                                                                                                                                                                                                   Write(Model.FrameworkName);

            
            #line default
            #line hidden
WriteLiteral(" in England</li>\r\n");

            
            #line 37 "..\..\Views\Provider\FrameworkResults.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                        <li");

WriteLiteral(" class=\"return-search-results\"");

WriteLiteral(">");

            
            #line 38 "..\..\Views\Provider\FrameworkResults.cshtml"
                                                     Write(Html.ActionLink("return to your apprenticeship training search results", "SearchResults", "Apprenticeship", new { @keywords = @Model.SearchTerms }, new { }));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n                        <li");

WriteLiteral(" class=\"start-again\"");

WriteLiteral(">");

            
            #line 39 "..\..\Views\Provider\FrameworkResults.cshtml"
                                           Write(Html.ActionLink("start your keyword search again", "Search", "Apprenticeship"));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n                    </ul>\r\n                </div>\r\n");

            
            #line 42 "..\..\Views\Provider\FrameworkResults.cshtml"

            }

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"grid-row\"");

WriteLiteral(">\r\n\r\n        <div");

WriteLiteral(" class=\"column-third\"");

WriteLiteral(">\r\n\r\n");

WriteLiteral("            ");

            
            #line 51 "..\..\Views\Provider\FrameworkResults.cshtml"
       Write(FilterForm("filter-box"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <div");

WriteLiteral(" id=\"provider-results\"");

WriteLiteral(" class=\"column-two-thirds\"");

WriteLiteral(">\r\n");

            
            #line 54 "..\..\Views\Provider\FrameworkResults.cshtml"
            
            
            #line default
            #line hidden
            
            #line 54 "..\..\Views\Provider\FrameworkResults.cshtml"
              
                Html.RenderPartial("_FrameworkProviderInformation");
            
            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n\r\n    <div");

WriteLiteral(" class=\"page-navigation\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 62 "..\..\Views\Provider\FrameworkResults.cshtml"
   Write(GetPaginationBackLink());

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

            
            #line 63 "..\..\Views\Provider\FrameworkResults.cshtml"
   Write(GetPaginationNextLink());

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n\r\n</main>\r\n\r\n");

            
            #line 68 "..\..\Views\Provider\FrameworkResults.cshtml"
 if (Model.TotalResults == 0)
{

            
            #line default
            #line hidden
WriteLiteral("    <script>\r\n        window.onload = function () {\r\n            SearchAndShortli" +
"st.analytics.pushEvent(\"Provider Search\", \"No results\", \"Search\");\r\n        }\r\n " +
"   </script>\r\n");

            
            #line 75 "..\..\Views\Provider\FrameworkResults.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("\r\n\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
