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
    
    #line 1 "..\..\Views\Widgets\Vinod_BannerWidget.cshtml"
    using BetterCms.Module.Root.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Widgets\Vinod_BannerWidget.cshtml"
    using BetterCms.Module.Root.ViewModels.Cms;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Widgets/Vinod_BannerWidget.cshtml")]
    public partial class _Views_Widgets_Vinod_BannerWidget_cshtml : System.Web.Mvc.WebViewPage<BetterCms.Module.Root.ViewModels.Cms.RenderWidgetViewModel>
    {
        public _Views_Widgets_Vinod_BannerWidget_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<link");

WriteLiteral(" href=\"/file/bcms-installation/Content/Styles/css/bootstrap.css\"");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" />\r\n\r\n<link");

WriteLiteral(" href=\"/file/bcms-installation/Content/Styles/cssStyles.css\"");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(@" />
<style>
    div#home_icon {
        position: absolute;
        display:block;
        top: 10%;
        left: 3.5%;
    }
    #home_icon a {
        font-family:OpenSans-Regular;
        font-size:12px;
    }

    #home_icon i {
        padding-right:6px;
        font-size:14px;
    }

    #home_icon a, #home_icon i {
        
       
        color:#11b3fe;
        cursor:pointer;
        text-transform:uppercase;
        text-decoration:none;
    }
    #home_icon p#page_title{
        font-family:OpenSans-SemiBold;
        font-size:30px;
        color:white;
        text-transform:uppercase;
        padding-top:7px;
    }
</style>

");

            
            #line 41 "..\..\Views\Widgets\Vinod_BannerWidget.cshtml"
 if (Model != null && Model.Options != null)
{
    string bannerImgUrl = null,Title = null;
    string guid = Guid.NewGuid().ToString();
    string objId = "myBanner" + guid;


    foreach (var options in Model.Options)
    {
        if (options.Key == "Title")
        {
            Title = options.Value;
        }
        if (options.Key == "bannerImgUrl")
        {
            bannerImgUrl = options.Value;
        }


    }


            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" style=\"position:relative;\"");

WriteLiteral(">\r\n        <div");

WriteAttribute("id", Tuple.Create(" id=\"", 1513), Tuple.Create("\"", 1524)
            
            #line 63 "..\..\Views\Widgets\Vinod_BannerWidget.cshtml"
, Tuple.Create(Tuple.Create("", 1518), Tuple.Create<System.Object, System.Int32>(objId
            
            #line default
            #line hidden
, 1518), false)
);

WriteLiteral(" class=\"main-content\"");

WriteLiteral(">\r\n            <img");

WriteAttribute("src", Tuple.Create(" src=\"", 1565), Tuple.Create("\"", 1584)
            
            #line 64 "..\..\Views\Widgets\Vinod_BannerWidget.cshtml"
, Tuple.Create(Tuple.Create("", 1571), Tuple.Create<System.Object, System.Int32>(bannerImgUrl
            
            #line default
            #line hidden
, 1571), false)
);

WriteLiteral("/>\r\n        </div>\r\n        <div");

WriteLiteral(" id=\"home_icon\"");

WriteLiteral(">\r\n            <span><a");

WriteLiteral(" href=\"/\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-home\"");

WriteLiteral("></i>Home</a></span>\r\n            <p");

WriteLiteral(" id=\"page_title\"");

WriteLiteral(">");

            
            #line 68 "..\..\Views\Widgets\Vinod_BannerWidget.cshtml"
                          Write(Title);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n");

            
            #line 71 "..\..\Views\Widgets\Vinod_BannerWidget.cshtml"

}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
