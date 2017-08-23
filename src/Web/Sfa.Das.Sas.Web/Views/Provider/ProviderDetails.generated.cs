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
    
    #line 1 "..\..\Views\Provider\ProviderDetails.cshtml"
    using Sfa.Das.Sas.Web.Extensions;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Provider\ProviderDetails.cshtml"
    using Sfa.Das.Sas.Web.ViewModels;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Provider/ProviderDetails.cshtml")]
    public partial class ProviderDetails : System.Web.Mvc.WebViewPage<ProviderDetailsViewModel>
    {

#line 85 "..\..\Views\Provider\ProviderDetails.cshtml"
public System.Web.WebPages.HelperResult GetStandardPropertyHtml(string title, string id, string item, bool hideIfEmpty = false)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 86 "..\..\Views\Provider\ProviderDetails.cshtml"
 
if (!string.IsNullOrEmpty(item) || !hideIfEmpty)
{


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <dt");

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 3945), Tuple.Create("\"", 3962)

#line 89 "..\..\Views\Provider\ProviderDetails.cshtml"
, Tuple.Create(Tuple.Create("", 3953), Tuple.Create<System.Object, System.Int32>(id

#line default
#line hidden
, 3953), false)
, Tuple.Create(Tuple.Create("", 3956), Tuple.Create("-title", 3956), true)
);

WriteLiteralTo(__razor_helper_writer, ">");


#line 89 "..\..\Views\Provider\ProviderDetails.cshtml"
WriteTo(__razor_helper_writer, title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dt>\r\n");

WriteLiteralTo(__razor_helper_writer, "        <dd");

WriteAttributeTo(__razor_helper_writer, "id", Tuple.Create(" id=\"", 3988), Tuple.Create("\"", 3996)

#line 90 "..\..\Views\Provider\ProviderDetails.cshtml"
, Tuple.Create(Tuple.Create("", 3993), Tuple.Create<System.Object, System.Int32>(id

#line default
#line hidden
, 3993), false)
);

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 3997), Tuple.Create("\"", 4008)

#line 90 "..\..\Views\Provider\ProviderDetails.cshtml"
, Tuple.Create(Tuple.Create("", 4005), Tuple.Create<System.Object, System.Int32>(id

#line default
#line hidden
, 4005), false)
);

WriteLiteralTo(__razor_helper_writer, ">");


#line 90 "..\..\Views\Provider\ProviderDetails.cshtml"
   WriteTo(__razor_helper_writer, Html.Raw(item));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dd>\r\n");


#line 91 "..\..\Views\Provider\ProviderDetails.cshtml"
}


#line default
#line hidden
});

#line 92 "..\..\Views\Provider\ProviderDetails.cshtml"
}
#line default
#line hidden

#line 94 "..\..\Views\Provider\ProviderDetails.cshtml"
public System.Web.WebPages.HelperResult GetEmailPropertyHtml(string title, string id, string item, bool hideIfEmpty = false)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 95 "..\..\Views\Provider\ProviderDetails.cshtml"
 
if (!string.IsNullOrEmpty(item) || !hideIfEmpty)
{


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <dt");

WriteLiteralTo(__razor_helper_writer, " class=\"email-title\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 98 "..\..\Views\Provider\ProviderDetails.cshtml"
  WriteTo(__razor_helper_writer, title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dt>\r\n");

WriteLiteralTo(__razor_helper_writer, "        <dd");

WriteAttributeTo(__razor_helper_writer, "id", Tuple.Create(" id=\"", 4246), Tuple.Create("\"", 4254)

#line 99 "..\..\Views\Provider\ProviderDetails.cshtml"
, Tuple.Create(Tuple.Create("", 4251), Tuple.Create<System.Object, System.Int32>(id

#line default
#line hidden
, 4251), false)
);

WriteLiteralTo(__razor_helper_writer, " class=\"email\"");

WriteLiteralTo(__razor_helper_writer, "><a");

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 4272), Tuple.Create("\"", 4301)
, Tuple.Create(Tuple.Create("", 4279), Tuple.Create("mailto:", 4279), true)

#line 99 "..\..\Views\Provider\ProviderDetails.cshtml"
, Tuple.Create(Tuple.Create("", 4286), Tuple.Create<System.Object, System.Int32>(Html.Raw(item)

#line default
#line hidden
, 4286), false)
);

WriteLiteralTo(__razor_helper_writer, ">");


#line 99 "..\..\Views\Provider\ProviderDetails.cshtml"
                                      WriteTo(__razor_helper_writer, Html.Raw(item));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</a></dd>\r\n");


#line 100 "..\..\Views\Provider\ProviderDetails.cshtml"
}


#line default
#line hidden
});

#line 101 "..\..\Views\Provider\ProviderDetails.cshtml"
}
#line default
#line hidden

#line 103 "..\..\Views\Provider\ProviderDetails.cshtml"
public System.Web.WebPages.HelperResult GetStandardPropertyAsLinkHtml(string title, string cssClass, string classTitle, string classIdentifier, string url, string urlTitle = "")
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 104 "..\..\Views\Provider\ProviderDetails.cshtml"
 
if (!string.IsNullOrEmpty(url))
{
    var linkProtocol = url.StartsWith("http") ? string.Empty : "http://";


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <dt");

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 4609), Tuple.Create("\"", 4628)

#line 108 "..\..\Views\Provider\ProviderDetails.cshtml"
, Tuple.Create(Tuple.Create("", 4617), Tuple.Create<System.Object, System.Int32>(classTitle

#line default
#line hidden
, 4617), false)
);

WriteLiteralTo(__razor_helper_writer, ">");


#line 108 "..\..\Views\Provider\ProviderDetails.cshtml"
  WriteTo(__razor_helper_writer, title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dt>\r\n");

WriteLiteralTo(__razor_helper_writer, "        <dd>\r\n            <a");

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 4671), Tuple.Create("\"", 4695)

#line 110 "..\..\Views\Provider\ProviderDetails.cshtml"
, Tuple.Create(Tuple.Create("", 4678), Tuple.Create<System.Object, System.Int32>(linkProtocol

#line default
#line hidden
, 4678), false)

#line 110 "..\..\Views\Provider\ProviderDetails.cshtml"
, Tuple.Create(Tuple.Create("", 4691), Tuple.Create<System.Object, System.Int32>(url

#line default
#line hidden
, 4691), false)
);

WriteLiteralTo(__razor_helper_writer, " rel=\"external\"");

WriteLiteralTo(__razor_helper_writer, " target=\"_blank\"");

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 4727), Tuple.Create("\"", 4761)

#line 110 "..\..\Views\Provider\ProviderDetails.cshtml"
, Tuple.Create(Tuple.Create("", 4735), Tuple.Create<System.Object, System.Int32>(cssClass

#line default
#line hidden
, 4735), false)

#line 110 "..\..\Views\Provider\ProviderDetails.cshtml"
       , Tuple.Create(Tuple.Create(" ", 4744), Tuple.Create<System.Object, System.Int32>(classIdentifier

#line default
#line hidden
, 4745), false)
);

WriteLiteralTo(__razor_helper_writer, ">\r\n");


#line 111 "..\..\Views\Provider\ProviderDetails.cshtml"
                

#line default
#line hidden

#line 111 "..\..\Views\Provider\ProviderDetails.cshtml"
                 if (string.IsNullOrEmpty(urlTitle))
                {
                    

#line default
#line hidden

#line 113 "..\..\Views\Provider\ProviderDetails.cshtml"
WriteTo(__razor_helper_writer, Html.Raw(url));


#line default
#line hidden

#line 113 "..\..\Views\Provider\ProviderDetails.cshtml"
                                  
                }
                else
                {
                    

#line default
#line hidden

#line 117 "..\..\Views\Provider\ProviderDetails.cshtml"
WriteTo(__razor_helper_writer, Html.Raw(urlTitle));


#line default
#line hidden

#line 117 "..\..\Views\Provider\ProviderDetails.cshtml"
                                       
                }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            </a>\r\n        </dd>\r\n");


#line 121 "..\..\Views\Provider\ProviderDetails.cshtml"
}


#line default
#line hidden
});

#line 122 "..\..\Views\Provider\ProviderDetails.cshtml"
}
#line default
#line hidden

#line 124 "..\..\Views\Provider\ProviderDetails.cshtml"
public System.Web.WebPages.HelperResult CreateProgressBar(string message, int progress)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 125 "..\..\Views\Provider\ProviderDetails.cshtml"
 
if (progress > 0)
{


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <div");

WriteLiteralTo(__razor_helper_writer, " class=\"progress-container\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n            <div");

WriteLiteralTo(__razor_helper_writer, " class=\"progressbar\"");

WriteAttributeTo(__razor_helper_writer, "style", Tuple.Create(" style=\"", 5195), Tuple.Create("\"", 5220)
, Tuple.Create(Tuple.Create("", 5203), Tuple.Create("width:", 5203), true)

#line 129 "..\..\Views\Provider\ProviderDetails.cshtml"
, Tuple.Create(Tuple.Create(" ", 5209), Tuple.Create<System.Object, System.Int32>(progress

#line default
#line hidden
, 5210), false)
, Tuple.Create(Tuple.Create("", 5219), Tuple.Create("%", 5219), true)
);

WriteLiteralTo(__razor_helper_writer, "></div>\r\n        </div>\r\n");


#line 131 "..\..\Views\Provider\ProviderDetails.cshtml"
}


#line default
#line hidden
});

#line 132 "..\..\Views\Provider\ProviderDetails.cshtml"
}
#line default
#line hidden

        public ProviderDetails()
        {
        }
        public override void Execute()
        {
            
            #line 5 "..\..\Views\Provider\ProviderDetails.cshtml"
  
    ViewBag.Title = "Provider Details";
    ViewBag.Description = "";

            
            #line default
            #line hidden
WriteLiteral("\r\n<main");

WriteLiteral(" id=\"content\"");

WriteLiteral(" class=\"provider-detail\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"grid-row\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"column-two-thirds\"");

WriteLiteral(">\r\n            <h1");

WriteLiteral(" class=\"heading-xlarge\"");

WriteLiteral(" id=\"provider-name\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 13 "..\..\Views\Provider\ProviderDetails.cshtml"
           Write(Model.ProviderName);

            
            #line default
            #line hidden
WriteLiteral(" \r\n");

            
            #line 14 "..\..\Views\Provider\ProviderDetails.cshtml"
                
            
            #line default
            #line hidden
            
            #line 14 "..\..\Views\Provider\ProviderDetails.cshtml"
                 if (@Model.NationalProvider)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <span");

WriteLiteral(" class=\"tag tag-national\"");

WriteLiteral(">National</span>\r\n");

            
            #line 17 "..\..\Views\Provider\ProviderDetails.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </h1>\r\n        </div>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"grid-row\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"column-two-thirds\"");

WriteLiteral(">\r\n            <dl");

WriteLiteral(" class=\"data-list--provider data-list--compact\"");

WriteLiteral(">\r\n                <dt>Trading names:</dt>\r\n                <dd>");

            
            #line 25 "..\..\Views\Provider\ProviderDetails.cshtml"
               Write(Model.TradingNames);

            
            #line default
            #line hidden
WriteLiteral("</dd>\r\n                <dt>UKPRN:</dt>\r\n                <dd>");

            
            #line 27 "..\..\Views\Provider\ProviderDetails.cshtml"
               Write(Model.Ukprn);

            
            #line default
            #line hidden
WriteLiteral("</dd>\r\n            </dl>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"column-one-third\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"panel--contact\"");

WriteLiteral(">\r\n                <h2");

WriteLiteral(" class=\"heading-medium\"");

WriteLiteral(">Contact details</h2>\r\n                <dl>\r\n");

WriteLiteral("                    ");

            
            #line 34 "..\..\Views\Provider\ProviderDetails.cshtml"
               Write(GetStandardPropertyAsLinkHtml("Website:", "course-link", "apprenticeshipContactTitle", "apprenticeshipContact", Model.Website, Model.ProviderName + " website"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                    ");

            
            #line 35 "..\..\Views\Provider\ProviderDetails.cshtml"
               Write(GetStandardPropertyHtml("Phone number:", "phone", Model.Phone));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                    ");

            
            #line 36 "..\..\Views\Provider\ProviderDetails.cshtml"
               Write(GetEmailPropertyHtml("Email:", "email", Model.Email));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </dl>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"panel--contact panel--satisfaction\"");

WriteLiteral(">\r\n                <dl>\r\n                    <dt>Employer satisfaction:</dt>\r\n   " +
"                 <dd>\r\n                        <div");

WriteLiteral(" class=\"rating rating--inline\"");

WriteLiteral(">\r\n                            <span");

WriteLiteral(" id=\"employer-satisfaction\"");

WriteAttribute("class", Tuple.Create(" class=\"", 1762), Tuple.Create("\"", 1804)
, Tuple.Create(Tuple.Create("", 1770), Tuple.Create("rating-", 1770), true)
            
            #line 44 "..\..\Views\Provider\ProviderDetails.cshtml"
, Tuple.Create(Tuple.Create("", 1777), Tuple.Create<System.Object, System.Int32>(Model.EmployerSatisfaction
            
            #line default
            #line hidden
, 1777), false)
);

WriteLiteral(">\r\n");

WriteLiteral("                                ");

            
            #line 45 "..\..\Views\Provider\ProviderDetails.cshtml"
                           Write(Model.EmployerSatisfactionMessage);

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </span>\r\n");

WriteLiteral("                            ");

            
            #line 47 "..\..\Views\Provider\ProviderDetails.cshtml"
                       Write(CreateProgressBar(Model.EmployerSatisfactionMessage, (int)Model.EmployerSatisfaction));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                    </dd>\r\n                    " +
"<dt>Learner satisfaction:</dt>\r\n                    <dd>\r\n                      " +
"  <div");

WriteLiteral(" class=\"rating rating--inline\"");

WriteLiteral(">\r\n                            <span");

WriteLiteral(" id=\"learner-satisfaction\"");

WriteAttribute("class", Tuple.Create(" class=\"", 2286), Tuple.Create("\"", 2327)
, Tuple.Create(Tuple.Create("", 2294), Tuple.Create("rating-", 2294), true)
            
            #line 53 "..\..\Views\Provider\ProviderDetails.cshtml"
, Tuple.Create(Tuple.Create("", 2301), Tuple.Create<System.Object, System.Int32>(Model.LearnerSatisfaction
            
            #line default
            #line hidden
, 2301), false)
);

WriteLiteral(">\r\n");

WriteLiteral("                                ");

            
            #line 54 "..\..\Views\Provider\ProviderDetails.cshtml"
                           Write(Model.LearnerSatisfactionMessage);

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </span>\r\n");

WriteLiteral("                            ");

            
            #line 56 "..\..\Views\Provider\ProviderDetails.cshtml"
                       Write(CreateProgressBar(Model.LearnerSatisfactionMessage, (int)Model.LearnerSatisfaction));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n");

            
            #line 58 "..\..\Views\Provider\ProviderDetails.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 58 "..\..\Views\Provider\ProviderDetails.cshtml"
                         if (!(Model.EmployerSatisfactionMessage == "no data available" && Model.LearnerSatisfactionMessage == "no data available"))
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <span");

WriteLiteral(" class=\"satisfaction-source font-small\"");

WriteLiteral(">\r\n                                Source: <a");

WriteLiteral(" href=\"https://www.gov.uk/government/statistical-data-sets/fe-choices-performance" +
"-indicators\"");

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">Skills Funding Agency FE Choices</a>\r\n                            </span>\r\n");

            
            #line 63 "..\..\Views\Provider\ProviderDetails.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </dd>\r\n                </dl>\r\n            </div>\r\n           " +
" <div");

WriteLiteral(" class=\"panel--disclaimer\"");

WriteLiteral(@">
                <h4>Content disclaimer</h4>
                <p>
                    Education & Skills Funding Agency cannot guarantee the accuracy of course information on this site and makes 
                    no representations about the quality of any courses which appear on the site. Education & Skills Funding Agency 
                    is not liable for any losses suffered as a result of any party relying on the course information 
                    provided.
                </p>
            </div>
        </div>       
    </div>
</main>






");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
