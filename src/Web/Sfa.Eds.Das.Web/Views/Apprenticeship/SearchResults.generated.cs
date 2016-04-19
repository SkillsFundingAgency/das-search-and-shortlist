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

namespace Sfa.Eds.Das.Web.Views.Apprenticeship
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
    using Sfa.Eds.Das.Web;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Apprenticeship/SearchResults.cshtml")]
    public partial class SearchResults : System.Web.Mvc.WebViewPage<Sfa.Eds.Das.Web.ViewModels.ApprenticeshipSearchResultViewModel>
    {

#line 62 "..\..\Views\Apprenticeship\SearchResults.cshtml"
public System.Web.WebPages.HelperResult GetStandardDetailItem(string title, string id, string item, string unit = "")
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 63 "..\..\Views\Apprenticeship\SearchResults.cshtml"
 
if (!string.IsNullOrEmpty(item))
{


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <dt>");


#line 66 "..\..\Views\Apprenticeship\SearchResults.cshtml"
WriteTo(__razor_helper_writer, title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dt>\r\n");

WriteLiteralTo(__razor_helper_writer, "            <dd");

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 2187), Tuple.Create("\"", 2198)

#line 67 "..\..\Views\Apprenticeship\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 2195), Tuple.Create<System.Object, System.Int32>(id

#line default
#line hidden
, 2195), false)
);

WriteLiteralTo(__razor_helper_writer, ">");


#line 67 "..\..\Views\Apprenticeship\SearchResults.cshtml"
WriteTo(__razor_helper_writer, item);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " ");


#line 67 "..\..\Views\Apprenticeship\SearchResults.cshtml"
    WriteTo(__razor_helper_writer, unit);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dd>\r\n");


#line 68 "..\..\Views\Apprenticeship\SearchResults.cshtml"
}


#line default
#line hidden
});

#line 69 "..\..\Views\Apprenticeship\SearchResults.cshtml"
}
#line default
#line hidden

        public SearchResults()
        {
        }
        public override void Execute()
        {
WriteLiteral("﻿\r\n");

            
            #line 3 "..\..\Views\Apprenticeship\SearchResults.cshtml"
  
    ViewBag.Title = "Search Results";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<main");

WriteLiteral(" id=\"content\"");

WriteLiteral(" role=\"main\"");

WriteLiteral(">\r\n");

WriteLiteral("    ");

            
            #line 8 "..\..\Views\Apprenticeship\SearchResults.cshtml"
Write(Html.ActionLink("Search", "Search", null, new { @class = "link-back" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n    <div");

WriteLiteral(" id=\"standard-results\"");

WriteLiteral(" class=\"grid-row\"");

WriteLiteral(">\r\n\r\n        <div");

WriteLiteral(" class=\"column-two-thirds\"");

WriteLiteral(">\r\n\r\n            <div");

WriteLiteral(" class=\"hgroup\"");

WriteLiteral(">\r\n\r\n                <h1");

WriteLiteral(" class=\"heading-xlarge\"");

WriteLiteral(">\r\n                    Search results\r\n                </h1>\r\n\r\n            </div" +
">\r\n            <p>\r\n");

            
            #line 21 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                
            
            #line default
            #line hidden
            
            #line 21 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                  
                    Html.RenderPartial("_SearchResultMessage");
                
            
            #line default
            #line hidden
WriteLiteral("\r\n            </p>\r\n\r\n");

            
            #line 26 "..\..\Views\Apprenticeship\SearchResults.cshtml"
            
            
            #line default
            #line hidden
            
            #line 26 "..\..\Views\Apprenticeship\SearchResults.cshtml"
             foreach (var item in Model.Results)
            {

            
            #line default
            #line hidden
WriteLiteral("                <article");

WriteLiteral(" class=\"result\"");

WriteLiteral(">\r\n                    <header>\r\n                        <h2");

WriteLiteral(" class=\"result-title\"");

WriteLiteral(">\r\n");

            
            #line 31 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 31 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                             if (item.StandardId != 0)
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <span>\r\n");

WriteLiteral("                                    ");

            
            #line 34 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                               Write(Html.ActionLink(item.Title, "Standard", "Apprenticeship", new { @id = item.StandardId }, null));

            
            #line default
            #line hidden
WriteLiteral(" NEW\r\n                                </span>\r\n");

            
            #line 36 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                            }
                            else
                            {
                                
            
            #line default
            #line hidden
            
            #line 39 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                           Write(Html.ActionLink(item.Title, "Framework", "Apprenticeship", new { @id = item.FrameworkId }, null));

            
            #line default
            #line hidden
            
            #line 39 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                                                                                                                                 
                            }

            
            #line default
            #line hidden
WriteLiteral("                        </h2>\r\n                    </header>\r\n                   " +
"     <dl");

WriteLiteral(" class=\"result-data-list\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 44 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                       Write(GetStandardDetailItem("Level", "level", item.Level));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                            ");

            
            #line 45 "..\..\Views\Apprenticeship\SearchResults.cshtml"
                       Write(GetStandardDetailItem("Typical length:","length", item.TypicalLengthMessage));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </dl>\r\n                </article>\r\n");

            
            #line 48 "..\..\Views\Apprenticeship\SearchResults.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n    </div>\r\n</main>\r\n\r\n");

            
            #line 53 "..\..\Views\Apprenticeship\SearchResults.cshtml"
 if (Model.TotalResults == 0)
{

            
            #line default
            #line hidden
WriteLiteral("    <script>\r\n        window.onload = function() {\r\n            SearchAndShortlis" +
"t.analytics.pushEvent(\"Apprenticeship Search\", \"No results\", \"Search\");\r\n       " +
" }\r\n    </script>\r\n");

            
            #line 60 "..\..\Views\Apprenticeship\SearchResults.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
