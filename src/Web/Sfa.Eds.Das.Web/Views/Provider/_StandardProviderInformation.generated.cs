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

namespace Sfa.Eds.Das.Web.Views.Provider
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
    
    #line 1 "..\..\Views\Provider\_StandardProviderInformation.cshtml"
    using Sfa.Eds.Das.Web.ViewModels;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Provider/_StandardProviderInformation.cshtml")]
    public partial class StandardProviderInformation : System.Web.Mvc.WebViewPage<ProviderStandardSearchResultViewModel>
    {

#line 35 "..\..\Views\Provider\_StandardProviderInformation.cshtml"
public System.Web.WebPages.HelperResult  RenderEmployersLocationProviderDetails(ProviderResultItemViewModel item)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 36 "..\..\Views\Provider\_StandardProviderInformation.cshtml"
 


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <dt>Distance:</dt>\r\n");

WriteLiteralTo(__razor_helper_writer, "    <dd");

WriteLiteralTo(__razor_helper_writer, " class=\"distance\"");

WriteLiteralTo(__razor_helper_writer, ">Training can take place at your location.</dd>\r\n");

WriteLiteralTo(__razor_helper_writer, "    <dt>Website:</dt>\r\n");

WriteLiteralTo(__razor_helper_writer, "    <dd");

WriteLiteralTo(__razor_helper_writer, " class=\"website\"");

WriteLiteralTo(__razor_helper_writer, "><a");

WriteLiteralTo(__razor_helper_writer, " class=\"link\"");

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 1477), Tuple.Create("\"", 1497)

#line 40 "..\..\Views\Provider\_StandardProviderInformation.cshtml"
, Tuple.Create(Tuple.Create("", 1484), Tuple.Create<System.Object, System.Int32>(item.Website

#line default
#line hidden
, 1484), false)
);

WriteLiteralTo(__razor_helper_writer, "> ");


#line 40 "..\..\Views\Provider\_StandardProviderInformation.cshtml"
                                WriteTo(__razor_helper_writer, item.Website);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</a></dd>\r\n");


#line 41 "..\..\Views\Provider\_StandardProviderInformation.cshtml"


#line default
#line hidden
});

#line 41 "..\..\Views\Provider\_StandardProviderInformation.cshtml"
}
#line default
#line hidden

#line 43 "..\..\Views\Provider\_StandardProviderInformation.cshtml"
public System.Web.WebPages.HelperResult  RenderProviderDetails(ProviderResultItemViewModel item)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 44 "..\..\Views\Provider\_StandardProviderInformation.cshtml"
 


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <dt>Distance:</dt>\r\n");

WriteLiteralTo(__razor_helper_writer, "    <dd");

WriteLiteralTo(__razor_helper_writer, " class=\"distance\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 46 "..\..\Views\Provider\_StandardProviderInformation.cshtml"
WriteTo(__razor_helper_writer, item.Distance);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " miles away</dd>\r\n");

WriteLiteralTo(__razor_helper_writer, "    <dd");

WriteLiteralTo(__razor_helper_writer, " class=\"address\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 47 "..\..\Views\Provider\_StandardProviderInformation.cshtml"
WriteTo(__razor_helper_writer, item.LocationName);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " ");


#line 47 "..\..\Views\Provider\_StandardProviderInformation.cshtml"
             WriteTo(__razor_helper_writer, item.Address.Address1);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " ");


#line 47 "..\..\Views\Provider\_StandardProviderInformation.cshtml"
                                    WriteTo(__razor_helper_writer, item.Address.Address2);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " ");


#line 47 "..\..\Views\Provider\_StandardProviderInformation.cshtml"
                                                           WriteTo(__razor_helper_writer, item.Address.County);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " ");


#line 47 "..\..\Views\Provider\_StandardProviderInformation.cshtml"
                                                                                WriteTo(__razor_helper_writer, item.Address.Postcode);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dd>\r\n");

WriteLiteralTo(__razor_helper_writer, "    <dt>Website:</dt>\r\n");

WriteLiteralTo(__razor_helper_writer, "    <dd");

WriteLiteralTo(__razor_helper_writer, " class=\"website\"");

WriteLiteralTo(__razor_helper_writer, "><a");

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 1867), Tuple.Create("\"", 1887)

#line 49 "..\..\Views\Provider\_StandardProviderInformation.cshtml"
, Tuple.Create(Tuple.Create("", 1874), Tuple.Create<System.Object, System.Int32>(item.Website

#line default
#line hidden
, 1874), false)
);

WriteLiteralTo(__razor_helper_writer, "> ");


#line 49 "..\..\Views\Provider\_StandardProviderInformation.cshtml"
                   WriteTo(__razor_helper_writer, item.Website);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</a></dd>\r\n");


#line 50 "..\..\Views\Provider\_StandardProviderInformation.cshtml"


#line default
#line hidden
});

#line 50 "..\..\Views\Provider\_StandardProviderInformation.cshtml"
}
#line default
#line hidden

        public StandardProviderInformation()
        {
        }
        public override void Execute()
        {
WriteLiteral("    ");

            
            #line 4 "..\..\Views\Provider\_StandardProviderInformation.cshtml"
     foreach (var item in Model.Hits)
    {

            
            #line default
            #line hidden
WriteLiteral("        <article");

WriteLiteral(" class=\"result\"");

WriteLiteral(">\r\n            <header>\r\n                <h2");

WriteLiteral(" class=\"result-title\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 9 "..\..\Views\Provider\_StandardProviderInformation.cshtml"
               Write(Html.ActionLink(item.Name, "Detail", "Provider", new { @providerId = item.Id, @locationId = item.LocationId, @standardCode = item.StandardCode }, null));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </h2>\r\n            </header>\r\n\r\n            <dl");

WriteLiteral(" class=\"result-data-list\"");

WriteLiteral(">\r\n");

            
            #line 14 "..\..\Views\Provider\_StandardProviderInformation.cshtml"
                
            
            #line default
            #line hidden
            
            #line 14 "..\..\Views\Provider\_StandardProviderInformation.cshtml"
                 if (item.DeliveryModes != null && item.DeliveryModes.Contains("100PercentEmployer"))
                {
                    
            
            #line default
            #line hidden
            
            #line 16 "..\..\Views\Provider\_StandardProviderInformation.cshtml"
               Write(RenderEmployersLocationProviderDetails(item));

            
            #line default
            #line hidden
            
            #line 16 "..\..\Views\Provider\_StandardProviderInformation.cshtml"
                                                                 
                }
                else
                {
                    
            
            #line default
            #line hidden
            
            #line 20 "..\..\Views\Provider\_StandardProviderInformation.cshtml"
               Write(RenderProviderDetails(item));

            
            #line default
            #line hidden
            
            #line 20 "..\..\Views\Provider\_StandardProviderInformation.cshtml"
                                                
                }

            
            #line default
            #line hidden
WriteLiteral("                \r\n                <dt>Employer satisfaction:</dt>\r\n              " +
"  <dd");

WriteLiteral(" class=\"employer-satisfaction\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 25 "..\..\Views\Provider\_StandardProviderInformation.cshtml"
               Write(item.EmployerSatisfactionMessage);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </dd>\r\n                <dt>Learner satisfaction:</dt>\r\n        " +
"        <dd");

WriteLiteral(" class=\"learner-satisfaction\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 29 "..\..\Views\Provider\_StandardProviderInformation.cshtml"
               Write(item.LearnerSatisfactionMessage);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </dd>\r\n            </dl>\r\n        </article>\r\n");

            
            #line 33 "..\..\Views\Provider\_StandardProviderInformation.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
