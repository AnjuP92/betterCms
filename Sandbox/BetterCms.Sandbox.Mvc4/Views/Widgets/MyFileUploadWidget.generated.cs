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
    
    #line 28 "..\..\Views\Widgets\MyFileUploadWidget.cshtml"
    using Microsoft.Web.Mvc;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Widgets/MyFileUploadWidget.cshtml")]
    public partial class _Views_Widgets_MyFileUploadWidget_cshtml : System.Web.Mvc.WebViewPage<BetterCms.Sandbox.Mvc4.Models.MyFileUploadViewModel>
    {
        public _Views_Widgets_MyFileUploadWidget_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n");

WriteLiteral("\n");

            
            #line 32 "..\..\Views\Widgets\MyFileUploadWidget.cshtml"
 using (Html.BeginForm("MyFileUploadWidget_Upload", "WidgetsController", FormMethod.Post, new { id = "upload_form", enctype = "multipart/form-data" }))
{

            
            #line default
            #line hidden
WriteLiteral("    <div>\n        <label");

WriteLiteral(" for=\"MyFile\"");

WriteLiteral(">MyFile:</label>\n        <input");

WriteLiteral(" type=\"file\"");

WriteLiteral(" name=\"MyFile\"");

WriteLiteral(" id=\"MyFile\"");

WriteLiteral(" />\n        <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" name=\"Name\"");

WriteLiteral(" value=\"test\"");

WriteLiteral(" />\n    </div>\n");

            
            #line 39 "..\..\Views\Widgets\MyFileUploadWidget.cshtml"
    
            
            #line default
            #line hidden
            
            #line 39 "..\..\Views\Widgets\MyFileUploadWidget.cshtml"
Write(Html.SubmitButton("submit", "submit", new { id = "submit_button" }));

            
            #line default
            #line hidden
            
            #line 39 "..\..\Views\Widgets\MyFileUploadWidget.cshtml"
                                                                        ;
}

            
            #line default
            #line hidden
WriteLiteral("<script");

WriteLiteral(" src=\"http://code.jquery.com/jquery-latest.min.js\"");

WriteLiteral("></script>\n<script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(@">

    $(""#upload_form"").submit(function (e) {
        e.preventDefault();

        var formData = new FormData();
        formData.append(""Name"", ""anything"");
        formData.append(""MyFile"", $('input[type=file]')[0].files[0]);
        $.ajax({
            url: ""../Widgets/MyFileUploadWidget_Upload"",
            type: ""POST"",
            data: formData,
            enctype: 'multipart/form_data',
            processData: false,
            contentType: false,
            success: function(r) {
                    alert(r);
                }
            }
        );
    });
</script>");

        }
    }
}
#pragma warning restore 1591
