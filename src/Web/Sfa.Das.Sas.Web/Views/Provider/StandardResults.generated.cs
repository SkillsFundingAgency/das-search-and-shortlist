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
    
    #line 1 "..\..\Views\Provider\StandardResults.cshtml"
    using Sfa.Das.Sas.Web.Extensions;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Provider\StandardResults.cshtml"
    using Sfa.Das.Sas.Web.ViewModels;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Provider/StandardResults.cshtml")]
    public partial class StandardResults : System.Web.Mvc.WebViewPage<ProviderStandardSearchResultViewModel>
    {

#line 96 "..\..\Views\Provider\StandardResults.cshtml"
public System.Web.WebPages.HelperResult GetPaginationBackLink()
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 97 "..\..\Views\Provider\StandardResults.cshtml"
 
if (Model.ActualPage > 1)
{
    var previousPage = @Model.ActualPage - 1;
    var url = @Url.Action("StandardResults", "Provider", GetNavigationRouteValues(previousPage, Model.DeliveryModes), null);

        

#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "<a");

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 4350), Tuple.Create("\"", 4361)

#line 103 "..\..\Views\Provider\StandardResults.cshtml"
, Tuple.Create(Tuple.Create("", 4357), Tuple.Create<System.Object, System.Int32>(url

#line default
#line hidden
, 4357), false)
);

WriteLiteralTo(__razor_helper_writer, " style=\"visibility: visible\"");

WriteLiteralTo(__razor_helper_writer, " class=\"page-navigation__btn prev\"");

WriteLiteralTo(__razor_helper_writer, ">\n            <i");

WriteLiteralTo(__razor_helper_writer, " class=\"arrow-button fa fa-angle-left\"");

WriteLiteralTo(__razor_helper_writer, "></i>\n            <span");

WriteLiteralTo(__razor_helper_writer, " class=\"description\"");

WriteLiteralTo(__razor_helper_writer, ">Previous <span");

WriteLiteralTo(__razor_helper_writer, " class=\"hide-mob\"");

WriteLiteralTo(__razor_helper_writer, ">page</span></span>\n            <span");

WriteLiteralTo(__razor_helper_writer, " class=\"counter\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 106 "..\..\Views\Provider\StandardResults.cshtml"
    WriteTo(__razor_helper_writer, previousPage);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " of ");


#line 106 "..\..\Views\Provider\StandardResults.cshtml"
                     WriteTo(__razor_helper_writer, Model.LastPage);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</span>\n        </a>\n");


#line 108 "..\..\Views\Provider\StandardResults.cshtml"
}


#line default
#line hidden
});

#line 109 "..\..\Views\Provider\StandardResults.cshtml"
}
#line default
#line hidden

#line 111 "..\..\Views\Provider\StandardResults.cshtml"
public System.Web.WebPages.HelperResult GetPaginationNextLink()
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 112 "..\..\Views\Provider\StandardResults.cshtml"
 
if (Model.ActualPage < Model.LastPage)
{
    var nextPage = @Model.ActualPage + 1;

    var url = @Url.Action("StandardResults", "Provider", GetNavigationRouteValues(nextPage, Model.DeliveryModes), null);
        

#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "<a");

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 4914), Tuple.Create("\"", 4925)

#line 118 "..\..\Views\Provider\StandardResults.cshtml"
, Tuple.Create(Tuple.Create("", 4921), Tuple.Create<System.Object, System.Int32>(url

#line default
#line hidden
, 4921), false)
);

WriteLiteralTo(__razor_helper_writer, " style=\"visibility: visible\"");

WriteLiteralTo(__razor_helper_writer, " class=\"page-navigation__btn next\"");

WriteLiteralTo(__razor_helper_writer, ">\n            <i");

WriteLiteralTo(__razor_helper_writer, " class=\"arrow-button fa fa-angle-right\"");

WriteLiteralTo(__razor_helper_writer, "></i>\n            <span");

WriteLiteralTo(__razor_helper_writer, " class=\"description\"");

WriteLiteralTo(__razor_helper_writer, ">Next <span");

WriteLiteralTo(__razor_helper_writer, " class=\"hide-mob\"");

WriteLiteralTo(__razor_helper_writer, ">page</span></span>\n            <span");

WriteLiteralTo(__razor_helper_writer, " class=\"counter\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 121 "..\..\Views\Provider\StandardResults.cshtml"
    WriteTo(__razor_helper_writer, nextPage);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " of ");


#line 121 "..\..\Views\Provider\StandardResults.cshtml"
                 WriteTo(__razor_helper_writer, Model.LastPage);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</span>\n        </a>\n");


#line 123 "..\..\Views\Provider\StandardResults.cshtml"
}


#line default
#line hidden
});

#line 124 "..\..\Views\Provider\StandardResults.cshtml"
}
#line default
#line hidden

#line 126 "..\..\Views\Provider\StandardResults.cshtml"
public System.Web.WebPages.HelperResult FilterForm(string cssClass)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 127 "..\..\Views\Provider\StandardResults.cshtml"
 
if (!Model.DeliveryModes.IsNullOrEmpty())
{
    var hideMenu = Model.DeliveryModes.All(deliveryMode => deliveryMode.Count == 0);

    if (@Model.TotalResults != 0 || !hideMenu)
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <div");

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 5459), Tuple.Create("\"", 5476)

#line 134 "..\..\Views\Provider\StandardResults.cshtml"
, Tuple.Create(Tuple.Create("", 5467), Tuple.Create<System.Object, System.Int32>(cssClass

#line default
#line hidden
, 5467), false)
);

WriteLiteralTo(__razor_helper_writer, ">\n                <form");

WriteLiteralTo(__razor_helper_writer, " method=\"get\"");

WriteLiteralTo(__razor_helper_writer, " autocomplete=\"off\"");

WriteAttributeTo(__razor_helper_writer, "action", Tuple.Create(" action=\"", 5532), Tuple.Create("\"", 5560)

#line 135 "..\..\Views\Provider\StandardResults.cshtml"
, Tuple.Create(Tuple.Create("", 5541), Tuple.Create<System.Object, System.Int32>(Model.AbsolutePath

#line default
#line hidden
, 5541), false)
);

WriteLiteralTo(__razor_helper_writer, ">\n                    <input");

WriteLiteralTo(__razor_helper_writer, " type=\"hidden\"");

WriteLiteralTo(__razor_helper_writer, " name=\"PostCode\"");

WriteAttributeTo(__razor_helper_writer, "value", Tuple.Create(" value=\"", 5619), Tuple.Create("\"", 5659)

#line 136 "..\..\Views\Provider\StandardResults.cshtml"
, Tuple.Create(Tuple.Create("", 5627), Tuple.Create<System.Object, System.Int32>(Model.PostCode.FormatPostcode()

#line default
#line hidden
, 5627), false)
);

WriteLiteralTo(__razor_helper_writer, " />\n                    <input");

WriteLiteralTo(__razor_helper_writer, " type=\"hidden\"");

WriteLiteralTo(__razor_helper_writer, " name=\"apprenticeshipid\"");

WriteAttributeTo(__razor_helper_writer, "value", Tuple.Create(" value=\"", 5728), Tuple.Create("\"", 5753)

#line 137 "..\..\Views\Provider\StandardResults.cshtml"
, Tuple.Create(Tuple.Create("", 5736), Tuple.Create<System.Object, System.Int32>(Model.StandardId

#line default
#line hidden
, 5736), false)
);

WriteLiteralTo(__razor_helper_writer, " />\n                    <input");

WriteLiteralTo(__razor_helper_writer, " type=\"hidden\"");

WriteLiteralTo(__razor_helper_writer, " name=\"showAll\"");

WriteAttributeTo(__razor_helper_writer, "value", Tuple.Create(" value=\"", 5813), Tuple.Create("\"", 5846)

#line 138 "..\..\Views\Provider\StandardResults.cshtml"
, Tuple.Create(Tuple.Create("", 5821), Tuple.Create<System.Object, System.Int32>(Model.ShowAll.ToString()

#line default
#line hidden
, 5821), false)
);

WriteLiteralTo(__razor_helper_writer, " />\n                    <input");

WriteLiteralTo(__razor_helper_writer, " type=\"hidden\"");

WriteLiteralTo(__razor_helper_writer, " name=\"keywords\"");

WriteAttributeTo(__razor_helper_writer, "value", Tuple.Create(" value=\"", 5907), Tuple.Create("\"", 5933)

#line 139 "..\..\Views\Provider\StandardResults.cshtml"
, Tuple.Create(Tuple.Create("", 5915), Tuple.Create<System.Object, System.Int32>(Model.SearchTerms

#line default
#line hidden
, 5915), false)
);

WriteLiteralTo(__razor_helper_writer, " />\n");


#line 140 "..\..\Views\Provider\StandardResults.cshtml"
                    

#line default
#line hidden

#line 140 "..\..\Views\Provider\StandardResults.cshtml"
                      
                        Html.RenderPartial("_FilterProviders", Model.DeliveryModes);
                    

#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\n");


#line 143 "..\..\Views\Provider\StandardResults.cshtml"
                    

#line default
#line hidden

#line 143 "..\..\Views\Provider\StandardResults.cshtml"
                      
                        Html.RenderPartial("_FilterNationalProviders", Model.NationalProviders);
                    

#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\n                    <input");

WriteLiteralTo(__razor_helper_writer, " type=\"submit\"");

WriteLiteralTo(__razor_helper_writer, " value=\"Update results\"");

WriteLiteralTo(__razor_helper_writer, " class=\"button margin-top-x2 postcode-search-button\"");

WriteLiteralTo(__razor_helper_writer, " />\n                </form>\n            </div>\n");


#line 149 "..\..\Views\Provider\StandardResults.cshtml"
                            }
                        }


#line default
#line hidden
});

#line 151 "..\..\Views\Provider\StandardResults.cshtml"
}
#line default
#line hidden

        #line 154 "..\..\Views\Provider\StandardResults.cshtml"
 
    RouteValueDictionary GetNavigationRouteValues(int page, IEnumerable<DeliveryModeViewModel> deliveryModes)
    {

        var rv = new RouteValueDictionary { { "apprenticeshipid", Model.StandardId }, { "postcode", Model.PostCode.FormatPostcode() }, { "page", page }, { "showall", Model.ShowAll } };
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
        
        public StandardResults()
        {
        }
        public override void Execute()
        {
            
            #line 5 "..\..\Views\Provider\StandardResults.cshtml"
  
    ViewBag.Title = "Provider Search Results";
    ViewBag.Description = "The Find Apprenticeship Training service is for employers in England who want to find training courses for their apprentices and search for training providers.";

            
            #line default
            #line hidden
WriteLiteral("\n\n<main");

WriteLiteral(" id=\"content\"");

WriteLiteral(" role=\"main\"");

WriteLiteral(">\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteAttribute("value", Tuple.Create(" value=\"", 412), Tuple.Create("\"", 452)
            
            #line 11 "..\..\Views\Provider\StandardResults.cshtml"
, Tuple.Create(Tuple.Create("", 420), Tuple.Create<System.Object, System.Int32>(Model.PostCode.FormatPostcode()
            
            #line default
            #line hidden
, 420), false)
);

WriteLiteral(" id=\"ga-postcode\"");

WriteLiteral(" />\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteAttribute("value", Tuple.Create(" value=\"", 498), Tuple.Create("\"", 553)
            
            #line 12 "..\..\Views\Provider\StandardResults.cshtml"
, Tuple.Create(Tuple.Create("", 506), Tuple.Create<System.Object, System.Int32>(Model.StandardName
            
            #line default
            #line hidden
, 506), false)
, Tuple.Create(Tuple.Create("", 525), Tuple.Create(",", 525), true)
, Tuple.Create(Tuple.Create(" ", 526), Tuple.Create("level", 527), true)
            
            #line 12 "..\..\Views\Provider\StandardResults.cshtml"
, Tuple.Create(Tuple.Create(" ", 532), Tuple.Create<System.Object, System.Int32>(Model.StandardLevel
            
            #line default
            #line hidden
, 533), false)
);

WriteLiteral(" id=\"ga-apprenticeship-title\"");

WriteLiteral("/>\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteAttribute("value", Tuple.Create(" value=\"", 610), Tuple.Create("\"", 656)
            
            #line 13 "..\..\Views\Provider\StandardResults.cshtml"
, Tuple.Create(Tuple.Create("", 618), Tuple.Create<System.Object, System.Int32>(Model.Hits.IsNullOrEmpty().ToString()
            
            #line default
            #line hidden
, 618), false)
);

WriteLiteral(" id=\"ga-no-result\"");

WriteLiteral("/>\n\n");

            
            #line 15 "..\..\Views\Provider\StandardResults.cshtml"
    
            
            #line default
            #line hidden
            
            #line 15 "..\..\Views\Provider\StandardResults.cshtml"
     if (Model.Hits.Count() != 0)
    {

            
            #line default
            #line hidden
WriteLiteral("        <p");

WriteLiteral(" class=\"small-btm-margin\"");

WriteLiteral(">\n");

WriteLiteral("            ");

            
            #line 18 "..\..\Views\Provider\StandardResults.cshtml"
       Write(Html.ActionLink("Find providers for a different postcode", "SearchForStandardProviders", "Apprenticeship", new { @standardId = Model.StandardId, @keywords = Model.SearchTerms }, new { @class = "link-back new-postcode-search" }));

            
            #line default
            #line hidden
WriteLiteral("\n        </p>\n");

            
            #line 20 "..\..\Views\Provider\StandardResults.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    <div>\n        <div>\n            <hgroup");

WriteLiteral(" class=\"hgroup\"");

WriteLiteral(">\n                <h1");

WriteLiteral(" class=\"heading-xlarge\"");

WriteLiteral(">\n                    Search results\n                </h1>\n");

            
            #line 27 "..\..\Views\Provider\StandardResults.cshtml"
                
            
            #line default
            #line hidden
            
            #line 27 "..\..\Views\Provider\StandardResults.cshtml"
                  
                    Html.RenderPartial("_StandardSearchResultMessage");
                
            
            #line default
            #line hidden
WriteLiteral("\n            </hgroup>\n        </div>\n    </div>\n\n");

            
            #line 34 "..\..\Views\Provider\StandardResults.cshtml"
    
            
            #line default
            #line hidden
            
            #line 34 "..\..\Views\Provider\StandardResults.cshtml"
     if (Model.ShowNationalProviders && Model.TotalResults == 0)
    {

            
            #line default
            #line hidden
WriteLiteral("        <p>\n            Sorry, there are currently no results for the filters you" +
" applied\'.\n        </p>\n");

WriteLiteral("        <div>\r\n            <p>You can:</p>\r\n            <ul");

WriteLiteral(" class=\"list list-bullet\"");

WriteLiteral(">\r\n                <li");

WriteLiteral(" class=\"return-search-results\"");

WriteLiteral(">");

            
            #line 42 "..\..\Views\Provider\StandardResults.cshtml"
                                             Write(Html.ActionLink("return to your apprenticeship training search results", "StandardResults", "Provider", new {@apprenticeshipid = @Model.StandardId, @postcode = @Model.PostCode, @keywords = @Model.SearchTerms}, new {}));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n                <li");

WriteLiteral(" class=\"start-again\"");

WriteLiteral(">");

            
            #line 43 "..\..\Views\Provider\StandardResults.cshtml"
                                   Write(Html.ActionLink("start your job role or keyword search again", "Search", "Apprenticeship"));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n            </ul>\r\n        </div>\r\n");

            
            #line 46 "..\..\Views\Provider\StandardResults.cshtml"

        
            
            #line default
            #line hidden
            
            #line 47 "..\..\Views\Provider\StandardResults.cshtml"
   Write(Html.Partial("_Help"));

            
            #line default
            #line hidden
            
            #line 47 "..\..\Views\Provider\StandardResults.cshtml"
                              
    }
    else if (Model.TotalResults == 0)
    {

            
            #line default
            #line hidden
WriteLiteral("        <p>\n            Sorry, there are currently no training providers for <b>");

            
            #line 52 "..\..\Views\Provider\StandardResults.cshtml"
                                                               Write(Model.StandardName);

            
            #line default
            #line hidden
WriteLiteral(", level ");

            
            #line 52 "..\..\Views\Provider\StandardResults.cshtml"
                                                                                          Write(Model.StandardLevel);

            
            #line default
            #line hidden
WriteLiteral("</b> for \'<b>");

            
            #line 52 "..\..\Views\Provider\StandardResults.cshtml"
                                                                                                                           Write(Model.PostCode);

            
            #line default
            #line hidden
WriteLiteral("</b>\'.\n        </p>\n");

WriteLiteral("        <div>\r\n            <p>You can:</p>\r\n            <ul");

WriteLiteral(" class=\"list list-bullet\"");

WriteLiteral(">\r\n");

            
            #line 57 "..\..\Views\Provider\StandardResults.cshtml"
                
            
            #line default
            #line hidden
            
            #line 57 "..\..\Views\Provider\StandardResults.cshtml"
                 if (Model.TotalResultsForCountry > 0)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <li");

WriteLiteral(" class=\"total-providers-country\"");

WriteLiteral(">");

            
            #line 59 "..\..\Views\Provider\StandardResults.cshtml"
                                                   Write(Html.ActionLink(string.Format("view all ({0}) training providers", @Model.TotalResultsForCountry), "StandardResults", "Provider", new {@apprenticeshipId = @Model.StandardId, @postcode = Model.PostCode, @showAll = true}, new {@class = ""}));

            
            #line default
            #line hidden
WriteLiteral(" for <b>");

            
            #line 59 "..\..\Views\Provider\StandardResults.cshtml"
                                                                                                                                                                                                                                                                                                          Write(Model.StandardName);

            
            #line default
            #line hidden
WriteLiteral(", level ");

            
            #line 59 "..\..\Views\Provider\StandardResults.cshtml"
                                                                                                                                                                                                                                                                                                                                     Write(Model.StandardLevel);

            
            #line default
            #line hidden
WriteLiteral("</b> in England</li>\n");

            
            #line 60 "..\..\Views\Provider\StandardResults.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                <li");

WriteLiteral(" class=\"return-search-results\"");

WriteLiteral(">");

            
            #line 61 "..\..\Views\Provider\StandardResults.cshtml"
                                             Write(Html.ActionLink("return to your apprenticeship training search results", "SearchResults", "Apprenticeship", new {@keywords = @Model.SearchTerms}, new {}));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n                <li");

WriteLiteral(" class=\"start-again\"");

WriteLiteral(">");

            
            #line 62 "..\..\Views\Provider\StandardResults.cshtml"
                                   Write(Html.ActionLink("start your job role or keyword search again", "Search", "Apprenticeship"));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n            </ul>\r\n        </div>\r\n");

            
            #line 65 "..\..\Views\Provider\StandardResults.cshtml"

        
            
            #line default
            #line hidden
            
            #line 66 "..\..\Views\Provider\StandardResults.cshtml"
   Write(Html.Partial("_Help"));

            
            #line default
            #line hidden
            
            #line 66 "..\..\Views\Provider\StandardResults.cshtml"
                              
    }

            
            #line default
            #line hidden
WriteLiteral("\n    <div");

WriteLiteral(" class=\"grid-row\"");

WriteLiteral(">\n        <div");

WriteLiteral(" class=\"column-third\"");

WriteLiteral(">\n            <div");

WriteLiteral(" class=\"editSearch\"");

WriteLiteral(">\n");

            
            #line 72 "..\..\Views\Provider\StandardResults.cshtml"
                
            
            #line default
            #line hidden
            
            #line 72 "..\..\Views\Provider\StandardResults.cshtml"
                 if (Model.Hits.Any() && !Model.HasError)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <h2");

WriteLiteral(" class=\"heading-medium\"");

WriteLiteral(">\n                        <a");

WriteLiteral(" href=\"#EditSearch\"");

WriteLiteral(">Filter results</a>\n                    </h2>\n");

WriteLiteral("                    <div");

WriteLiteral(" id=\"EditSearch\"");

WriteLiteral(">\n");

WriteLiteral("                        ");

            
            #line 78 "..\..\Views\Provider\StandardResults.cshtml"
                   Write(FilterForm("filter-box"));

            
            #line default
            #line hidden
WriteLiteral("\n                    </div>\n");

            
            #line 80 "..\..\Views\Provider\StandardResults.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </div>\n        </div>\n\n        <div");

WriteLiteral(" id=\"provider-results\"");

WriteLiteral(" class=\"column-two-thirds\"");

WriteLiteral(">\n");

            
            #line 85 "..\..\Views\Provider\StandardResults.cshtml"
            
            
            #line default
            #line hidden
            
            #line 85 "..\..\Views\Provider\StandardResults.cshtml"
              
                Html.RenderPartial("_StandardProviderInformation");
            
            
            #line default
            #line hidden
WriteLiteral("\n            <div");

WriteLiteral(" class=\"page-navigation\"");

WriteLiteral(">\n");

WriteLiteral("                ");

            
            #line 89 "..\..\Views\Provider\StandardResults.cshtml"
           Write(GetPaginationBackLink());

            
            #line default
            #line hidden
WriteLiteral("\n");

WriteLiteral("                ");

            
            #line 90 "..\..\Views\Provider\StandardResults.cshtml"
           Write(GetPaginationNextLink());

            
            #line default
            #line hidden
WriteLiteral("\n            </div>\n        </div>\n    </div>\n</main>\n\n");

WriteLiteral("\n");

WriteLiteral("\n");

WriteLiteral("\n");

        }
    }
}
#pragma warning restore 1591
