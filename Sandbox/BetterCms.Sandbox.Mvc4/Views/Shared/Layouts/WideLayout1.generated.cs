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
    
    #line 29 "..\..\Views\Shared\Layouts\WideLayout.cshtml"
    using BetterCms.Module.Installation;
    
    #line default
    #line hidden
    
    #line 28 "..\..\Views\Shared\Layouts\WideLayout.cshtml"
    using BetterCms.Module.Root.Mvc.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/Layouts/WideLayout.cshtml")]
    public partial class _Views_Shared_Layouts_WideLayout_cshtml : System.Web.Mvc.WebViewPage<BetterCms.Core.DataContracts.IPage>
    {
        public _Views_Shared_Layouts_WideLayout_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n");

            
            #line 31 "..\..\Views\Shared\Layouts\WideLayout.cshtml"
  
    Layout = "~/Areas/bcms-Root/Views/Shared/BaseLayout.cshtml";

            
            #line default
            #line hidden
WriteLiteral("\n\n");

DefineSection("Styles", () => {

WriteLiteral("    \n");

WriteLiteral("    ");

            
            #line 36 "..\..\Views\Shared\Layouts\WideLayout.cshtml"
Write(RenderSection("Styles", false));

            
            #line default
            #line hidden
WriteLiteral("\n");

WriteLiteral("    ");

            
            #line 37 "..\..\Views\Shared\Layouts\WideLayout.cshtml"
Write(Html.RenderStyleSheets<InstallationModuleDescriptor>());

            
            #line default
            #line hidden
WriteLiteral("\n");

});

WriteLiteral("\n");

DefineSection("HeadScripts", () => {

WriteLiteral("\n");

WriteLiteral("    ");

            
            #line 41 "..\..\Views\Shared\Layouts\WideLayout.cshtml"
Write(RenderSection("HeadScripts", false));

            
            #line default
            #line hidden
WriteLiteral("\n");

});

WriteLiteral("\n<div");

WriteLiteral(" class=\"page\"");

WriteLiteral(">\n\n    <header");

WriteLiteral(" class=\"page-header\"");

WriteLiteral(">\n        <div");

WriteLiteral(" class=\"page-frame clearfix\"");

WriteLiteral(">\n            <div>\n");

WriteLiteral("                ");

            
            #line 49 "..\..\Views\Shared\Layouts\WideLayout.cshtml"
           Write(RenderSection("CMSHeader", false));

            
            #line default
            #line hidden
WriteLiteral("\n            </div>\n        </div>\n    </header>\n\n    <div");

WriteLiteral(" class=\"page-block\"");

WriteLiteral(">\n        <div");

WriteLiteral(" class=\"page-frame clearfix\"");

WriteLiteral(">\n");

WriteLiteral("            ");

            
            #line 56 "..\..\Views\Shared\Layouts\WideLayout.cshtml"
       Write(RenderSection("CMSMainContent", false));

            
            #line default
            #line hidden
WriteLiteral("\n");

WriteLiteral("            ");

            
            #line 57 "..\..\Views\Shared\Layouts\WideLayout.cshtml"
       Write(RenderBody());

            
            #line default
            #line hidden
WriteLiteral("\n        </div>\n    </div>\n\n</div>\n\n<footer");

WriteLiteral(" class=\"page-footer\"");

WriteLiteral(">\n    <div");

WriteLiteral(" class=\"page-frame clearfix\"");

WriteLiteral(">\n");

WriteLiteral("        ");

            
            #line 65 "..\..\Views\Shared\Layouts\WideLayout.cshtml"
   Write(RenderSection("CMSFooter", false));

            
            #line default
            #line hidden
WriteLiteral("\n    </div>\n</footer>\n");

        }
    }
}
#pragma warning restore 1591
