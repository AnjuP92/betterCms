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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/Layouts/MasterLayout.cshtml")]
    public partial class _Views_Shared_Layouts_MasterLayout_cshtml : System.Web.Mvc.WebViewPage<BetterCms.Module.Root.ViewModels.Cms.RenderPageViewModel>
    {
        public _Views_Shared_Layouts_MasterLayout_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 29 "..\..\Views\Shared\Layouts\MasterLayout.cshtml"
  
    Layout = "~/Areas/bcms-Root/Views/Shared/BaseLayout.cshtml";

            
            #line default
            #line hidden
WriteLiteral("\r\n");

DefineSection("CmsHeadScripts", () => {

WriteLiteral("\r\n    <meta");

WriteLiteral(" charset=\"utf-8\"");

WriteLiteral(" />\r\n");

WriteLiteral("    ");

            
            #line 34 "..\..\Views\Shared\Layouts\MasterLayout.cshtml"
Write(RenderSection("CmsHeadScripts", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

});

DefineSection("Styles", () => {

WriteLiteral("\r\n    <meta");

WriteLiteral(" name=\"twitter:card\"");

WriteLiteral(" content=\"summary\"");

WriteLiteral(" />\r\n    <meta");

WriteLiteral(" http-equiv=\"X-UA-Compatible\"");

WriteLiteral(" content=\"IE=edge\"");

WriteLiteral(">\r\n    <meta");

WriteLiteral(" name=\"viewport\"");

WriteLiteral(" content=\"width=device-width, initial-scale=1, minimum-scale=1, maximum-scale=1\"");

WriteLiteral(" />\r\n    <meta");

WriteLiteral(" name=\"google\"");

WriteLiteral(" content=\"notranslate\"");

WriteLiteral(">\r\n    <link");

WriteLiteral(" type=\"text/css\"");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" href=\"//fast.fonts.net/cssapi/ff50334d-7692-47b2-913a-6c24a82061e2.css\"");

WriteLiteral(" />\r\n");

});

WriteLiteral("\r\n");

            
            #line 44 "..\..\Views\Shared\Layouts\MasterLayout.cshtml"
Write(RenderBody());

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 45 "..\..\Views\Shared\Layouts\MasterLayout.cshtml"
Write(RenderSection("Body", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591