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

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 28 "..\..\Views\Content\Partial\EditHtmlContent.cshtml"
    using BetterCms.Module.Pages.Content.Resources;
    
    #line default
    #line hidden
    
    #line 29 "..\..\Views\Content\Partial\EditHtmlContent.cshtml"
    using BetterCms.Module.Root.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 30 "..\..\Views\Content\Partial\EditHtmlContent.cshtml"
    using BetterCms.Module.Root.Mvc.UI;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Content/Partial/EditHtmlContent.cshtml")]
    public partial class _Views_Content_Partial_EditHtmlContent_cshtml : System.Web.Mvc.WebViewPage<BetterCms.Module.Pages.ViewModels.Content.PageContentViewModel>
    {
        public _Views_Content_Partial_EditHtmlContent_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 33 "..\..\Views\Content\Partial\EditHtmlContent.cshtml"
Write(Html.HiddenFor(model => model.EditInSourceMode, new { @id = "bcms-edit-in-source-mode" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 34 "..\..\Views\Content\Partial\EditHtmlContent.cshtml"
Write(Html.HiddenFor(model => model.ContentTextMode, new { @id = "bcms-content-text-mode" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" class=\"bcms-content-info-block varsha\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 38 "..\..\Views\Content\Partial\EditHtmlContent.cshtml"
                                    Write(PagesGlobalization.AddPageContent_RegularContentTab_ContentName_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

WriteLiteral("        ");

            
            #line 39 "..\..\Views\Content\Partial\EditHtmlContent.cshtml"
   Write(Html.Tooltip(PagesGlobalization.AddPageContent_RegularContentTab_ContentName_Tooltip_Description));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <div");

WriteLiteral(" class=\"bcms-field-wrapper\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 41 "..\..\Views\Content\Partial\EditHtmlContent.cshtml"
       Write(Html.TextBoxFor(model => model.ContentName, new { @class = "bcms-field-text" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 42 "..\..\Views\Content\Partial\EditHtmlContent.cshtml"
       Write(Html.BcmsValidationMessageFor(model => model.ContentName));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 47 "..\..\Views\Content\Partial\EditHtmlContent.cshtml"
                                    Write(PagesGlobalization.AddPageContent_RegularContentTab_LiveFrom_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n        <div");

WriteLiteral(" class=\"bcms-field-wrapper\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 49 "..\..\Views\Content\Partial\EditHtmlContent.cshtml"
       Write(Html.DateTextBoxFor(model => model.LiveFrom, Model.LiveFrom, new Dictionary<string, object> { { "class", "bcms-field-text bcms-datepicker" } }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 50 "..\..\Views\Content\Partial\EditHtmlContent.cshtml"
       Write(Html.BcmsValidationMessageFor(model => model.LiveFrom));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div");

WriteLiteral(" class=\"bcms-input-list-holder\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 55 "..\..\Views\Content\Partial\EditHtmlContent.cshtml"
                                    Write(PagesGlobalization.AddPageContent_RegularContentTab_LiveTo_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n        <div");

WriteLiteral(" class=\"bcms-field-wrapper\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 57 "..\..\Views\Content\Partial\EditHtmlContent.cshtml"
       Write(Html.DateTextBoxFor(model => model.LiveTo, Model.LiveTo, new Dictionary<string, object> { { "class", "bcms-field-text bcms-datepicker" } }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 58 "..\..\Views\Content\Partial\EditHtmlContent.cshtml"
       Write(Html.BcmsValidationMessageFor(model => model.LiveTo));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div");

WriteLiteral(" class=\"bcms-field-wrapper\"");

WriteLiteral(">\r\n");

WriteLiteral("    ");

            
            #line 64 "..\..\Views\Content\Partial\EditHtmlContent.cshtml"
Write(Html.TextAreaFor(model => model.PageContent, new { @class = "bcms-contenthtml", @id = Guid.NewGuid() }));

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
