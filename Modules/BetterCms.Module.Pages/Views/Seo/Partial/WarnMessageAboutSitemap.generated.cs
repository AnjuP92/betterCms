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
    
    #line 28 "..\..\Views\Seo\Partial\WarnMessageAboutSitemap.cshtml"
    using BetterCms.Module.Pages.Content.Resources;
    
    #line default
    #line hidden
    
    #line 29 "..\..\Views\Seo\Partial\WarnMessageAboutSitemap.cshtml"
    using BetterCms.Module.Root.Content.Resources;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Seo/Partial/WarnMessageAboutSitemap.cshtml")]
    public partial class _Views_Seo_Partial_WarnMessageAboutSitemap_cshtml : System.Web.Mvc.WebViewPage<BetterCms.Module.Pages.ViewModels.Seo.EditSeoViewModel>
    {
        public _Views_Seo_Partial_WarnMessageAboutSitemap_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("\n");

            
            #line 33 "..\..\Views\Seo\Partial\WarnMessageAboutSitemap.cshtml"
 if (!Model.IsInSitemap)
{

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"bcms-messages-ui bcms-js-messages\"");

WriteLiteral(">\r\n        <ul");

WriteLiteral(" class=\"bcms-success-messages\"");

WriteLiteral(" style=\"display: none\"");

WriteLiteral("></ul>\r\n        <ul");

WriteLiteral(" class=\"bcms-info-messages\"");

WriteLiteral(" style=\"display: none\"");

WriteLiteral("></ul>\r\n        <ul");

WriteLiteral(" class=\"bcms-warning-messages\"");

WriteLiteral(">\r\n            <li>\r\n                <div");

WriteLiteral(" class=\"bcms-messages-close bcms-js-btn-close\"");

WriteLiteral(" id=\"bcms-seo-closeinfomessage\"");

WriteLiteral(">");

            
            #line 40 "..\..\Views\Seo\Partial\WarnMessageAboutSitemap.cshtml"
                                                                                             Write(RootGlobalization.Button_Close);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

WriteLiteral("                ");

            
            #line 41 "..\..\Views\Seo\Partial\WarnMessageAboutSitemap.cshtml"
           Write(PagesGlobalization.EditSeo_Messages_NotInSitemapWarnMessage);

            
            #line default
            #line hidden
WriteLiteral("\r\n            </li>\r\n        </ul>\r\n        <ul");

WriteLiteral(" class=\"bcms-error-messages\"");

WriteLiteral(" style=\"display: none\"");

WriteLiteral("></ul>\r\n    </div>\r\n");

            
            #line 46 "..\..\Views\Seo\Partial\WarnMessageAboutSitemap.cshtml"
}

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591