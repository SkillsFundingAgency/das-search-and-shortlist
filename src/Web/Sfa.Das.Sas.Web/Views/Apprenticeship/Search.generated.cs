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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Apprenticeship/Search.cshtml")]
    public partial class Search : System.Web.Mvc.WebViewPage<Sfa.Das.Sas.ApplicationServices.Queries.ApprenticeshipSearchQuery>
    {
        public Search()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Apprenticeship\Search.cshtml"
  
    ViewBag.Title = "Home Page";
    ViewBag.Description = "The Find Apprenticeship Training service is for employers in England who want to find training courses for their apprentices and search for training providers.";

            
            #line default
            #line hidden
WriteLiteral("\r\n<main");

WriteLiteral(" id=\"content\"");

WriteLiteral(" role=\"main\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"grid-row\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"column-two-thirds\"");

WriteLiteral(">\r\n            <h1");

WriteLiteral(" class=\"heading-xlarge\"");

WriteLiteral(">\r\n                Find apprenticeship training\r\n            </h1>\r\n");

            
            #line 12 "..\..\Views\Apprenticeship\Search.cshtml"
            
            
            #line default
            #line hidden
            
            #line 12 "..\..\Views\Apprenticeship\Search.cshtml"
             using (Html.BeginForm("SearchResults", "Apprenticeship", FormMethod.Get, new {@class = "search-box"}))
            {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                    <!-- EXAMPLE: format of HTML and Classes to be used to get" +
" the icons to the right -->\r\n                    <div");

WriteLiteral(" class=\"icon-alerts\"");

WriteLiteral(">\r\n                        <p");

WriteLiteral(" class=\"icon-right\"");

WriteLiteral(">\r\n                            <span");

WriteLiteral(" class=\"icon-content\"");

WriteLiteral(">Green tick (use class=\"green-tick\")</span>\r\n                            <span");

WriteLiteral(" class=\"green-tick\"");

WriteLiteral("></span>\r\n                        </p>\r\n                        <p");

WriteLiteral(" class=\"icon-right\"");

WriteLiteral(">\r\n                            <span");

WriteLiteral(" class=\"icon-content\"");

WriteLiteral(">Red cross (use class=\"red-cross\")</span>\r\n                            <span");

WriteLiteral(" class=\"red-cross\"");

WriteLiteral("></span>\r\n                        </p>\r\n                    </div>\r\n             " +
"       <div");

WriteLiteral(" class=\"icon-alerts\"");

WriteLiteral(">\r\n                        <p");

WriteLiteral(" class=\"icon-right\"");

WriteLiteral(">\r\n                            <span");

WriteLiteral(" class=\"icon-content\"");

WriteLiteral(">day release</span>\r\n                            <span");

WriteLiteral(" class=\"green-tick\"");

WriteLiteral("></span>\r\n                            <span");

WriteLiteral(" class=\"icon-content\"");

WriteLiteral(">block release</span>\r\n                            <span");

WriteLiteral(" class=\"red-cross\"");

WriteLiteral("></span>\r\n                            <span");

WriteLiteral(" class=\"icon-content\"");

WriteLiteral(">at your location</span>\r\n                            <span");

WriteLiteral(" class=\"red-cross\"");

WriteLiteral("></span>\r\n                        </p>\r\n                    </div>\r\n             " +
"       <section>\r\n                        <dl");

WriteLiteral(" class=\"data-list--provider data-list--compact\"");

WriteLiteral(">  \r\n                            <dt");

WriteLiteral(" class=\"training-structure\"");

WriteLiteral(">Training Options:</dt>\r\n                            <dd");

WriteLiteral(" id=\"delivery-modes\"");

WriteLiteral(" class=\"icon-alerts\"");

WriteLiteral(">\r\n                                <ul>\r\n                                    <li");

WriteLiteral(" class=\"day-release icon-right\"");

WriteLiteral(">\r\n                                        <span");

WriteLiteral(" class=\"icon-content\"");

WriteLiteral(">day release</span>\r\n                                        <span");

WriteLiteral(" class=\"green-tick\"");

WriteLiteral("></span>\r\n                                    </li>\r\n                            " +
"        <li");

WriteLiteral(" class=\"block-release icon-right\"");

WriteLiteral(">\r\n                                        <span");

WriteLiteral(" class=\"icon-content\"");

WriteLiteral(">block release</span>\r\n                                        <span");

WriteLiteral(" class=\"red-cross\"");

WriteLiteral("></span>\r\n                                    </li>\r\n                            " +
"        <li");

WriteLiteral(" class=\"hundred-percent-employer icon-right\"");

WriteLiteral(">\r\n                                        <span");

WriteLiteral(" class=\"icon-content\"");

WriteLiteral(">at your location</span>\r\n                                        <span");

WriteLiteral(" class=\"red-cross\"");

WriteLiteral(@"></span>
                                    </li>
                
                                </ul>
                            </dd>
                        </dl>
                    </section>
                    <!-- END -->
                    <label");

WriteLiteral(" for=\"keywords\"");

WriteLiteral(">\r\n                        <span");

WriteLiteral(" class=\"form-label-bold\"");

WriteLiteral(">Search by keywords</span>\r\n                        <span");

WriteLiteral(" class=\"form-hint\"");

WriteLiteral(">Can include job title or apprenticeship</span>\r\n                    </label>\r\n  " +
"                  <span");

WriteLiteral(" class=\"error-message\"");

WriteLiteral("></span>\r\n                    <input");

WriteLiteral(" type=\"search\"");

WriteLiteral(" id=\"keywords\"");

WriteLiteral(" name=\"Keywords\"");

WriteLiteral(" class=\"text-box form-control\"");

WriteLiteral(" maxlength=\"200\"");

WriteLiteral(">\r\n                </div>\r\n");

WriteLiteral("                <input");

WriteLiteral(" class=\"button\"");

WriteLiteral(" id=\"submit-keywords\"");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" value=\"Search\"");

WriteLiteral("/>\r\n");

            
            #line 67 "..\..\Views\Apprenticeship\Search.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n    </div>\r\n</main>");

        }
    }
}
#pragma warning restore 1591
