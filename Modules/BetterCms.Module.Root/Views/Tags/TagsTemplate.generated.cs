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
    
    #line 28 "..\..\Views\Tags\TagsTemplate.cshtml"
    using BetterCms.Module.Root;
    
    #line default
    #line hidden
    
    #line 29 "..\..\Views\Tags\TagsTemplate.cshtml"
    using BetterCms.Module.Root.Content.Resources;
    
    #line default
    #line hidden
    
    #line 30 "..\..\Views\Tags\TagsTemplate.cshtml"
    using BetterCms.Module.Root.Mvc;
    
    #line default
    #line hidden
    
    #line 31 "..\..\Views\Tags\TagsTemplate.cshtml"
    using BetterCms.Module.Root.Mvc.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Tags/TagsTemplate.cshtml")]
    public partial class _Views_Tags_TagsTemplate_cshtml : System.Web.Mvc.WebViewPage<BetterCms.Module.Root.ViewModels.Tags.TagsTemplateViewModel>
    {
        public _Views_Tags_TagsTemplate_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 34 "..\..\Views\Tags\TagsTemplate.cshtml"
   var canEdit = (ViewContext.Controller as CmsControllerBase).SecurityService.IsAuthorized(RootModuleConstants.UserRoles.EditContent); 
            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" class=\"bcms-content-titles\"");

WriteLiteral(">");

            
            #line 36 "..\..\Views\Tags\TagsTemplate.cshtml"
                            Write(RootGlobalization.TagsTemplate_AddTags_Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 37 "..\..\Views\Tags\TagsTemplate.cshtml"
Write(Html.Tooltip(Model.TooltipDescription));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" class=\"bcms-field-wrapper\"");

WriteLiteral(" data-bind=\"visible: isExpanded()\"");

WriteLiteral(">\r\n    <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"bcms-field-text\"");

WriteLiteral(@" data-bind=""
                    css: { 'bcms-input-validation-error': newItem.hasError() },
                    value: newItem,
                    valueUpdate: 'afterkeydown',
                    hasfocus: hasfocus,
                    autocompleteList: '',
                    enterPress: addItem,
                    escPress: clearItem""");

WriteLiteral(" />\r\n    <!-- ko if: newItem.hasError()  -->\r\n    <span");

WriteLiteral(" class=\"bcms-field-validation-error\"");

WriteLiteral(">\r\n        <span");

WriteLiteral(" data-bind=\"text: newItem.validationMessage()\"");

WriteLiteral("></span>\r\n    </span>\r\n    <!-- /ko -->\r\n</div>\r\n\r\n<div");

WriteLiteral(" class=\"bcms-single-tag-holder\"");

WriteLiteral(" data-bind=\"foreach: items()\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"bcms-single-tag\"");

WriteLiteral(" data-bind=\"css: { \'bcms-single-tag-active\': isActive() }\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" data-bind=\"text: name()\"");

WriteLiteral("></div>\r\n        <div");

WriteLiteral(" class=\"bcms-single-tag-remove\"");

WriteLiteral(" data-bind=\"");

            
            #line 58 "..\..\Views\Tags\TagsTemplate.cshtml"
                                                   Write(canEdit ? "click: remove" : string.Empty);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">");

            
            #line 58 "..\..\Views\Tags\TagsTemplate.cshtml"
                                                                                               Write(RootGlobalization.Button_Remove);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n    </div>\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-bind=\"attr: { name: getItemInputName($index()), value: name() }\"");

WriteLiteral(" />\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591