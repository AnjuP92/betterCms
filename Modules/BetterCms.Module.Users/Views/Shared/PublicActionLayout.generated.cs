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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/PublicActionLayout.cshtml")]
    public partial class _Views_Shared_PublicActionLayout_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared_PublicActionLayout_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n<head>\r\n    <meta");

WriteLiteral(" http-equiv=\"Content-Type\"");

WriteLiteral(" content=\"text/html; charset=UTF-8\"");

WriteLiteral(">\r\n    <title>");

            
            #line 32 "..\..\Views\Shared\PublicActionLayout.cshtml"
      Write(ViewBag.Title);

            
            #line default
            #line hidden
WriteLiteral("</title>\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" type=\"text/css\"");

WriteLiteral(" href=\"/file/bcms-users/Content/Styles/bcms.users.min.css\"");

WriteLiteral(" />\r\n\r\n");

WriteLiteral("    ");

            
            #line 35 "..\..\Views\Shared\PublicActionLayout.cshtml"
Write(RenderSection("Head", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n</head>\r\n\r\n<body>\r\n    <div");

WriteLiteral(" class=\"bcms-modal bcms-modal-installation\"");

WriteLiteral(" spellcheck=\"true\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"bcms-modal-body\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"bcms-modal-header\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"bcms-modal-frame-holder\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"bcms-modal-title\"");

WriteLiteral(">");

            
            #line 43 "..\..\Views\Shared\PublicActionLayout.cshtml"
                                             Write(ViewBag.Title);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                </div>\r\n            </div>\r\n\r\n            <div");

WriteLiteral(" class=\"bcms-modal-content\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"bcms-window-installation\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 49 "..\..\Views\Shared\PublicActionLayout.cshtml"
               Write(RenderBody());

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div");

WriteLiteral(" class=\"bcms-modal-footer\"");

WriteLiteral("></div>\r\n        </div>\r\n    </div>\r\n</body>\r\n</html>\r\n");

        }
    }
}
#pragma warning restore 1591
