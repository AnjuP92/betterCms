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
    
    #line 2 "..\..\Views\Widgets\NewsPortfolio.cshtml"
    using BetterCms.Module.Root.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\Widgets\NewsPortfolio.cshtml"
    using BetterCms.Module.Root.ViewModels.Cms;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Widgets/NewsPortfolio.cshtml")]
    public partial class _Views_Widgets_NewsPortfolio_cshtml : System.Web.Mvc.WebViewPage<BetterCms.Module.Root.ViewModels.Cms.RenderWidgetViewModel>
    {
        public _Views_Widgets_NewsPortfolio_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("<link");

WriteLiteral(" href=\"/file/bcms-installation/Content/Styles/css/bootstrap.css\"");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" />\r\n<link");

WriteLiteral(" href=\"/file/bcms-installation/Content/Styles/css/colors.css\"");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" />\r\n<link");

WriteLiteral(" href=\"/file/bcms-installation/Content/Styles/css/style.css\"");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" />\r\n<link");

WriteLiteral(" href=\"/file/bcms-installation/Content/Styles/css/hover_pack.css\"");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" />\r\n<script");

WriteLiteral(" src=\"/file/bcms-installation/Scripts/Js/isotope.min.js\"");

WriteLiteral("></script>\r\n<link");

WriteLiteral(" href=\"/file/bcms-installation/Content/Styles/animate.css\"");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" />\r\n\r\n\r\n");

            
            #line 13 "..\..\Views\Widgets\NewsPortfolio.cshtml"
 if (Model != null && Model.Options != null)
{
    string guid = Guid.NewGuid().ToString();
    string objId = "newsportfolio" + guid;
    string headingText = null;
    string allButtonCaption = null, btn2_Button2Caption = null;
    string btn3_Button3Caption = null, btn4_Button4Caption = null, fontcolor = null, buttonCaption = null, leftContent=null;

    RenderWidgetViewModel.NewsportfolioRootObject robj = null;

    foreach (var options in Model.Options)
    {
        if (options.Key == "headingText")
        {
            headingText = options.Value;
        }
        else if (options.Key == "allButtonCaption")
        {
            allButtonCaption = options.Value;
        }
        else if (options.Key == "leftContent")
        {
            leftContent = @options.Value;
        }
        else if (options.Key == "jsonFile")
        {
            robj = RenderWidgetViewModel.jsSerial.Deserialize<RenderWidgetViewModel.NewsportfolioRootObject>(options.Value);
        }
    }



            
            #line default
            #line hidden
WriteLiteral("<!DOCTYPE html>\r\n");

            
            #line 45 "..\..\Views\Widgets\NewsPortfolio.cshtml"


            
            #line default
            #line hidden
WriteLiteral("<html>\r\n<head>\r\n    <meta");

WriteLiteral(" name=\"viewport\"");

WriteLiteral(" content=\"width=device-width\"");

WriteLiteral(" />\r\n    <title></title>\r\n</head>\r\n<body>\r\n    <div>\r\n        <section");

WriteAttribute("id", Tuple.Create(" id=\"", 1864), Tuple.Create("\"", 1875)
            
            #line 53 "..\..\Views\Widgets\NewsPortfolio.cshtml"
, Tuple.Create(Tuple.Create("", 1869), Tuple.Create<System.Object, System.Int32>(objId
            
            #line default
            #line hidden
, 1869), false)
);

WriteLiteral(" class=\"section-portfolio\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"container\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"fullwidth-post-wrapper col-lg-12\"");

WriteLiteral(">\r\n                    <div>\r\n\r\n");

WriteLiteral("                        ");

            
            #line 58 "..\..\Views\Widgets\NewsPortfolio.cshtml"
                   Write(Html.Raw(@headingText));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n                        ");

WriteLiteral("\r\n\r\n                    </div>\r\n                    <nav");

WriteLiteral(" class=\"portfolio-filter clearfix\"");

WriteLiteral(">\r\n                        <ul>\r\n                            <li><a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" class=\"btn btn-primary btn-sm\"");

WriteLiteral(" data-filter=\"*\"");

WriteLiteral(">");

            
            #line 74 "..\..\Views\Widgets\NewsPortfolio.cshtml"
                                                                                      Write(allButtonCaption);

            
            #line default
            #line hidden
WriteLiteral(" </a></li>\r\n                            ");

WriteLiteral("\r\n");

            
            #line 78 "..\..\Views\Widgets\NewsPortfolio.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 78 "..\..\Views\Widgets\NewsPortfolio.cshtml"
                             if (robj != null)
                            {
                                if (robj.newsportfolio_item != null && robj.newsportfolio_item.Count > 0)
                                {
                                    foreach (var opt in robj.newsportfolio_item)
                                    {

            
            #line default
            #line hidden
WriteLiteral("                                        <li><a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" class=\"btn btn-primary btn-sm\"");

WriteLiteral(" data-filter=\".");

            
            #line 84 "..\..\Views\Widgets\NewsPortfolio.cshtml"
                                                                                                Write(opt.filterclassname);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">");

            
            #line 84 "..\..\Views\Widgets\NewsPortfolio.cshtml"
                                                                                                                      Write(opt.filterbuttonname);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n");

            
            #line 85 "..\..\Views\Widgets\NewsPortfolio.cshtml"
                                    }
                                }
                            }

            
            #line default
            #line hidden
WriteLiteral("                        </ul>\r\n                    </nav>\r\n\r\n                    " +
"<div");

WriteLiteral(" class=\"row portfolio_wrapper clearfix\"");

WriteLiteral(">\r\n\r\n");

            
            #line 93 "..\..\Views\Widgets\NewsPortfolio.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 93 "..\..\Views\Widgets\NewsPortfolio.cshtml"
                         if (robj != null)
                        {
                            if (robj.newsportfolio_item != null && robj.newsportfolio_item.Count > 0)
                            {

                                foreach (var opt in robj.newsportfolio_item)
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    <div");

WriteAttribute("class", Tuple.Create(" class=\"", 4510), Tuple.Create("\"", 4580)
, Tuple.Create(Tuple.Create("", 4518), Tuple.Create("item", 4518), true)
, Tuple.Create(Tuple.Create(" ", 4522), Tuple.Create("col-lg-4", 4523), true)
, Tuple.Create(Tuple.Create(" ", 4531), Tuple.Create("col-md-4", 4532), true)
, Tuple.Create(Tuple.Create(" ", 4540), Tuple.Create("col-sm-6", 4541), true)
, Tuple.Create(Tuple.Create(" ", 4549), Tuple.Create("col-xs-12", 4550), true)
            
            #line 100 "..\..\Views\Widgets\NewsPortfolio.cshtml"
         , Tuple.Create(Tuple.Create(" ", 4559), Tuple.Create<System.Object, System.Int32>(opt.filterclassname
            
            #line default
            #line hidden
, 4560), false)
);

WriteLiteral(">\r\n                                        <div");

WriteLiteral(" class=\"b-link-flow b-animate-go clearfix\"");

WriteLiteral(" style=\"max-width: 336px;width: 90.7%;\"");

WriteLiteral(">\r\n                                            <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" class=\"b-link-fade b-animate-go\"");

WriteLiteral(">\r\n                                                <img");

WriteAttribute("src", Tuple.Create(" src=\"", 4855), Tuple.Create("\"", 4874)
            
            #line 103 "..\..\Views\Widgets\NewsPortfolio.cshtml"
, Tuple.Create(Tuple.Create("", 4861), Tuple.Create<System.Object, System.Int32>(opt.imageurl
            
            #line default
            #line hidden
, 4861), false)
);

WriteLiteral(" alt=\"\"");

WriteLiteral(">\r\n                                            </a>\r\n                            " +
"                <div");

WriteLiteral(" class=\"b-wrapper\"");

WriteLiteral(">\r\n                                                <h2");

WriteLiteral(" class=\"portfolio-title b-from-left b-animate b-delay02\"");

WriteLiteral(">");

            
            #line 106 "..\..\Views\Widgets\NewsPortfolio.cshtml"
                                                                                                       Write(opt.imagecaption);

            
            #line default
            #line hidden
WriteLiteral("</h2>\r\n                                            </div>\r\n\r\n                    " +
"                    </div>\r\n                                        <div");

WriteAttribute("style", Tuple.Create(" style=\"", 5282), Tuple.Create("\"", 5418)
, Tuple.Create(Tuple.Create("", 5290), Tuple.Create("max-width:336px;min-height:120px;width:90.7%;background-color:", 5290), true)
            
            #line 110 "..\..\Views\Widgets\NewsPortfolio.cshtml"
                                  , Tuple.Create(Tuple.Create("", 5352), Tuple.Create<System.Object, System.Int32>(opt.backgroundcolor
            
            #line default
            #line hidden
, 5352), false)
, Tuple.Create(Tuple.Create("", 5372), Tuple.Create(";padding:10px;color:white;padding-bottom:30px;", 5372), true)
);

WriteLiteral(">");

            
            #line 110 "..\..\Views\Widgets\NewsPortfolio.cshtml"
                                                                                                                                                                                 Write(opt.imagedescrip);

            
            #line default
            #line hidden
WriteLiteral("</div>\t<!-- animate -->\r\n                                    </div>");

WriteLiteral("<!-- item -->\r\n");

            
            #line 112 "..\..\Views\Widgets\NewsPortfolio.cshtml"
                                }
                            }
                        }


                        
            
            #line default
            #line hidden
            
            #line 156 "..\..\Views\Widgets\NewsPortfolio.cshtml"
                                
            
            #line default
            #line hidden
WriteLiteral(@"<!-- item -->

                    </div><!-- end portfolio_wrapper -->


                </div><!-- fullwidth-post-wrapper -->
            </div><!-- end container -->
        </section>
        <script>
	// Portfolio
	(function($) {
		""use strict"";
		var $container = $('#");

            
            #line 168 "..\..\Views\Widgets\NewsPortfolio.cshtml"
                        Write(objId);

            
            #line default
            #line hidden
WriteLiteral(@"').find('.portfolio_wrapper'),
			$items = $container.find('.item'),
			portfolioLayout = 'fitRows';

			if( $container.hasClass('portfolio-centered') ) {
				portfolioLayout = 'masonry';
			}

			$container.isotope({
				filter: '*',
				animationEngine: 'best-available',
				layoutMode: portfolioLayout,
				animationOptions: {
				duration: 750,
				easing: 'linear',
				queue: false
			},
			masonry: {
			}
			}, refreshWaypoints());

			function refreshWaypoints() {
				setTimeout(function() {
				}, 1000);
			}

			$('#");

            
            #line 194 "..\..\Views\Widgets\NewsPortfolio.cshtml"
           Write(objId);

            
            #line default
            #line hidden
WriteLiteral("\').find(\'nav.portfolio-filter ul a\').on(\'click\', function() {\r\n\t\t\t\t\tvar selector " +
"= $(this).attr(\'data-filter\');\r\n\t\t\t\t\t$container.isotope({ filter: selector }, re" +
"freshWaypoints());\r\n\t\t\t\t\t$(\'#");

            
            #line 197 "..\..\Views\Widgets\NewsPortfolio.cshtml"
                   Write(objId);

            
            #line default
            #line hidden
WriteLiteral(@"').find('nav.portfolio-filter ul a').removeClass('active');
					$(this).addClass('active');
					return false;
			});


			function setPortfolio() {
				setColumns();
				$container.isotope('reLayout');
			}

			$container.imagesLoaded(function () {
				setPortfolio();
			});

			$(window).on('resize', function () {
			setPortfolio();
		});
	})(jQuery);
        </script>
    </div>
</body>
</html>
");

            
            #line 220 "..\..\Views\Widgets\NewsPortfolio.cshtml"

}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
