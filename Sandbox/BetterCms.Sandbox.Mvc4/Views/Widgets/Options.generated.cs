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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Widgets/Options.cshtml")]
    public partial class _Views_Widgets_Options_cshtml : System.Web.Mvc.WebViewPage<BetterCms.Module.Root.ViewModels.Cms.RenderWidgetViewModel>
    {
        public _Views_Widgets_Options_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n");

            
            #line 29 "..\..\Views\Widgets\Options.cshtml"
 if (Model != null)
{

            
            #line default
            #line hidden
WriteLiteral("    <h2>Widget Name: ");

            
            #line 31 "..\..\Views\Widgets\Options.cshtml"
                Write(Model.Widget.Name);

            
            #line default
            #line hidden
WriteLiteral("</h2>\n");

WriteLiteral("    <h3>Current Page: ");

            
            #line 32 "..\..\Views\Widgets\Options.cshtml"
                 Write(Model.Page.PageUrl);

            
            #line default
            #line hidden
WriteLiteral("</h3>\n");

WriteLiteral("    <p>Page options:</p>\n");

            
            #line 34 "..\..\Views\Widgets\Options.cshtml"
    if (Model != null && Model.Page.Options != null)
    {
        foreach (var option in Model.Page.Options)
        {

            
            #line default
            #line hidden
WriteLiteral("            <strong>Option \"");

            
            #line 38 "..\..\Views\Widgets\Options.cshtml"
                       Write(option.Key);

            
            #line default
            #line hidden
WriteLiteral("\" Type:</strong> ");

            
            #line 38 "..\..\Views\Widgets\Options.cshtml"
                                                        
            
            #line default
            #line hidden
            
            #line 38 "..\..\Views\Widgets\Options.cshtml"
                                                    Write(option.Value != null ? option.Value.GetType().ToString() : string.Empty);

            
            #line default
            #line hidden
            
            #line 38 "..\..\Views\Widgets\Options.cshtml"
                                                                                                                                  

            
            #line default
            #line hidden
WriteLiteral("            <strong>; Value: </strong> ");

            
            #line 39 "..\..\Views\Widgets\Options.cshtml"
                                       
            
            #line default
            #line hidden
            
            #line 39 "..\..\Views\Widgets\Options.cshtml"
                                  Write(option.Value);

            
            #line default
            #line hidden
WriteLiteral(" <br/>\n");

            
            #line 40 "..\..\Views\Widgets\Options.cshtml"
        }
    }
}
else
{

            
            #line default
            #line hidden
WriteLiteral("    <p>Widget Preview...</p>\n");

            
            #line 46 "..\..\Views\Widgets\Options.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("<p>Widget options:</p>\n");

            
            #line 48 "..\..\Views\Widgets\Options.cshtml"
 if (Model != null && Model.Options != null)
{
    foreach (var option in Model.Options)
    {

            
            #line default
            #line hidden
WriteLiteral("        <strong>Option \"");

            
            #line 52 "..\..\Views\Widgets\Options.cshtml"
                   Write(option.Key);

            
            #line default
            #line hidden
WriteLiteral("\" Type:</strong> ");

            
            #line 52 "..\..\Views\Widgets\Options.cshtml"
                                                    
            
            #line default
            #line hidden
            
            #line 52 "..\..\Views\Widgets\Options.cshtml"
                                                Write(option.Value != null ? option.Value.GetType().ToString() : string.Empty);

            
            #line default
            #line hidden
            
            #line 52 "..\..\Views\Widgets\Options.cshtml"
                                                                                                                              

            
            #line default
            #line hidden
WriteLiteral("        <strong>; Value: </strong> ");

            
            #line 53 "..\..\Views\Widgets\Options.cshtml"
                                   
            
            #line default
            #line hidden
            
            #line 53 "..\..\Views\Widgets\Options.cshtml"
                              Write(option.Value);

            
            #line default
            #line hidden
WriteLiteral(" <br />\n");

            
            #line 54 "..\..\Views\Widgets\Options.cshtml"
    }
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
