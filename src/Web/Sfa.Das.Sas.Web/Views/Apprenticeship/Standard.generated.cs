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
    
    #line 1 "..\..\Views\Apprenticeship\Standard.cshtml"
    using System.Globalization;
    
    #line default
    #line hidden
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
    
    #line 2 "..\..\Views\Apprenticeship\Standard.cshtml"
    using Sfa.Das.Sas.Resources;
    
    #line default
    #line hidden
    using Sfa.Das.Sas.Web;
    
    #line 3 "..\..\Views\Apprenticeship\Standard.cshtml"
    using Sfa.Das.Sas.Web.Extensions;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Apprenticeship/Standard.cshtml")]
    public partial class Standard : System.Web.Mvc.WebViewPage<Sfa.Das.Sas.Web.ViewModels.StandardViewModel>
    {

#line 126 "..\..\Views\Apprenticeship\Standard.cshtml"
public System.Web.WebPages.HelperResult GetStandardProperty(string title, string id, string item, bool hideIfEmpty = false)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 127 "..\..\Views\Apprenticeship\Standard.cshtml"
 
    if (!string.IsNullOrEmpty(item) || !hideIfEmpty)
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <dt>");


#line 130 "..\..\Views\Apprenticeship\Standard.cshtml"
WriteTo(__razor_helper_writer, title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dt>\r\n");

WriteLiteralTo(__razor_helper_writer, "        <dd");

WriteAttributeTo(__razor_helper_writer, "id", Tuple.Create(" id=\"", 7228), Tuple.Create("\"", 7236)

#line 131 "..\..\Views\Apprenticeship\Standard.cshtml"
, Tuple.Create(Tuple.Create("", 7233), Tuple.Create<System.Object, System.Int32>(id

#line default
#line hidden
, 7233), false)
);

WriteLiteralTo(__razor_helper_writer, ">");


#line 131 "..\..\Views\Apprenticeship\Standard.cshtml"
WriteTo(__razor_helper_writer, Html.MarkdownToHtml(item));


#line default
#line hidden

#line 131 "..\..\Views\Apprenticeship\Standard.cshtml"
                                                if (item == null){ 

#line default
#line hidden

#line 131 "..\..\Views\Apprenticeship\Standard.cshtml"
                                     WriteTo(__razor_helper_writer, Html.Raw("&nbsp;"));


#line default
#line hidden

#line 131 "..\..\Views\Apprenticeship\Standard.cshtml"
                                                                                       }

#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dd>\r\n");


#line 132 "..\..\Views\Apprenticeship\Standard.cshtml"
    }


#line default
#line hidden
});

#line 133 "..\..\Views\Apprenticeship\Standard.cshtml"
}
#line default
#line hidden

#line 135 "..\..\Views\Apprenticeship\Standard.cshtml"
public System.Web.WebPages.HelperResult GetMoreInformationProperty(string link)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 136 "..\..\Views\Apprenticeship\Standard.cshtml"
 
    {
        var details = "The Institute for Apprenticeships has more detailed information about this apprenticeship.";
        if (link!=null && link.Trim() != string.Empty)
        {
            details = @"The Institute for Apprenticeships has more <a href='" + link + "' target='_blank'>detailed information</a> about this apprenticeship.";
        }



#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <dt>More Information</dt>\r\n");

WriteLiteralTo(__razor_helper_writer, "        <dd");

WriteLiteralTo(__razor_helper_writer, " id=\"more-information\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 145 "..\..\Views\Apprenticeship\Standard.cshtml"
    WriteTo(__razor_helper_writer, Html.MarkdownToHtml(details));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dd>\r\n");


#line 146 "..\..\Views\Apprenticeship\Standard.cshtml"
    }


#line default
#line hidden
});

#line 147 "..\..\Views\Apprenticeship\Standard.cshtml"
}
#line default
#line hidden

#line 149 "..\..\Views\Apprenticeship\Standard.cshtml"
public System.Web.WebPages.HelperResult GetDurationProperty(string title, string id, string item, bool hideIfEmpty = false)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 150 "..\..\Views\Apprenticeship\Standard.cshtml"
 
    if (!string.IsNullOrEmpty(item) || !hideIfEmpty)
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <dt>");


#line 153 "..\..\Views\Apprenticeship\Standard.cshtml"
WriteTo(__razor_helper_writer, title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dt>\r\n");

WriteLiteralTo(__razor_helper_writer, "        <dd");

WriteAttributeTo(__razor_helper_writer, "id", Tuple.Create(" id=\"", 8051), Tuple.Create("\"", 8059)

#line 154 "..\..\Views\Apprenticeship\Standard.cshtml"
, Tuple.Create(Tuple.Create("", 8056), Tuple.Create<System.Object, System.Int32>(id

#line default
#line hidden
, 8056), false)
);

WriteLiteralTo(__razor_helper_writer, ">");


#line 154 "..\..\Views\Apprenticeship\Standard.cshtml"
WriteTo(__razor_helper_writer, item);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " months</dd>\r\n");


#line 155 "..\..\Views\Apprenticeship\Standard.cshtml"
    }


#line default
#line hidden
});

#line 156 "..\..\Views\Apprenticeship\Standard.cshtml"
}
#line default
#line hidden

#line 161 "..\..\Views\Apprenticeship\Standard.cshtml"
public System.Web.WebPages.HelperResult GetNextFundingMessage(DateTime? nextEffectiveFrom, int? nextFundingCap)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 162 "..\..\Views\Apprenticeship\Standard.cshtml"
 

    if (nextEffectiveFrom == null || nextFundingCap == null || nextFundingCap == Model.MaxFunding)
    {
        return;
    }

    var nextFundingCapFormatted = GetFundingCapFormatted(nextFundingCap.Value);
    var nextEffectiveFromFormatted = nextEffectiveFrom.Value.ToString("dd MMMM yyyy");



#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <div");

WriteLiteralTo(__razor_helper_writer, " class=\'notice\'");

WriteLiteralTo(__razor_helper_writer, ">\r\n        <i");

WriteLiteralTo(__razor_helper_writer, " class=\'icon icon-important\'");

WriteLiteralTo(__razor_helper_writer, ">\r\n            <span");

WriteLiteralTo(__razor_helper_writer, " class=\'visuallyhidden\'");

WriteLiteralTo(__razor_helper_writer, ">\r\n                Warning\r\n            </span>\r\n        </i>\r\n        <strong");

WriteLiteralTo(__razor_helper_writer, " class=\'bold-small\'");

WriteLiteralTo(__razor_helper_writer, ">\r\n            The funding band maximum for this apprenticeship will change to ");


#line 179 "..\..\Views\Apprenticeship\Standard.cshtml"
                                              WriteTo(__razor_helper_writer, nextFundingCapFormatted);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " from ");


#line 179 "..\..\Views\Apprenticeship\Standard.cshtml"
                                                                            WriteTo(__razor_helper_writer, nextEffectiveFromFormatted);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n        </strong>\r\n    </div>\r\n");


#line 182 "..\..\Views\Apprenticeship\Standard.cshtml"
    

#line default
#line hidden
});

#line 182 "..\..\Views\Apprenticeship\Standard.cshtml"
}
#line default
#line hidden

        #line 185 "..\..\Views\Apprenticeship\Standard.cshtml"
     

    private string GetFundingCapFormatted(int value)
        {
            return value.ToString("C0", new CultureInfo("en-GB"));
        }
    
        #line default
        #line hidden
        
        public Standard()
        {
        }
        public override void Execute()
        {
            
            #line 5 "..\..\Views\Apprenticeship\Standard.cshtml"
  
    ViewBag.Title = Model.Title + " - Apprenticeship Standard";
    ViewBag.Description = Model.OverviewOfRole;
    var areOrganisationsPresent = Model.AssessmentOrganisations != null && Model.AssessmentOrganisations.Any();

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<main");

WriteLiteral(" id=\"content\"");

WriteLiteral(" class=\"standard-detail\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"grid-row\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"column-two-thirds\"");

WriteLiteral(">\r\n            <div>\r\n                <h1");

WriteLiteral(" class=\"heading-xlarge\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 16 "..\..\Views\Apprenticeship\Standard.cshtml"
               Write(Model.Title);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </h1>\r\n                <p");

WriteLiteral(" class=\"lede\"");

WriteLiteral(">");

            
            #line 18 "..\..\Views\Apprenticeship\Standard.cshtml"
                           Write(Model.OverviewOfRole);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

            
            #line 19 "..\..\Views\Apprenticeship\Standard.cshtml"
                
            
            #line default
            #line hidden
            
            #line 19 "..\..\Views\Apprenticeship\Standard.cshtml"
                 if (Model.LastDateForNewStarts.HasValue && Model.LastDateForNewStarts.Value <= DateTime.Today.AddYears(1))
                {

            
            #line default
            #line hidden
WriteLiteral("                    <br/>\r\n");

WriteLiteral("                    <div");

WriteLiteral(" class=\"notice\"");

WriteLiteral(">\r\n                        <i");

WriteLiteral(" class=\"icon icon-important\"");

WriteLiteral(">\r\n                            <span");

WriteLiteral(" class=\"visuallyhidden\"");

WriteLiteral(">Warning</span>\r\n                        </i>\r\n                        <strong");

WriteLiteral(" id=\"apprenticeship-closed-message\"");

WriteLiteral(" class=\"bold-small\"");

WriteLiteral(">\r\n                            This apprenticeship is closed to new starters from" +
" ");

            
            #line 27 "..\..\Views\Apprenticeship\Standard.cshtml"
                                                                          Write(Model.DayAfterLastDateForNewStartsFormatted);

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n                        </strong>\r\n                    </div>\r\n");

            
            #line 31 "..\..\Views\Apprenticeship\Standard.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </div>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"column-third\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"related-container\"");

WriteLiteral(">\r\n                <aside");

WriteLiteral(" class=\"hidden-for-mobile-tablet\"");

WriteLiteral(">\r\n                    <a");

WriteLiteral(" class=\"button ui-find-training-providers\"");

WriteLiteral(" rel=\"nofollow\"");

WriteLiteral(" target=\"find-training-providers\"");

WriteLiteral(" id=\"ga-find-provider-top\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1660), Tuple.Create("\"", 1794)
            
            #line 37 "..\..\Views\Apprenticeship\Standard.cshtml"
                                                                 , Tuple.Create(Tuple.Create("", 1667), Tuple.Create<System.Object, System.Int32>(Url.Action("SearchForStandardProviders", "Apprenticeship", new { standardId = Model.StandardId, keywords = Model.SearchTerm })
            
            #line default
            #line hidden
, 1667), false)
);

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 38 "..\..\Views\Apprenticeship\Standard.cshtml"
                   Write(Model.FindApprenticeshipTrainingText);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </a>\r\n                </aside>\r\n            </div>\r\n       " +
" </div>\r\n    </div>\r\n    <section>\r\n        <header>\r\n            <h2");

WriteLiteral(" class=\"heading-large\"");

WriteLiteral(">\r\n                Summary of this apprenticeship standard\r\n            </h2>\r\n  " +
"      </header>\r\n        <dl");

WriteLiteral(" class=\"data-list\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 51 "..\..\Views\Apprenticeship\Standard.cshtml"
       Write(GetStandardProperty("Level", "level", $"{@Model.Level} (equivalent to {EquivalenceLevelService.GetApprenticeshipLevel(Model.Level.ToString())})"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 52 "..\..\Views\Apprenticeship\Standard.cshtml"
       Write(GetDurationProperty("Typical length", "length", Model.Duration.ToString()));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <dt>Current funding band</dt>\r\n            <dd");

WriteLiteral(" id=\"funding-cap\"");

WriteLiteral(">\r\n                Up to ");

            
            #line 55 "..\..\Views\Apprenticeship\Standard.cshtml"
                 Write(GetFundingCapFormatted(Model.MaxFunding));

            
            #line default
            #line hidden
WriteLiteral(" per apprentice.<br />\r\n");

WriteLiteral("                ");

            
            #line 56 "..\..\Views\Apprenticeship\Standard.cshtml"
           Write(GetNextFundingMessage(Model.NextEffectiveFrom, Model.NextFundingCap));

            
            #line default
            #line hidden
WriteLiteral("\r\n                <a");

WriteLiteral(" href=\"https://www.gov.uk/guidance/employing-an-apprentice-technical-guide-for-em" +
"ployers#funding-for-your-apprenticeship\"");

WriteLiteral(" target=\"_blank\"");

WriteLiteral(" rel=\"external\"");

WriteLiteral(">More information about funding</a>\r\n            </dd>\r\n\r\n");

WriteLiteral("            ");

            
            #line 60 "..\..\Views\Apprenticeship\Standard.cshtml"
       Write(GetStandardProperty("Entry requirements", "entry-requirements", Model.EntryRequirements));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 61 "..\..\Views\Apprenticeship\Standard.cshtml"
       Write(GetStandardProperty("What apprentices will learn", "will-learn", Model.WhatApprenticesWillLearn));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 62 "..\..\Views\Apprenticeship\Standard.cshtml"
       Write(GetStandardProperty("Qualifications", "qualifications", Model.Qualifications));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 63 "..\..\Views\Apprenticeship\Standard.cshtml"
       Write(GetStandardProperty("Professional registration", "professional-registration", Model.ProfessionalRegistration, true));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 65 "..\..\Views\Apprenticeship\Standard.cshtml"
            
            
            #line default
            #line hidden
            
            #line 65 "..\..\Views\Apprenticeship\Standard.cshtml"
             if (areOrganisationsPresent == false)
            {
                const string noDetails = @"A government-approved organisation must assess apprentices towards the end of their apprenticeship.<br/><br/> " +
                                         "This end-point assessment ensures apprentices achieve the skills, training and any qualifications necessary to complete their apprenticeship. <br/><br/>" +
                                         "You can download the assessment plan from the Institute for Apprenticeships. " +
                                         "There are no end-point assessment organisations for this apprenticeship yet. " +
                                         "Please email <a href='mailto:apprentice.assessment@education.gov.uk' target='_blank'>apprentice.assessment@education.gov.uk</a> if you urgently need an end-point assessment organisation.";
                
            
            #line default
            #line hidden
            
            #line 72 "..\..\Views\Apprenticeship\Standard.cshtml"
           Write(GetStandardProperty("How apprentices are assessed", "no-assessment-organisations", noDetails));

            
            #line default
            #line hidden
            
            #line 72 "..\..\Views\Apprenticeship\Standard.cshtml"
                                                                                                              
            }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 75 "..\..\Views\Apprenticeship\Standard.cshtml"
            
            
            #line default
            #line hidden
            
            #line 75 "..\..\Views\Apprenticeship\Standard.cshtml"
             if (areOrganisationsPresent)
            {

            
            #line default
            #line hidden
WriteLiteral("                <dt>End Point Assessment</dt>\r\n");

WriteLiteral("                <dd>\r\n                    <details>\r\n                        <sum" +
"mary><span");

WriteLiteral(" class=\"summary\"");

WriteLiteral(" style=\"text-decoration: none\"");

WriteLiteral(">View a list of end point assessment organisations for this standard</span></summ" +
"ary>\r\n                        <table");

WriteLiteral(" class=\"responsive\"");

WriteLiteral(">\r\n                            <thead>\r\n                            <tr>\r\n       " +
"                         <th");

WriteLiteral(" scope=\"col\"");

WriteLiteral(">Organisation</th>\r\n                                <th");

WriteLiteral(" scope=\"col\"");

WriteLiteral(">Phone Number</th>\r\n                                <th");

WriteLiteral(" scope=\"col\"");

WriteLiteral(">Email</th>\r\n                            </tr>\r\n                            </the" +
"ad>\r\n                            <tbody>\r\n");

            
            #line 90 "..\..\Views\Apprenticeship\Standard.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 90 "..\..\Views\Apprenticeship\Standard.cshtml"
                             foreach (var organisation in Model.AssessmentOrganisations)
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <tr>\r\n                                    <td");

WriteLiteral(" class=\"organisation-name\"");

WriteLiteral(" data-label=\"organisation\"");

WriteLiteral(">\r\n");

            
            #line 94 "..\..\Views\Apprenticeship\Standard.cshtml"
                                        
            
            #line default
            #line hidden
            
            #line 94 "..\..\Views\Apprenticeship\Standard.cshtml"
                                         if (string.IsNullOrEmpty(organisation.Website))
                                        {
                                            
            
            #line default
            #line hidden
            
            #line 96 "..\..\Views\Apprenticeship\Standard.cshtml"
                                       Write(organisation.Name);

            
            #line default
            #line hidden
            
            #line 96 "..\..\Views\Apprenticeship\Standard.cshtml"
                                                              
                                        }
                                        else
                                        {
                                            var linkProtocol = organisation.Website.StartsWith("http") ? string.Empty : "http://";

            
            #line default
            #line hidden
WriteLiteral("                                            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 5877), Tuple.Create("\"", 5918)
            
            #line 101 "..\..\Views\Apprenticeship\Standard.cshtml"
, Tuple.Create(Tuple.Create("", 5884), Tuple.Create<System.Object, System.Int32>(linkProtocol
            
            #line default
            #line hidden
, 5884), false)
            
            #line 101 "..\..\Views\Apprenticeship\Standard.cshtml"
, Tuple.Create(Tuple.Create("", 5897), Tuple.Create<System.Object, System.Int32>(organisation.Website
            
            #line default
            #line hidden
, 5897), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">");

            
            #line 101 "..\..\Views\Apprenticeship\Standard.cshtml"
                                                                                                    Write(organisation.Name);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

            
            #line 102 "..\..\Views\Apprenticeship\Standard.cshtml"
                                        }

            
            #line default
            #line hidden
WriteLiteral("                                    </td>\r\n                                    <t" +
"d");

WriteLiteral(" class=\"phone-number\"");

WriteLiteral(" data-label=\"phone-number\"");

WriteLiteral(">");

            
            #line 104 "..\..\Views\Apprenticeship\Standard.cshtml"
                                                                                  Write(organisation.Phone);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                                    <td");

WriteLiteral(" class=\"email\"");

WriteLiteral(" data-label=\"email\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 6234), Tuple.Create("\"", 6267)
, Tuple.Create(Tuple.Create("", 6241), Tuple.Create("mailto:", 6241), true)
            
            #line 105 "..\..\Views\Apprenticeship\Standard.cshtml"
         , Tuple.Create(Tuple.Create("", 6248), Tuple.Create<System.Object, System.Int32>(organisation.Email
            
            #line default
            #line hidden
, 6248), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">");

            
            #line 105 "..\..\Views\Apprenticeship\Standard.cshtml"
                                                                                                                         Write(organisation.Email);

            
            #line default
            #line hidden
WriteLiteral("</a></td>\r\n                                </tr>\r\n");

            
            #line 107 "..\..\Views\Apprenticeship\Standard.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("                            </tbody>\r\n                        </table>\r\n         " +
"           </details>\r\n                </dd>\r\n");

            
            #line 112 "..\..\Views\Apprenticeship\Standard.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 114 "..\..\Views\Apprenticeship\Standard.cshtml"
       Write(GetMoreInformationProperty(Model.StandardPageUri));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dl>\r\n        \r\n\r\n        <div");

WriteLiteral(" id=\"bottom-actions\"");

WriteLiteral(">\r\n            <a");

WriteLiteral(" class=\"button btn-find-trng-prov\"");

WriteLiteral(" rel=\"nofollow\"");

WriteLiteral("  target=\"find-training-providers\"");

WriteLiteral(" id=\"ga-find-provider-bottom\"");

WriteAttribute("href", Tuple.Create(" href=\"", 6781), Tuple.Create("\"", 6915)
            
            #line 119 "..\..\Views\Apprenticeship\Standard.cshtml"
                                                     , Tuple.Create(Tuple.Create("", 6788), Tuple.Create<System.Object, System.Int32>(Url.Action("SearchForStandardProviders", "Apprenticeship", new { standardId = Model.StandardId, keywords = Model.SearchTerm })
            
            #line default
            #line hidden
, 6788), false)
);

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 120 "..\..\Views\Apprenticeship\Standard.cshtml"
           Write(Model.FindApprenticeshipTrainingText);

            
            #line default
            #line hidden
WriteLiteral("\r\n            </a>\r\n        </div>\r\n    </section>\r\n</main>\r\n\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n    }\r\n}\r\n\r\n");

WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
