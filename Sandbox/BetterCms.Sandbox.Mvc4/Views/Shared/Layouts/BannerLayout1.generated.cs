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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/Layouts/BannerLayout.cshtml")]
    public partial class _Views_Shared_Layouts_BannerLayout_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared_Layouts_BannerLayout_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Shared\Layouts\BannerLayout.cshtml"
  
    Layout = "~/Areas/bcms-Root/Views/Shared/BaseLayout.cshtml";

            
            #line default
            #line hidden
WriteLiteral("\r\n");

DefineSection("Styles", () => {

WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 5 "..\..\Views\Shared\Layouts\BannerLayout.cshtml"
Write(RenderSection("Styles", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

});

WriteLiteral("\r\n<link");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" href=\"/file/bcms-installation/content/styles/bootstrap.css\"");

WriteLiteral(" />\r\n\r\n<div");

WriteLiteral(" style=\"height: 560px; background-size: cover; background-position: 80% center; b" +
"ackground-image: url(/file/bcms-installation/content/styles/images/banner_img.jp" +
"g); \"");

WriteLiteral("></div>\r\n<header>\r\n    <div>\r\n");

WriteLiteral("        ");

            
            #line 14 "..\..\Views\Shared\Layouts\BannerLayout.cshtml"
   Write(RenderSection("CMSHeader", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n</header>\r\n\r\n<div>\r\n\r\n");

WriteLiteral("    ");

            
            #line 20 "..\..\Views\Shared\Layouts\BannerLayout.cshtml"
Write(RenderSection("CMSMainContent", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 21 "..\..\Views\Shared\Layouts\BannerLayout.cshtml"
Write(RenderBody());

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>\r\n\r\n\r\n<footer>\r\n    <div>\r\n");

WriteLiteral("        ");

            
            #line 27 "..\..\Views\Shared\Layouts\BannerLayout.cshtml"
   Write(RenderSection("CMSFooter", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n</footer>\r\n");

        }
    }
}
#pragma warning restore 1591
