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
    
    #line 2 "..\..\Views\Provider\_FrameworkProviderInformation.cshtml"
    using FeatureToggle.Core.Fluent;
    
    #line default
    #line hidden
    
    #line 1 "..\..\Views\Provider\_FrameworkProviderInformation.cshtml"
    using Sfa.Das.Sas.ApplicationServices.FeatureToggles;
    
    #line default
    #line hidden
    using Sfa.Das.Sas.Web;
    
    #line 3 "..\..\Views\Provider\_FrameworkProviderInformation.cshtml"
    using Sfa.Das.Sas.Web.ViewModels;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Provider/_FrameworkProviderInformation.cshtml")]
    public partial class FrameworkProviderInformation : System.Web.Mvc.WebViewPage<Sfa.Das.Sas.Web.ViewModels.ProviderFrameworkSearchResultViewModel>
    {

#line 47 "..\..\Views\Provider\_FrameworkProviderInformation.cshtml"
public System.Web.WebPages.HelperResult RenderDeliveryOptions(FrameworkProviderResultItemViewModel item)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 48 "..\..\Views\Provider\_FrameworkProviderInformation.cshtml"
 


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <dt>Training options:</dt>\r\n");


#line 50 "..\..\Views\Provider\_FrameworkProviderInformation.cshtml"



#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <dd");

WriteLiteralTo(__razor_helper_writer, " class=\"deliveryOptions\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 51 "..\..\Views\Provider\_FrameworkProviderInformation.cshtml"
  WriteTo(__razor_helper_writer, item.DeliveryOptionsMessage);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dd>\r\n");


#line 52 "..\..\Views\Provider\_FrameworkProviderInformation.cshtml"


#line default
#line hidden
});

#line 52 "..\..\Views\Provider\_FrameworkProviderInformation.cshtml"
}
#line default
#line hidden

#line 54 "..\..\Views\Provider\_FrameworkProviderInformation.cshtml"
public System.Web.WebPages.HelperResult GetShortlistLink(int ukprn, int apprenticeshipId, int locationId, bool isShortlisted)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 55 "..\..\Views\Provider\_FrameworkProviderInformation.cshtml"
 
    if (Is<ShortlistingFeature>.Enabled)
    {
        if (isShortlisted)
        {
                

#line default
#line hidden

#line 60 "..\..\Views\Provider\_FrameworkProviderInformation.cshtml"
WriteTo(__razor_helper_writer, Html.ActionLink("Remove", "RemoveFrameworkProvider", "ShortList",
                    new { apprenticeshipId, ukprn, locationId },
                    new
                    {
                        @class = "link shortlist-link provider-search-shortlist-link",
                        rel = "nofollow",
                        data_apprenticeship = apprenticeshipId,
                        data_provider = ukprn,
                        data_location = locationId,
                        data_action = "remove",
                        data_apprenticeship_type = "Framework"
                    }));


#line default
#line hidden

#line 71 "..\..\Views\Provider\_FrameworkProviderInformation.cshtml"
                      
        }
        else
        {
                

#line default
#line hidden

#line 75 "..\..\Views\Provider\_FrameworkProviderInformation.cshtml"
WriteTo(__razor_helper_writer, Html.ActionLink("Shortlist", "AddFrameworkProvider", "ShortList",
                    new { apprenticeshipId, ukprn, locationId },
                    new
                    {
                        @class = "link shortlist-link provider-search-shortlist-link",
                        rel = "nofollow",
                        data_apprenticeship = apprenticeshipId,
                        data_provider = ukprn,
                        data_location = locationId,
                        data_action = "add",
                        data_apprenticeship_type = "Framework"
                    }));


#line default
#line hidden

#line 86 "..\..\Views\Provider\_FrameworkProviderInformation.cshtml"
                      
        }
    }


#line default
#line hidden
});

#line 89 "..\..\Views\Provider\_FrameworkProviderInformation.cshtml"
}
#line default
#line hidden

        public FrameworkProviderInformation()
        {
        }
        public override void Execute()
        {
WriteLiteral("    ");

            
            #line 6 "..\..\Views\Provider\_FrameworkProviderInformation.cshtml"
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

            
            #line 11 "..\..\Views\Provider\_FrameworkProviderInformation.cshtml"
               Write(Html.ActionLink(item.ProviderName, "Detail", "Provider", new { @ukprn = item.UkPrn, @locationId = item.LocationId, @frameworkId = item.FrameworkId }, null));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </h2>\r\n            </header>\r\n\r\n            <dl");

WriteLiteral(" class=\"result-data-list\"");

WriteLiteral(">\r\n                <dt>Distance:</dt>\r\n                <dd");

WriteLiteral(" class=\"distance\"");

WriteLiteral(">");

            
            #line 17 "..\..\Views\Provider\_FrameworkProviderInformation.cshtml"
                                Write(item.Distance);

            
            #line default
            #line hidden
WriteLiteral(" miles away</dd>\r\n");

            
            #line 18 "..\..\Views\Provider\_FrameworkProviderInformation.cshtml"
                
            
            #line default
            #line hidden
            
            #line 18 "..\..\Views\Provider\_FrameworkProviderInformation.cshtml"
                 if (item.DeliveryModes != null && (item.DeliveryModes.Contains("BlockRelease") || item.DeliveryModes.Contains("DayRelease")))
                {
                    if (@item.Address != null)
                     {

            
            #line default
            #line hidden
WriteLiteral("                        <dd");

WriteLiteral(" class=\"address\"");

WriteLiteral(">");

            
            #line 22 "..\..\Views\Provider\_FrameworkProviderInformation.cshtml"
                                       Write(item.LocationName);

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 22 "..\..\Views\Provider\_FrameworkProviderInformation.cshtml"
                                                          Write(item.Address.Address1);

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 22 "..\..\Views\Provider\_FrameworkProviderInformation.cshtml"
                                                                                 Write(item.Address.Address2);

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 22 "..\..\Views\Provider\_FrameworkProviderInformation.cshtml"
                                                                                                        Write(item.Address.Town);

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 22 "..\..\Views\Provider\_FrameworkProviderInformation.cshtml"
                                                                                                                           Write(item.Address.County);

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 22 "..\..\Views\Provider\_FrameworkProviderInformation.cshtml"
                                                                                                                                                Write(item.Address.Postcode);

            
            #line default
            #line hidden
WriteLiteral("</dd>\r\n");

            
            #line 23 "..\..\Views\Provider\_FrameworkProviderInformation.cshtml"
                     }
                }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 26 "..\..\Views\Provider\_FrameworkProviderInformation.cshtml"
           Write(RenderDeliveryOptions(item));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n                <dt>Employer satisfaction:</dt>\r\n                <dd");

WriteLiteral(" class=\"employer-satisfaction\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 30 "..\..\Views\Provider\_FrameworkProviderInformation.cshtml"
               Write(item.EmployerSatisfactionMessage);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </dd>\r\n                <dt>Learner satisfaction:</dt>\r\n        " +
"        <dd");

WriteLiteral(" class=\"learner-satisfaction\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 34 "..\..\Views\Provider\_FrameworkProviderInformation.cshtml"
               Write(item.LearnerSatisfactionMessage);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </dd>\r\n                <dt>Achievement rate:</dt>\r\n            " +
"    <dd");

WriteLiteral(" class=\"achievement-rate\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 38 "..\..\Views\Provider\_FrameworkProviderInformation.cshtml"
               Write(item.AchievementRateMessage);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </dd>\r\n            </dl>\r\n            <div");

WriteLiteral(" class=\"shortlist-link\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 42 "..\..\Views\Provider\_FrameworkProviderInformation.cshtml"
           Write(GetShortlistLink(item.UkPrn, int.Parse(item.FrameworkId), item.LocationId, item.IsShortlisted));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </article>\r\n");

            
            #line 45 "..\..\Views\Provider\_FrameworkProviderInformation.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
