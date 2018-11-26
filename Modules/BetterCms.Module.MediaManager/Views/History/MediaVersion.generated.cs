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
    
    #line 28 "..\..\Views\History\MediaVersion.cshtml"
    using BetterCms.Module.MediaManager.ViewModels.History;
    
    #line default
    #line hidden
    
    #line 29 "..\..\Views\History\MediaVersion.cshtml"
    using BetterCms.Module.Root.Mvc.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/History/MediaVersion.cshtml")]
    public partial class _Views_History_MediaVersion_cshtml : System.Web.Mvc.WebViewPage<MediaPreviewViewModel>
    {

#line 33 "..\..\Views\History\MediaVersion.cshtml"
public System.Web.WebPages.HelperResult RenderProperty(MediaPreviewPropertyViewModel property) {
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 33 "..\..\Views\History\MediaVersion.cshtml"
                                                                
    var value = property.Value;
    if (!string.IsNullOrEmpty(value) && value.Length > 500)
    {
        value = value.Substring(0, 497) + "...";
    }
    


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <div");

WriteLiteralTo(__razor_helper_writer, " class=\"bcms-file-info-text\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n");


#line 41 "..\..\Views\History\MediaVersion.cshtml"
        

#line default
#line hidden

#line 41 "..\..\Views\History\MediaVersion.cshtml"
         if (property.IsImageUrl)
        {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <div");

WriteLiteralTo(__razor_helper_writer, " class=\"bcms-media-history-image-holder\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n                <img");

WriteAttributeTo(__razor_helper_writer, "src", Tuple.Create(" src=\"", 1848), Tuple.Create("\"", 1869)

#line 44 "..\..\Views\History\MediaVersion.cshtml"
, Tuple.Create(Tuple.Create("", 1854), Tuple.Create<System.Object, System.Int32>(property.Value

#line default
#line hidden
, 1854), false)
);

WriteAttributeTo(__razor_helper_writer, "alt", Tuple.Create(" alt=\"", 1870), Tuple.Create("\"", 1891)

#line 44 "..\..\Views\History\MediaVersion.cshtml"
, Tuple.Create(Tuple.Create("", 1876), Tuple.Create<System.Object, System.Int32>(property.Title

#line default
#line hidden
, 1876), false)
);

WriteLiteralTo(__razor_helper_writer, " />\r\n            </div>\r\n");


#line 46 "..\..\Views\History\MediaVersion.cshtml"
        }
        else if (property.IsUrl)
        {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <a");

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 1987), Tuple.Create("\"", 2009)

#line 49 "..\..\Views\History\MediaVersion.cshtml"
, Tuple.Create(Tuple.Create("", 1994), Tuple.Create<System.Object, System.Int32>(property.Value

#line default
#line hidden
, 1994), false)
);

WriteLiteralTo(__razor_helper_writer, " target=\"_blank\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 49 "..\..\Views\History\MediaVersion.cshtml"
                        WriteTo(__razor_helper_writer, property.Title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</a>\r\n");


#line 50 "..\..\Views\History\MediaVersion.cshtml"
        }
        else
        {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <b>");


#line 53 "..\..\Views\History\MediaVersion.cshtml"
WriteTo(__razor_helper_writer, property.Title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, ": </b>");


#line 53 "..\..\Views\History\MediaVersion.cshtml"
                                    

#line default
#line hidden

#line 53 "..\..\Views\History\MediaVersion.cshtml"
      WriteTo(__razor_helper_writer, value);


#line default
#line hidden

#line 53 "..\..\Views\History\MediaVersion.cshtml"
                                          
        }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    </div>\r\n");


#line 56 "..\..\Views\History\MediaVersion.cshtml"


#line default
#line hidden
});

#line 56 "..\..\Views\History\MediaVersion.cshtml"
}
#line default
#line hidden

        public _Views_History_MediaVersion_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n<div");

WriteLiteral(" class=\"bcms-media-history-holder\"");

WriteLiteral(">\r\n");

WriteLiteral("    ");

            
            #line 59 "..\..\Views\History\MediaVersion.cshtml"
Write(Html.MessagesBox());

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 61 "..\..\Views\History\MediaVersion.cshtml"
    
            
            #line default
            #line hidden
            
            #line 61 "..\..\Views\History\MediaVersion.cshtml"
     if (Model != null)
    {
        foreach (var property in Model.Properties)
        {
            
            
            #line default
            #line hidden
            
            #line 65 "..\..\Views\History\MediaVersion.cshtml"
       Write(RenderProperty(property));

            
            #line default
            #line hidden
            
            #line 65 "..\..\Views\History\MediaVersion.cshtml"
                                     
        }
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n\r\n");

        }
    }
}
#pragma warning restore 1591