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
    
    #line 2 "..\..\Views\Widgets\MyWidget.cshtml"
    using BetterCms.Module.Root.Mvc.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Widgets/MyWidget.cshtml")]
    public partial class _Views_Widgets_MyWidget_cshtml : System.Web.Mvc.WebViewPage<BetterCms.Module.Root.ViewModels.Cms.RenderWidgetViewModel>
    {
        public _Views_Widgets_MyWidget_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 5 "..\..\Views\Widgets\MyWidget.cshtml"
 if (Model != null)
{


            
            #line default
            #line hidden
WriteLiteral("    <h2>");

            
            #line 8 "..\..\Views\Widgets\MyWidget.cshtml"
   Write(Model.Widget.Name);

            
            #line default
            #line hidden
WriteLiteral("</h2>\r\n");

            
            #line 9 "..\..\Views\Widgets\MyWidget.cshtml"
   
    
            
            #line default
            #line hidden
            
            #line 10 "..\..\Views\Widgets\MyWidget.cshtml"
     if (Model != null && Model.Options != null)
    {
        
        

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"container\"");

WriteLiteral(">\r\n           <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-sm-3\"");

WriteLiteral(" style=\"background-color:lavender;border:1px solid black;\"");

WriteLiteral(">\r\n                    <img");

WriteLiteral(" src=\"/file/bcms-installation/content/styles/images/banner_img.jpg\"");

WriteLiteral(" style=\"height:200px;width:100%;\"");

WriteLiteral(" />\r\n                    <h3>Responsive</h3>\r\n\r\n                </div>\r\n         " +
"       <div");

WriteLiteral(" class=\"col-sm-3\"");

WriteLiteral(" style=\"background-color: lavender; border: 1px solid black;\"");

WriteLiteral(">\r\n                    <img");

WriteLiteral(" src=\"/file/bcms-installation/content/styles/images/banner_img.jpg\"");

WriteLiteral(" style=\"height: 200px; width: 100%;\"");

WriteLiteral(" />\r\n                    <h3>Responsive</h3>\r\n                </div>\r\n           " +
"     <div");

WriteLiteral(" class=\"col-sm-3\"");

WriteLiteral(" style=\"background-color: lavender; border: 1px solid black;\"");

WriteLiteral(">\r\n                    <img");

WriteLiteral(" src=\"/file/bcms-installation/content/styles/images/banner_img.jpg\"");

WriteLiteral(" style=\"height: 200px; width: 100%;\"");

WriteLiteral(" />\r\n                    <h3>Responsive</h3>\r\n                </div>\r\n           " +
"    <div");

WriteLiteral(" class=\"col-sm-3\"");

WriteLiteral(" style=\"background-color: lavender; border: 1px solid black;\"");

WriteLiteral(">\r\n                   <img");

WriteLiteral(" src=\"/file/bcms-installation/content/styles/images/banner_img.jpg\"");

WriteLiteral(" style=\"height: 200px; width: 100%;\"");

WriteLiteral(" />\r\n                   <h3>Responsive</h3>\r\n               </div>\r\n           </" +
"div>\r\n        </div>\r\n");

            
            #line 35 "..\..\Views\Widgets\MyWidget.cshtml"

    }
            
            #line default
            #line hidden
            
            #line 36 "..\..\Views\Widgets\MyWidget.cshtml"
     
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591