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
    
    #line 28 "..\..\Views\Shared\Partial\Paging.cshtml"
    using BetterCms.Module.Root.Content.Resources;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/Partial/Paging.cshtml")]
    public partial class _Views_Shared_Partial_Paging_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared_Partial_Paging_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("\r\n<!-- ko if: totalPages() > 0 -->\r\n<div");

WriteLiteral(" class=\"bcms-pager bcms-clearfix\"");

WriteLiteral(">\r\n    <span");

WriteLiteral(" class=\"bcms-pager-text\"");

WriteLiteral(">");

            
            #line 32 "..\..\Views\Shared\Partial\Paging.cshtml"
                             Write(RootGlobalization.Paging_Page_Title);

            
            #line default
            #line hidden
WriteLiteral(":</span>\r\n\r\n    <!-- ko if: pagingLowerBound() > 1 -->\r\n    <a");

WriteLiteral(" class=\"bcms-pager-no\"");

WriteLiteral(" data-page-number=\"1\"");

WriteLiteral(" data-bind=\"click: openPage.bind($data, 1)\"");

WriteLiteral(">1 </a>\r\n    <!-- ko if: pagingLowerBound() != 2 -->\r\n    <span");

WriteLiteral(" class=\"bcms-pager-text\"");

WriteLiteral(">...</span>\r\n    <!-- /ko-->\r\n    <!-- /ko-->\r\n\r\n    <!-- ko foreach: pages() -->" +
"\r\n    <!-- ko if: $data == $parent.pageNumber() -->\r\n    <a");

WriteLiteral(" class=\"bcms-pager-no bcms-active-pager\"");

WriteLiteral(" data-bind=\"html: $data\"");

WriteLiteral("></a>\r\n    <!-- /ko -->\r\n    <!-- ko ifnot: $data == $parent.pageNumber() -->\r\n  " +
"  <a");

WriteLiteral(" class=\"bcms-pager-no\"");

WriteLiteral(" data-bind=\"css: { \'bcms-active-pager\': $data == $parent.pageNumber() }, attr: { " +
"\'data-page-number\': $data }, html: $data, click: $parent.openPage.bind($parent, " +
"$data)\"");

WriteLiteral("></a>\r\n    <!-- /ko -->\r\n    <!-- ko if: $data != $parent.pageNumber() && $data =" +
"= $parent.pagingUpperBound() && $data <= $parent.totalPages() - 1  -->\r\n    <spa" +
"n");

WriteLiteral(" class=\"bcms-pager-text\"");

WriteLiteral(">...</span>\r\n    <!-- /ko -->\r\n    <!-- /ko -->\r\n\r\n    <!-- ko if: pagingUpperBou" +
"nd() < totalPages() -->\r\n    <a");

WriteLiteral(" class=\"bcms-pager-no\"");

WriteLiteral(" data-bind=\"attr: { \'data-page-number\': totalPages() }, html: totalPages(), click" +
": openPage.bind($data, totalPages())\"");

WriteLiteral("></a>\r\n    <!-- /ko -->\r\n\r\n    <!-- ko if: pageNumber() == totalPages() -->\r\n    " +
"<a");

WriteLiteral(" class=\"bcms-pager-next\"");

WriteLiteral(">");

            
            #line 58 "..\..\Views\Shared\Partial\Paging.cshtml"
                          Write(RootGlobalization.Button_Paging_Next);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n    <!-- /ko -->\r\n    <!-- ko ifnot: pageNumber() == totalPages() -->\r\n    " +
"<a");

WriteLiteral(" class=\"bcms-pager-next\"");

WriteLiteral(" data-bind=\"attr: { \'data-page-number\': pageNumber() + 1, href: \'#\' }, click: ope" +
"nPage.bind($data, pageNumber() + 1)\"");

WriteLiteral(">");

            
            #line 61 "..\..\Views\Shared\Partial\Paging.cshtml"
                                                                                                                                               Write(RootGlobalization.Button_Paging_Next);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n    <!-- /ko -->\r\n\r\n    <!-- ko if: pageNumber() == 1 -->\r\n    <a");

WriteLiteral(" class=\"bcms-pager-prev\"");

WriteLiteral(">");

            
            #line 65 "..\..\Views\Shared\Partial\Paging.cshtml"
                          Write(RootGlobalization.Button_Paging_Previous);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n    <!-- /ko -->\r\n    <!-- ko ifnot: pageNumber() == 1 -->\r\n    <a");

WriteLiteral(" class=\"bcms-pager-prev\"");

WriteLiteral(" data-bind=\"attr: { \'data-page-number\': pageNumber() - 1, href: \'#\' }, click: ope" +
"nPage.bind($data, pageNumber() - 1)\"");

WriteLiteral(">");

            
            #line 68 "..\..\Views\Shared\Partial\Paging.cshtml"
                                                                                                                                               Write(RootGlobalization.Button_Paging_Previous);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n    <!-- /ko -->\r\n</div>\r\n<!-- /ko -->\r\n");

        }
    }
}
#pragma warning restore 1591
