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

namespace Sfa.Das.Sas.MetadataTool.Web.Views.Apprenticeship
{
    using System;
    using System.Collections.Generic;
    
    #line 1 "..\..\Views\Apprenticeship\FrameworkDetails.cshtml"
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
    using MetadataTool;
    
    #line 2 "..\..\Views\Apprenticeship\FrameworkDetails.cshtml"
    using Sfa.Das.Sas.Core.Extensions;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\Apprenticeship\FrameworkDetails.cshtml"
    using Sfa.Das.Sas.Core.Models;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Apprenticeship/FrameworkDetails.cshtml")]
    public partial class FrameworkDetails : System.Web.Mvc.WebViewPage<FrameworkMetaData>
    {

#line 41 "..\..\Views\Apprenticeship\FrameworkDetails.cshtml"
public System.Web.WebPages.HelperResult GetFrameworkProperty(string title, string id, string item, bool hideIfEmpty = false)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 42 "..\..\Views\Apprenticeship\FrameworkDetails.cshtml"
 
    if (!string.IsNullOrEmpty(item) || !hideIfEmpty)
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <dt>");


#line 45 "..\..\Views\Apprenticeship\FrameworkDetails.cshtml"
WriteTo(__razor_helper_writer, title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dt>\r\n");

WriteLiteralTo(__razor_helper_writer, "        <dd");

WriteAttributeTo(__razor_helper_writer, "id", Tuple.Create(" id=\"", 2744), Tuple.Create("\"", 2752)

#line 46 "..\..\Views\Apprenticeship\FrameworkDetails.cshtml"
, Tuple.Create(Tuple.Create("", 2749), Tuple.Create<System.Object, System.Int32>(id

#line default
#line hidden
, 2749), false)
);

WriteLiteralTo(__razor_helper_writer, ">\r\n");

WriteLiteralTo(__razor_helper_writer, "            ");


#line 47 "..\..\Views\Apprenticeship\FrameworkDetails.cshtml"
WriteTo(__razor_helper_writer, !string.IsNullOrEmpty(item) ? Html.MarkdownToHtml(item) : Html.MarkdownToHtml("none"));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n        </dd>\r\n");


#line 49 "..\..\Views\Apprenticeship\FrameworkDetails.cshtml"
    }


#line default
#line hidden
});

#line 50 "..\..\Views\Apprenticeship\FrameworkDetails.cshtml"
}
#line default
#line hidden

#line 52 "..\..\Views\Apprenticeship\FrameworkDetails.cshtml"
public System.Web.WebPages.HelperResult GetFrameworkPropertyRaw(string title, string id, string item, bool hideIfEmpty = false)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 53 "..\..\Views\Apprenticeship\FrameworkDetails.cshtml"
 
    if (!string.IsNullOrEmpty(item) || !hideIfEmpty)
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <dt>");


#line 56 "..\..\Views\Apprenticeship\FrameworkDetails.cshtml"
WriteTo(__razor_helper_writer, title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dt>\r\n");

WriteLiteralTo(__razor_helper_writer, "        <dd");

WriteAttributeTo(__razor_helper_writer, "id", Tuple.Create(" id=\"", 3082), Tuple.Create("\"", 3090)

#line 57 "..\..\Views\Apprenticeship\FrameworkDetails.cshtml"
, Tuple.Create(Tuple.Create("", 3087), Tuple.Create<System.Object, System.Int32>(id

#line default
#line hidden
, 3087), false)
);

WriteLiteralTo(__razor_helper_writer, ">\r\n");

WriteLiteralTo(__razor_helper_writer, "            ");


#line 58 "..\..\Views\Apprenticeship\FrameworkDetails.cshtml"
WriteTo(__razor_helper_writer, !string.IsNullOrEmpty(item) ? @Html.Raw(HttpUtility.HtmlDecode(item)) : Html.MarkdownToHtml("none"));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n        </dd>\r\n");


#line 60 "..\..\Views\Apprenticeship\FrameworkDetails.cshtml"
    }


#line default
#line hidden
});

#line 61 "..\..\Views\Apprenticeship\FrameworkDetails.cshtml"
}
#line default
#line hidden

#line 63 "..\..\Views\Apprenticeship\FrameworkDetails.cshtml"
public System.Web.WebPages.HelperResult GetFrameworkListProperty(string title, string id, IEnumerable<string> itemList, bool hideIfEmpty = false)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 64 "..\..\Views\Apprenticeship\FrameworkDetails.cshtml"
 
    if (!hideIfEmpty)
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <dt>");


#line 67 "..\..\Views\Apprenticeship\FrameworkDetails.cshtml"
WriteTo(__razor_helper_writer, title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dt>\r\n");

WriteLiteralTo(__razor_helper_writer, "        <dd");

WriteAttributeTo(__razor_helper_writer, "id", Tuple.Create(" id=\"", 3421), Tuple.Create("\"", 3429)

#line 68 "..\..\Views\Apprenticeship\FrameworkDetails.cshtml"
, Tuple.Create(Tuple.Create("", 3426), Tuple.Create<System.Object, System.Int32>(id

#line default
#line hidden
, 3426), false)
);

WriteLiteralTo(__razor_helper_writer, ">\r\n");

WriteLiteralTo(__razor_helper_writer, "            ");


#line 69 "..\..\Views\Apprenticeship\FrameworkDetails.cshtml"
WriteTo(__razor_helper_writer, itemList != null && itemList.Any() ? @Html.MarkdownToHtml(String.Join(", ", itemList)) : Html.MarkdownToHtml("none"));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n        </dd>\r\n");


#line 71 "..\..\Views\Apprenticeship\FrameworkDetails.cshtml"
    }


#line default
#line hidden
});

#line 72 "..\..\Views\Apprenticeship\FrameworkDetails.cshtml"
}
#line default
#line hidden

#line 74 "..\..\Views\Apprenticeship\FrameworkDetails.cshtml"
public System.Web.WebPages.HelperResult GetFrameworkJobRoleItemsListProperty(string title, string id, IEnumerable<JobRoleItem> itemList, bool hideIfEmpty = false)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 75 "..\..\Views\Apprenticeship\FrameworkDetails.cshtml"
 
    if (itemList != null && !hideIfEmpty)
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <dt>");


#line 78 "..\..\Views\Apprenticeship\FrameworkDetails.cshtml"
WriteTo(__razor_helper_writer, title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dt>\r\n");

WriteLiteralTo(__razor_helper_writer, "        <dd");

WriteAttributeTo(__razor_helper_writer, "id", Tuple.Create(" id=\"", 3814), Tuple.Create("\"", 3822)

#line 79 "..\..\Views\Apprenticeship\FrameworkDetails.cshtml"
, Tuple.Create(Tuple.Create("", 3819), Tuple.Create<System.Object, System.Int32>(id

#line default
#line hidden
, 3819), false)
);

WriteLiteralTo(__razor_helper_writer, ">\r\n");


#line 80 "..\..\Views\Apprenticeship\FrameworkDetails.cshtml"
            

#line default
#line hidden

#line 80 "..\..\Views\Apprenticeship\FrameworkDetails.cshtml"
             if (itemList.Any())
            {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "                <ul>\r\n");


#line 83 "..\..\Views\Apprenticeship\FrameworkDetails.cshtml"
                    

#line default
#line hidden

#line 83 "..\..\Views\Apprenticeship\FrameworkDetails.cshtml"
                     foreach (var item in itemList)
                    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "                        <li>\r\n                            <span>\r\n               " +
"                 <b>\r\n");

WriteLiteralTo(__razor_helper_writer, "                                    ");


#line 88 "..\..\Views\Apprenticeship\FrameworkDetails.cshtml"
       WriteTo(__razor_helper_writer, !string.IsNullOrEmpty(item.Title) ? Html.MarkdownToHtml(item.Title) : Html.MarkdownToHtml("none"));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n                                </b>\r\n");

WriteLiteralTo(__razor_helper_writer, "                                ");


#line 90 "..\..\Views\Apprenticeship\FrameworkDetails.cshtml"
   WriteTo(__razor_helper_writer, !string.IsNullOrEmpty(@item.Description) ? Html.MarkdownToHtml(@item.Description) : Html.MarkdownToHtml("none"));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n                            </span>\r\n                        </li>\r\n");


#line 93 "..\..\Views\Apprenticeship\FrameworkDetails.cshtml"
                    }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "                </ul>\r\n");


#line 95 "..\..\Views\Apprenticeship\FrameworkDetails.cshtml"
            }
            else
            {
                

#line default
#line hidden

#line 98 "..\..\Views\Apprenticeship\FrameworkDetails.cshtml"
WriteTo(__razor_helper_writer, Html.MarkdownToHtml("none"));


#line default
#line hidden

#line 98 "..\..\Views\Apprenticeship\FrameworkDetails.cshtml"
                                            
            }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        </dd>\r\n");


#line 101 "..\..\Views\Apprenticeship\FrameworkDetails.cshtml"
    }


#line default
#line hidden
});

#line 102 "..\..\Views\Apprenticeship\FrameworkDetails.cshtml"
}
#line default
#line hidden

#line 104 "..\..\Views\Apprenticeship\FrameworkDetails.cshtml"
public System.Web.WebPages.HelperResult GetFrameworkTypicalLengthProperty(string title, string id, TypicalLength item, bool hideIfEmpty = false)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 105 "..\..\Views\Apprenticeship\FrameworkDetails.cshtml"
 
    if (!hideIfEmpty)
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <dt>");


#line 108 "..\..\Views\Apprenticeship\FrameworkDetails.cshtml"
WriteTo(__razor_helper_writer, title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</dt>\r\n");

WriteLiteralTo(__razor_helper_writer, "        <dd");

WriteAttributeTo(__razor_helper_writer, "id", Tuple.Create(" id=\"", 4833), Tuple.Create("\"", 4841)

#line 109 "..\..\Views\Apprenticeship\FrameworkDetails.cshtml"
, Tuple.Create(Tuple.Create("", 4838), Tuple.Create<System.Object, System.Int32>(id

#line default
#line hidden
, 4838), false)
);

WriteLiteralTo(__razor_helper_writer, ">\r\n");


#line 110 "..\..\Views\Apprenticeship\FrameworkDetails.cshtml"
            

#line default
#line hidden

#line 110 "..\..\Views\Apprenticeship\FrameworkDetails.cshtml"
             if (item != null)
            {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "                <span>From ");


#line 112 "..\..\Views\Apprenticeship\FrameworkDetails.cshtml"
WriteTo(__razor_helper_writer, item.From);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " to ");


#line 112 "..\..\Views\Apprenticeship\FrameworkDetails.cshtml"
           WriteTo(__razor_helper_writer, item.To);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " ");


#line 112 "..\..\Views\Apprenticeship\FrameworkDetails.cshtml"
                    WriteTo(__razor_helper_writer, item.Unit);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</span>\r\n");


#line 113 "..\..\Views\Apprenticeship\FrameworkDetails.cshtml"
            }
            else
            {
                

#line default
#line hidden

#line 116 "..\..\Views\Apprenticeship\FrameworkDetails.cshtml"
WriteTo(__razor_helper_writer, Html.MarkdownToHtml("none"));


#line default
#line hidden

#line 116 "..\..\Views\Apprenticeship\FrameworkDetails.cshtml"
                                            
            }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        </dd>\r\n");


#line 119 "..\..\Views\Apprenticeship\FrameworkDetails.cshtml"
}


#line default
#line hidden
});

#line 120 "..\..\Views\Apprenticeship\FrameworkDetails.cshtml"
}
#line default
#line hidden

        public FrameworkDetails()
        {
        }
        public override void Execute()
        {
            
            #line 6 "..\..\Views\Apprenticeship\FrameworkDetails.cshtml"
  
    ViewBag.Title = $"{@Model.FrameworkName}: {Model.Pathway} - FrameworkDetails";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" class=\"framework-details\"");

WriteLiteral(">\r\n\r\n    <h2");

WriteLiteral(" class=\"pageTitle\"");

WriteLiteral(">");

            
            #line 12 "..\..\Views\Apprenticeship\FrameworkDetails.cshtml"
                     Write(Model.FrameworkName);

            
            #line default
            #line hidden
WriteLiteral(": ");

            
            #line 12 "..\..\Views\Apprenticeship\FrameworkDetails.cshtml"
                                           Write(Model.Pathway);

            
            #line default
            #line hidden
WriteLiteral("</h2>\r\n    <span>\r\n        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 344), Tuple.Create("\"", 410)
            
            #line 14 "..\..\Views\Apprenticeship\FrameworkDetails.cshtml"
, Tuple.Create(Tuple.Create("", 351), Tuple.Create<System.Object, System.Int32>(Url.Action("EditFramework", routeValues: new { Model.Id })
            
            #line default
            #line hidden
, 351), false)
);

WriteLiteral(">\r\n            Edit\r\n            <i");

WriteLiteral(" class=\"fa fa-pencil-square-o\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral("></i>\r\n        </a>\r\n    </span>\r\n    <div>\r\n");

WriteLiteral("        ");

            
            #line 20 "..\..\Views\Apprenticeship\FrameworkDetails.cshtml"
   Write(GetFrameworkProperty("ApprenticeshipId", "apprenticeshipId", Model.ApprenticeshipId.ToString()));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

            
            #line 21 "..\..\Views\Apprenticeship\FrameworkDetails.cshtml"
   Write(GetFrameworkTypicalLengthProperty("Typical Length", "typicalLength", Model.TypicalLength));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

            
            #line 22 "..\..\Views\Apprenticeship\FrameworkDetails.cshtml"
   Write(GetFrameworkProperty("Framework Code", "frameworkCode", Model.FrameworkCode.ToString()));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

            
            #line 23 "..\..\Views\Apprenticeship\FrameworkDetails.cshtml"
   Write(GetFrameworkProperty("Prog Type", "progType", Model.ProgType.ToString()));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

            
            #line 24 "..\..\Views\Apprenticeship\FrameworkDetails.cshtml"
   Write(GetFrameworkProperty("Pathway Code", "pathwayCode", Model.PathwayCode.ToString()));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

            
            #line 25 "..\..\Views\Apprenticeship\FrameworkDetails.cshtml"
   Write(GetFrameworkProperty("Effective From", "effectiveFrom", Model.EffectiveFrom.ToString(CultureInfo.CurrentCulture)));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

            
            #line 26 "..\..\Views\Apprenticeship\FrameworkDetails.cshtml"
   Write(GetFrameworkProperty("Effective To", "effectiveTo", Model.EffectiveTo.ToString()));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

            
            #line 27 "..\..\Views\Apprenticeship\FrameworkDetails.cshtml"
   Write(GetFrameworkJobRoleItemsListProperty("Job Role Items", "jobRoleItems", Model.JobRoleItems));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

            
            #line 28 "..\..\Views\Apprenticeship\FrameworkDetails.cshtml"
   Write(GetFrameworkListProperty("Keywords", "keywords", Model.Keywords));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

            
            #line 29 "..\..\Views\Apprenticeship\FrameworkDetails.cshtml"
   Write(GetFrameworkProperty("Sector Subject Area Tier 1", "sectorSubjectAreaTier1", Model.SectorSubjectAreaTier1.ToString(CultureInfo.InvariantCulture)));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

            
            #line 30 "..\..\Views\Apprenticeship\FrameworkDetails.cshtml"
   Write(GetFrameworkProperty("Sector Subject Area Tier 2", "sectorSubjectAreaTier2", Model.SectorSubjectAreaTier2.ToString(CultureInfo.InvariantCulture)));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

            
            #line 31 "..\..\Views\Apprenticeship\FrameworkDetails.cshtml"
   Write(GetFrameworkPropertyRaw("Framework Overview", "frameworkOverview", @Model.FrameworkOverview));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

            
            #line 32 "..\..\Views\Apprenticeship\FrameworkDetails.cshtml"
   Write(GetFrameworkPropertyRaw("Entry Requirements", "entryRequirements", Model.EntryRequirements));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

            
            #line 33 "..\..\Views\Apprenticeship\FrameworkDetails.cshtml"
   Write(GetFrameworkPropertyRaw("Professional Registration", "professionalRegistration", Model.ProfessionalRegistration));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

            
            #line 34 "..\..\Views\Apprenticeship\FrameworkDetails.cshtml"
   Write(GetFrameworkPropertyRaw("Completion Qualifications", "completionQualifications", Model.CompletionQualifications));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

            
            #line 35 "..\..\Views\Apprenticeship\FrameworkDetails.cshtml"
   Write(GetFrameworkListProperty("Competency Qualification", "competencyQualification", Model.CompetencyQualification));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

            
            #line 36 "..\..\Views\Apprenticeship\FrameworkDetails.cshtml"
   Write(GetFrameworkListProperty("Knowledge Qualification", "knowledgeQualification", Model.KnowledgeQualification));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

            
            #line 37 "..\..\Views\Apprenticeship\FrameworkDetails.cshtml"
   Write(GetFrameworkListProperty("Combined Qualification", "combinedQualification", Model.CombinedQualification));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
