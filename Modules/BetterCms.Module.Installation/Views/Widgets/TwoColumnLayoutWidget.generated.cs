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
    
    #line 1 "..\..\Views\Widgets\TwoColumnLayoutWidget.cshtml"
    using BetterCms.Module.Root.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Widgets\TwoColumnLayoutWidget.cshtml"
    using BetterCms.Module.Root.ViewModels.Cms;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Widgets/TwoColumnLayoutWidget.cshtml")]
    public partial class _Views_Widgets_TwoColumnLayoutWidget_cshtml : System.Web.Mvc.WebViewPage<BetterCms.Module.Root.ViewModels.Cms.RenderWidgetViewModel>
    {
        public _Views_Widgets_TwoColumnLayoutWidget_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("<link");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" href=\"/file/bcms-installation/Content/Styles/cssStyles.css\"");

WriteLiteral(" />\r\n\r\n");

            
            #line 7 "..\..\Views\Widgets\TwoColumnLayoutWidget.cshtml"
 if (Model != null && Model.Options != null)
{
    /*string guid = Guid.NewGuid().ToString();
    string objDivId = "marquee" + guid;
    RenderWidgetViewModel.MarqueeRootObject robj = null;
    string imgWidth = "200";*/
    string content1 = null;
    string imgWidth=null;
    string imgSrc=null, col1width = null, col2width = null, bgcolor = null,padding = null;
    foreach (var options in Model.Options)
    {

        //string bgcolor = string.Empty;
        if (options.Key == "col1width")
        {

            col1width = options.Value;

        }
        else if (options.Key == "col2width")
        {
            col2width = options.Value;
        }
        else if (options.Key == "backgroundcolor")
        {

            bgcolor = options.Value;

        }
        else if (options.Key == "padding")
        {
            padding = options.Value;
        }
        else if (options.Key == "imagewidth")
        {
            imgWidth = @options.Value;
        }
        else if (options.Key == "imageurl")
        {
            imgSrc = @options.Value;
        }
        else if (options.Key == "content1")
        {
            content1 = @options.Value;
        }
    }


    
    imgWidth = imgWidth + "%";
    col1width = col1width + "%";
    col2width = col2width + "%";


            
            #line default
            #line hidden
WriteLiteral(" <div");

WriteLiteral(" class=\"container\"");

WriteLiteral(" style=\"\"");

WriteLiteral(">\r\n     <div");

WriteLiteral(" id=\"\"");

WriteLiteral(" class=\"row\"");

WriteAttribute("style", Tuple.Create(" style=\"", 1653), Tuple.Create("\"", 1698)
, Tuple.Create(Tuple.Create("", 1661), Tuple.Create("padding:", 1661), true)
            
            #line 61 "..\..\Views\Widgets\TwoColumnLayoutWidget.cshtml"
, Tuple.Create(Tuple.Create("", 1669), Tuple.Create<System.Object, System.Int32>(padding
            
            #line default
            #line hidden
, 1669), false)
, Tuple.Create(Tuple.Create("", 1677), Tuple.Create(";background:", 1677), true)
            
            #line 61 "..\..\Views\Widgets\TwoColumnLayoutWidget.cshtml"
, Tuple.Create(Tuple.Create("", 1689), Tuple.Create<System.Object, System.Int32>(bgcolor
            
            #line default
            #line hidden
, 1689), false)
, Tuple.Create(Tuple.Create("", 1697), Tuple.Create(";", 1697), true)
);

WriteLiteral(">\r\n         <div");

WriteLiteral(" id=\"\"");

WriteAttribute("style", Tuple.Create(" style=\"", 1721), Tuple.Create("\"", 1745)
, Tuple.Create(Tuple.Create("", 1729), Tuple.Create("width:", 1729), true)
            
            #line 62 "..\..\Views\Widgets\TwoColumnLayoutWidget.cshtml"
, Tuple.Create(Tuple.Create("", 1735), Tuple.Create<System.Object, System.Int32>(col1width
            
            #line default
            #line hidden
, 1735), false)
);

WriteLiteral(">\r\n");

WriteLiteral("             ");

            
            #line 63 "..\..\Views\Widgets\TwoColumnLayoutWidget.cshtml"
        Write(Html.Raw(@content1));

            
            #line default
            #line hidden
WriteLiteral("\r\n             \r\n         </div>\r\n\r\n         <div");

WriteAttribute("style", Tuple.Create(" style=\"", 1831), Tuple.Create("\"", 1855)
, Tuple.Create(Tuple.Create("", 1839), Tuple.Create("width:", 1839), true)
            
            #line 67 "..\..\Views\Widgets\TwoColumnLayoutWidget.cshtml"
, Tuple.Create(Tuple.Create("", 1845), Tuple.Create<System.Object, System.Int32>(col2width
            
            #line default
            #line hidden
, 1845), false)
);

WriteLiteral(">\r\n             <div");

WriteLiteral(" id=\"\"");

WriteAttribute("style", Tuple.Create(" style=\"", 1882), Tuple.Create("\"", 1905)
, Tuple.Create(Tuple.Create("", 1890), Tuple.Create("width:", 1890), true)
            
            #line 68 "..\..\Views\Widgets\TwoColumnLayoutWidget.cshtml"
, Tuple.Create(Tuple.Create("", 1896), Tuple.Create<System.Object, System.Int32>(imgWidth
            
            #line default
            #line hidden
, 1896), false)
);

WriteLiteral(">\r\n                 <img");

WriteAttribute("src", Tuple.Create(" src=\"", 1930), Tuple.Create("\"", 1943)
            
            #line 69 "..\..\Views\Widgets\TwoColumnLayoutWidget.cshtml"
, Tuple.Create(Tuple.Create("", 1936), Tuple.Create<System.Object, System.Int32>(imgSrc
            
            #line default
            #line hidden
, 1936), false)
);

WriteLiteral(" />\r\n             </div>\r\n         </div>\r\n     </div>\r\n</div>\r\n");

            
            #line 74 "..\..\Views\Widgets\TwoColumnLayoutWidget.cshtml"

}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
