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
    
    #line 1 "..\..\Views\Widgets\SlickSlider.cshtml"
    using BetterCms.Module.Root.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Widgets\SlickSlider.cshtml"
    using BetterCms.Module.Root.ViewModels.Cms;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Widgets/SlickSlider.cshtml")]
    public partial class _Views_Widgets_SlickSlider_cshtml : System.Web.Mvc.WebViewPage<BetterCms.Module.Root.ViewModels.Cms.RenderWidgetViewModel>
    {
        public _Views_Widgets_SlickSlider_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<link");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" href=\"/file/bcms-installation/Content/Styles/SlickSlider.css\"");

WriteLiteral(">\r\n\r\n");

            
            #line 7 "..\..\Views\Widgets\SlickSlider.cshtml"
 if (Model != null && Model.Options != null)
{
    string guidSlickSliderStr = "";
    RenderWidgetViewModel.SlickSliderRootObject robj = null;
    string img = string.Empty;
    string name = string.Empty;
    string position = string.Empty;
    string content = string.Empty;
    int slidesToShowSS = 3;
    int slidesToScrollSS = 1;
    string sliderWidthSS = "100%";
    foreach (var options in Model.Options)
    {
        if (options.Key == "jsonFile")
        {
            robj = RenderWidgetViewModel.jsSerial.Deserialize<RenderWidgetViewModel.SlickSliderRootObject>(options.Value);
        }
        else if (options.Key == "slidesToShow")
        {

            
            #line default
            #line hidden
WriteLiteral("            <script>\r\n                var slidesToShow1 = \'");

            
            #line 27 "..\..\Views\Widgets\SlickSlider.cshtml"
                                Write(options.Value);

            
            #line default
            #line hidden
WriteLiteral("\';\r\n            </script>\r\n");

            
            #line 29 "..\..\Views\Widgets\SlickSlider.cshtml"
            slidesToShowSS = int.Parse(options.Value);
        }
        else if (options.Key == "slidesToScroll")
        {

            
            #line default
            #line hidden
WriteLiteral("            <script>\r\n                var slidesToScroll1 = \'");

            
            #line 34 "..\..\Views\Widgets\SlickSlider.cshtml"
                                  Write(options.Value);

            
            #line default
            #line hidden
WriteLiteral("\';\r\n            </script>\r\n");

            
            #line 36 "..\..\Views\Widgets\SlickSlider.cshtml"
            slidesToScrollSS = int.Parse(options.Value);
        }
        else if (options.Key == "sliderWidth")
        {

            
            #line default
            #line hidden
WriteLiteral("            <script>\r\n                var sliderWidth = \'");

            
            #line 41 "..\..\Views\Widgets\SlickSlider.cshtml"
                              Write(options.Value);

            
            #line default
            #line hidden
WriteLiteral("\';\r\n            </script>\r\n");

            
            #line 43 "..\..\Views\Widgets\SlickSlider.cshtml"
            sliderWidthSS = options.Value + "px";
        }

        if (slidesToScrollSS > slidesToShowSS)
        {
            slidesToScrollSS = slidesToShowSS;
        }
    }

    if (robj != null)
    {
        if (robj.Details != null && robj.Details.Count > 0)
        {
            guidSlickSliderStr = Guid.NewGuid().ToString();
            
            
            #line default
            #line hidden
            
            #line 59 "..\..\Views\Widgets\SlickSlider.cshtml"
                       

            
            #line default
            #line hidden
WriteLiteral("            <section");

WriteLiteral(" id=\"features\"");

WriteLiteral(" class=\"blue\"");

WriteLiteral(" style=\"margin-top:10px;\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"content\"");

WriteLiteral(">\r\n                    <div");

WriteAttribute("class", Tuple.Create(" class=\"", 2082), Tuple.Create("\"", 2127)
, Tuple.Create(Tuple.Create("", 2090), Tuple.Create("slider", 2090), true)
, Tuple.Create(Tuple.Create(" ", 2096), Tuple.Create("responsive", 2097), true)
            
            #line 62 "..\..\Views\Widgets\SlickSlider.cshtml"
, Tuple.Create(Tuple.Create(" ", 2107), Tuple.Create<System.Object, System.Int32>(guidSlickSliderStr
            
            #line default
            #line hidden
, 2108), false)
);

WriteAttribute("style", Tuple.Create(" style=\"", 2128), Tuple.Create("\"", 2170)
, Tuple.Create(Tuple.Create("", 2136), Tuple.Create("width:", 2136), true)
            
            #line 62 "..\..\Views\Widgets\SlickSlider.cshtml"
    , Tuple.Create(Tuple.Create("", 2142), Tuple.Create<System.Object, System.Int32>(sliderWidthSS
            
            #line default
            #line hidden
, 2142), false)
, Tuple.Create(Tuple.Create("", 2156), Tuple.Create(";", 2156), true)
, Tuple.Create(Tuple.Create(" ", 2157), Tuple.Create("margin:auto;", 2158), true)
);

WriteLiteral(">\r\n");

            
            #line 63 "..\..\Views\Widgets\SlickSlider.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 63 "..\..\Views\Widgets\SlickSlider.cshtml"
                         foreach (var opt in robj.Details)
                        {
                            img = opt.Image;
                            name = opt.Name;
                            position = opt.Position;
                            content = opt.Content;

            
            #line default
            #line hidden
WriteLiteral("                            <div");

WriteLiteral(" style=\"margin-left:10px;\"");

WriteLiteral(">\r\n                                <img");

WriteAttribute("src", Tuple.Create(" src=\"", 2556), Tuple.Create("\"", 2566)
            
            #line 70 "..\..\Views\Widgets\SlickSlider.cshtml"
, Tuple.Create(Tuple.Create("", 2562), Tuple.Create<System.Object, System.Int32>(img
            
            #line default
            #line hidden
, 2562), false)
);

WriteLiteral(" style=\"width:50% !important\"");

WriteLiteral(" />\r\n                                <div");

WriteLiteral(" class=\"our-team-content-box\"");

WriteLiteral(">\r\n                                    <h5");

WriteLiteral(" class=\"bold\"");

WriteLiteral(">");

            
            #line 72 "..\..\Views\Widgets\SlickSlider.cshtml"
                                                Write(name);

            
            #line default
            #line hidden
WriteLiteral("</h5>\r\n                                    <span");

WriteLiteral(" class=\"position\"");

WriteLiteral(">");

            
            #line 73 "..\..\Views\Widgets\SlickSlider.cshtml"
                                                      Write(position);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                                    <hr");

WriteLiteral(" class=\"divider-color\"");

WriteLiteral(" />\r\n                                    <p");

WriteLiteral(" class=\"para\"");

WriteLiteral(">\r\n");

WriteLiteral("                                        ");

            
            #line 76 "..\..\Views\Widgets\SlickSlider.cshtml"
                                   Write(content);

            
            #line default
            #line hidden
WriteLiteral("\r\n                                    </p>\r\n                                </div" +
">\r\n                            </div>\r\n");

            
            #line 80 "..\..\Views\Widgets\SlickSlider.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </div>\r\n            </section>\r\n");

            
            #line 83 "..\..\Views\Widgets\SlickSlider.cshtml"
        }
    }

            
            #line default
            #line hidden
WriteLiteral(@"    <style>
        img {
            width: 50%;
        }

        .bold {
            font-size: 1.2em;
            color: #000000;
        }

        .position {
            font-size: 1em;
            color: #000000;
        }

        hr {
            border-color: #dddddd;
        }

        .para {
            color: black;
        }

        .blue {
            background-color: #ffffff;
        }
    </style>
");

            
            #line 112 "..\..\Views\Widgets\SlickSlider.cshtml"


            
            #line default
            #line hidden
WriteLiteral("    <script");

WriteLiteral(" src=\"http://code.jquery.com/jquery-2.1.4.min.js\"");

WriteLiteral("></script>\r\n");

WriteLiteral("                    <script");

WriteLiteral(" src=\"//cdnjs.cloudflare.com/ajax/libs/slick-carousel/1.5.8/slick.min.js\"");

WriteLiteral("></script>\r\n");

WriteLiteral(@"                    <script>
                        var slidesToShow=3;
                        var slidesToScroll=1;
                        $(document).ready(function () {
                            if (typeof slidesToShow1!='undefined')
                                slidesToShow = parseInt(slidesToShow1);
                            if (typeof slidesToScroll1 != 'undefined')
                                slidesToScroll = parseInt(slidesToScroll1);
                            if (slidesToScroll > slidesToShow)
                                slidesToScroll = slidesToShow;

                            //$('.responsive').slick({
                            //$('.' + guidSlickSlider).slick({
                            $('.");

            
            #line 128 "..\..\Views\Widgets\SlickSlider.cshtml"
                           Write(guidSlickSliderStr);

            
            #line default
            #line hidden
WriteLiteral(@"').slick({
                                // dots: true,
                                infinite: true,
                                speed: 300,
                                //slidesToShow: slidesToShow,
                                //slidesToScroll: slidesToScroll,
                                slidesToShow: ");

            
            #line 134 "..\..\Views\Widgets\SlickSlider.cshtml"
                                         Write(slidesToShowSS);

            
            #line default
            #line hidden
WriteLiteral(",\r\n                                slidesToScroll: ");

            
            #line 135 "..\..\Views\Widgets\SlickSlider.cshtml"
                                           Write(slidesToScrollSS);

            
            #line default
            #line hidden
WriteLiteral(@",
                                responsive: [{
                                    breakpoint: 1024,
                                    settings: {
                                        //slidesToShow: slidesToShow,
                                        //slidesToScroll: slidesToScroll,
                                        slidesToShow: ");

            
            #line 141 "..\..\Views\Widgets\SlickSlider.cshtml"
                                                 Write(slidesToShowSS);

            
            #line default
            #line hidden
WriteLiteral(",\r\n                                        slidesToScroll: ");

            
            #line 142 "..\..\Views\Widgets\SlickSlider.cshtml"
                                                   Write(slidesToScrollSS);

            
            #line default
            #line hidden
WriteLiteral(@",
                                        // centerMode: true,

                                    }

                                }, {
                                    breakpoint: 800,
                                    settings: {
                                        //slidesToShow: slidesToShow,
                                        //slidesToScroll: slidesToScroll,
                                        slidesToShow: ");

            
            #line 152 "..\..\Views\Widgets\SlickSlider.cshtml"
                                                 Write(slidesToShowSS);

            
            #line default
            #line hidden
WriteLiteral(",\r\n                                        slidesToScroll: ");

            
            #line 153 "..\..\Views\Widgets\SlickSlider.cshtml"
                                                   Write(slidesToScrollSS);

            
            #line default
            #line hidden
WriteLiteral(@",
                                        //dots: true,
                                        infinite: true,

                                    }


                                }, {
                                    breakpoint: 600,
                                    settings: {
                                        //slidesToShow: slidesToShow,
                                        //slidesToScroll: slidesToScroll,
                                        slidesToShow: ");

            
            #line 165 "..\..\Views\Widgets\SlickSlider.cshtml"
                                                 Write(slidesToShowSS);

            
            #line default
            #line hidden
WriteLiteral(",\r\n                                        slidesToScroll: ");

            
            #line 166 "..\..\Views\Widgets\SlickSlider.cshtml"
                                                   Write(slidesToScrollSS);

            
            #line default
            #line hidden
WriteLiteral(@",
                                        //dots: true,
                                        infinite: true,
                                        autoplay: true,

                                    }
                                }, {
                                    breakpoint: 480,
                                    settings: {
                                        //slidesToShow: slidesToShow,
                                        //slidesToScroll: slidesToScroll,
                                        slidesToShow: ");

            
            #line 177 "..\..\Views\Widgets\SlickSlider.cshtml"
                                                 Write(slidesToShowSS);

            
            #line default
            #line hidden
WriteLiteral(",\r\n                                        slidesToScroll: ");

            
            #line 178 "..\..\Views\Widgets\SlickSlider.cshtml"
                                                   Write(slidesToScrollSS);

            
            #line default
            #line hidden
WriteLiteral(@",
                                        // dots: true,
                                        infinite: true,
                                        autoplay: true,
                                        autoplaySpeed: 2000,
                                    }
                                },
                                 {
                                     breakpoint: 278,
                                     settings: {
                                         //slidesToShow: slidesToShow,
                                         //slidesToScroll: slidesToScroll,
                                         slidesToShow: ");

            
            #line 190 "..\..\Views\Widgets\SlickSlider.cshtml"
                                                  Write(slidesToShowSS);

            
            #line default
            #line hidden
WriteLiteral(",\r\n                                         slidesToScroll: ");

            
            #line 191 "..\..\Views\Widgets\SlickSlider.cshtml"
                                                    Write(slidesToScrollSS);

            
            #line default
            #line hidden
WriteLiteral(@",
                                         // dots: true,
                                         infinite: true,
                                         autoplay: true,
                                         autoplaySpeed: 2000,
                                     }
                                 }]
                            });
                            //if (typeof sliderWidth != 'undefined')
                            //$('.slick-slider').css('width', parseInt(sliderWidth) + 'px');
                            ");

WriteLiteral("\r\n\r\n                        });\r\n                    </script>\r\n");

            
            #line 206 "..\..\Views\Widgets\SlickSlider.cshtml"
}



                    
            
            #line default
            #line hidden
            
            #line 210 "..\..\Views\Widgets\SlickSlider.cshtml"
                                                                                                 
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
