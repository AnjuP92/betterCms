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
    
    #line 28 "..\..\Views\History\MediaHistory.cshtml"
    using BetterCms.Module.MediaManager.Command.History.GetMediaHistory;
    
    #line default
    #line hidden
    
    #line 29 "..\..\Views\History\MediaHistory.cshtml"
    using BetterCms.Module.MediaManager.Content.Resources;
    
    #line default
    #line hidden
    
    #line 30 "..\..\Views\History\MediaHistory.cshtml"
    using BetterCms.Module.MediaManager.Controllers;
    
    #line default
    #line hidden
    
    #line 31 "..\..\Views\History\MediaHistory.cshtml"
    using BetterCms.Module.MediaManager.Models.Enum;
    
    #line default
    #line hidden
    
    #line 32 "..\..\Views\History\MediaHistory.cshtml"
    using BetterCms.Module.MediaManager.ViewModels.History;
    
    #line default
    #line hidden
    
    #line 33 "..\..\Views\History\MediaHistory.cshtml"
    using BetterCms.Module.Root.Content.Resources;
    
    #line default
    #line hidden
    
    #line 34 "..\..\Views\History\MediaHistory.cshtml"
    using BetterCms.Module.Root.Mvc;
    
    #line default
    #line hidden
    
    #line 35 "..\..\Views\History\MediaHistory.cshtml"
    using BetterCms.Module.Root.Mvc.Grids.Extensions;
    
    #line default
    #line hidden
    
    #line 36 "..\..\Views\History\MediaHistory.cshtml"
    using BetterCms.Module.Root.Mvc.Grids.TableRenderers;
    
    #line default
    #line hidden
    
    #line 37 "..\..\Views\History\MediaHistory.cshtml"
    using BetterCms.Module.Root.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 38 "..\..\Views\History\MediaHistory.cshtml"
    using Microsoft.Web.Mvc;
    
    #line default
    #line hidden
    
    #line 39 "..\..\Views\History\MediaHistory.cshtml"
    using MvcContrib.UI.Grid;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/History/MediaHistory.cshtml")]
    public partial class _Views_History_MediaHistory_cshtml : System.Web.Mvc.WebViewPage<MediaHistoryViewModel>
    {

#line 43 "..\..\Views\History\MediaHistory.cshtml"
public System.Web.WebPages.HelperResult PreviewLink(MediaHistoryItem item)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 44 "..\..\Views\History\MediaHistory.cshtml"
 


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <div");

WriteLiteralTo(__razor_helper_writer, " class=\"bcms-action-usage bcms-js-preview\"");

WriteAttributeTo(__razor_helper_writer, "title", Tuple.Create(" title=\"", 2007), Tuple.Create("\"", 2048)

#line 45 "..\..\Views\History\MediaHistory.cshtml"
, Tuple.Create(Tuple.Create("", 2015), Tuple.Create<System.Object, System.Int32>(RootGlobalization.Button_Preview

#line default
#line hidden
, 2015), false)
);

WriteLiteralTo(__razor_helper_writer, " data-id=\"");


#line 45 "..\..\Views\History\MediaHistory.cshtml"
                                                                        WriteTo(__razor_helper_writer, item.Id);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 45 "..\..\Views\History\MediaHistory.cshtml"
                                                                                  WriteTo(__razor_helper_writer, RootGlobalization.Button_Preview);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</div>\r\n");


#line 46 "..\..\Views\History\MediaHistory.cshtml"


#line default
#line hidden
});

#line 46 "..\..\Views\History\MediaHistory.cshtml"
}
#line default
#line hidden

#line 48 "..\..\Views\History\MediaHistory.cshtml"
public System.Web.WebPages.HelperResult DownloadLink(MediaHistoryItem item)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 49 "..\..\Views\History\MediaHistory.cshtml"
 


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <div");

WriteLiteralTo(__razor_helper_writer, " class=\"bcms-action-download bcms-js-download\"");

WriteAttributeTo(__razor_helper_writer, "title", Tuple.Create(" title=\"", 2217), Tuple.Create("\"", 2272)

#line 50 "..\..\Views\History\MediaHistory.cshtml"
, Tuple.Create(Tuple.Create("", 2225), Tuple.Create<System.Object, System.Int32>(MediaGlobalization.MediaManager_ButtonDownload

#line default
#line hidden
, 2225), false)
);

WriteLiteralTo(__razor_helper_writer, " data-id=\"");


#line 50 "..\..\Views\History\MediaHistory.cshtml"
                                                                                          WriteTo(__razor_helper_writer, item.Id);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\"");

WriteLiteralTo(__razor_helper_writer, " data-version=\"");


#line 50 "..\..\Views\History\MediaHistory.cshtml"
                                                                                                                  WriteTo(__razor_helper_writer, item.Version);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 50 "..\..\Views\History\MediaHistory.cshtml"
                                                                                                                                 WriteTo(__razor_helper_writer, MediaGlobalization.MediaManager_ButtonDownload);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</div>\r\n");


#line 51 "..\..\Views\History\MediaHistory.cshtml"


#line default
#line hidden
});

#line 51 "..\..\Views\History\MediaHistory.cshtml"
}
#line default
#line hidden

#line 53 "..\..\Views\History\MediaHistory.cshtml"
public System.Web.WebPages.HelperResult RestoreLink(MediaHistoryItem item)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 54 "..\..\Views\History\MediaHistory.cshtml"
 
    if (item.CanCurrentUserRestoreIt)
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <div");

WriteLiteralTo(__razor_helper_writer, " class=\"bcms-action-restore bcms-js-restore\"");

WriteAttributeTo(__razor_helper_writer, "title", Tuple.Create(" title=\"", 2531), Tuple.Create("\"", 2572)

#line 57 "..\..\Views\History\MediaHistory.cshtml"
, Tuple.Create(Tuple.Create("", 2539), Tuple.Create<System.Object, System.Int32>(RootGlobalization.Button_Restore

#line default
#line hidden
, 2539), false)
);

WriteLiteralTo(__razor_helper_writer, " data-id=\"");


#line 57 "..\..\Views\History\MediaHistory.cshtml"
                                                                              WriteTo(__razor_helper_writer, item.Id);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\"");

WriteLiteralTo(__razor_helper_writer, " data-version=\"");


#line 57 "..\..\Views\History\MediaHistory.cshtml"
                                                                                                      WriteTo(__razor_helper_writer, item.Version);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 57 "..\..\Views\History\MediaHistory.cshtml"
                                                                                                                     WriteTo(__razor_helper_writer, RootGlobalization.Button_Restore);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</div>\r\n");


#line 58 "..\..\Views\History\MediaHistory.cshtml"
    }
    else
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        ");

WriteLiteralTo(__razor_helper_writer, "&nbsp;\r\n");


#line 62 "..\..\Views\History\MediaHistory.cshtml"
    }


#line default
#line hidden
});

#line 63 "..\..\Views\History\MediaHistory.cshtml"
}
#line default
#line hidden

#line 65 "..\..\Views\History\MediaHistory.cshtml"
public System.Web.WebPages.HelperResult DisplayStatus(string statusName, MediaHistoryStatus status)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 66 "..\..\Views\History\MediaHistory.cshtml"
 
    switch (status)
    {
        case MediaHistoryStatus.Archived:


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            ");

WriteLiteralTo(__razor_helper_writer, "<div class=\"bcms-archived-state\">");


#line 70 "..\..\Views\History\MediaHistory.cshtml"
                 WriteTo(__razor_helper_writer, statusName);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</div>\r\n");


#line 71 "..\..\Views\History\MediaHistory.cshtml"

            break;

        case MediaHistoryStatus.Active:


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        ");

WriteLiteralTo(__razor_helper_writer, "<div class=\"bcms-published-state\">");


#line 75 "..\..\Views\History\MediaHistory.cshtml"
              WriteTo(__razor_helper_writer, statusName);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</div>\r\n");


#line 76 "..\..\Views\History\MediaHistory.cshtml"


            break;

        default:


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        ");

WriteLiteralTo(__razor_helper_writer, "statusName\r\n");


#line 82 "..\..\Views\History\MediaHistory.cshtml"
            break;
    }


#line default
#line hidden
});

#line 84 "..\..\Views\History\MediaHistory.cshtml"
}
#line default
#line hidden

        public _Views_History_MediaHistory_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

            
            #line 86 "..\..\Views\History\MediaHistory.cshtml"
  
    Action<ColumnBuilder<MediaHistoryItem>> columns = column =>
    {
        column.For(f => PreviewLink(f))
               .Encode(false)
               .Named("&nbsp;")
               .Sortable(false)
               .HeaderAttributes(@style => "width: 40px; padding: 0;", @class => "bcms-tables-nohover");

        column.For(m => m.PublishedOn.ToFormattedDateString())
               .Named(MediaGlobalization.MediaHistory_Column_PublishedOn)
               .SortColumnName("PublishedOn")
               .HeaderAttributes(@style => "width: 130px;");

        column.For(m => m.PublishedByUser)
               .Named(MediaGlobalization.MediaHistory_Column_PublishedByUser)
               .SortColumnName("PublishedByUser");

        column.For(m => m.ArchivedOn.ToFormattedDateString())
               .Named(MediaGlobalization.MediaHistory_Column_ArchivedOn)
               .SortColumnName("ArchivedOn")
               .HeaderAttributes(@style => "width: 130px;");

        column.For(m => m.DisplayedFor.ToFormatedTimeString())
               .Named(MediaGlobalization.MediaHistory_Column_DisplayedFor)
               .SortColumnName("DisplayedFor")
               .HeaderAttributes(@style => "width: 130px;");

        column.For(m => DisplayStatus(m.StatusName, m.Status))
               .Named(MediaGlobalization.MediaHistory_Column_Status)
               .SortColumnName("StatusName")
               .Encode(false)
               .HeaderAttributes(@style => "width: 95px;");

        column.For(f => DownloadLink(f))
               .Encode(false)
               .Named("&nbsp;")
               .Sortable(false)
               .HeaderAttributes(@style => "width:40px; padding: 0;", @class => "bcms-tables-nohover");

        column.For(f => RestoreLink(f))
               .Encode(false)
               .Named("&nbsp;")
               .Sortable(false)
               .HeaderAttributes(@style => "width: 40px; padding: 0;", @class => "bcms-tables-nohover");
    };

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 134 "..\..\Views\History\MediaHistory.cshtml"
Write(Html.MessagesBox());

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"bcms-modal-frame-holder\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"bcms-history-preview-holder bcms-history-preview-holder-media\"");

WriteLiteral(" id=\"bcms-history-preview\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"bcms-history-info\"");

WriteLiteral(" style=\"display: block;\"");

WriteLiteral(">");

            
            #line 137 "..\..\Views\History\MediaHistory.cshtml"
                                                          Write(MediaGlobalization.MediaHistory_SelectVersionToPreviewMessage);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n        ");

WriteLiteral("\r\n    </div>\r\n\r\n    <div");

WriteLiteral(" class=\"bcms-history-table-holder\"");

WriteLiteral(">\r\n");

            
            #line 142 "..\..\Views\History\MediaHistory.cshtml"
        
            
            #line default
            #line hidden
            
            #line 142 "..\..\Views\History\MediaHistory.cshtml"
         using (Html.BeginForm<HistoryController>(f => f.MediaHistory((GetMediaHistoryRequest)null), FormMethod.Post, new { @id = "bcms-pagecontenthistory-form", @class = "bcms-ajax-form" }))
        {
            
            
            #line default
            #line hidden
            
            #line 144 "..\..\Views\History\MediaHistory.cshtml"
       Write(Html.HiddenGridOptions(Model.GridOptions));

            
            #line default
            #line hidden
            
            #line 144 "..\..\Views\History\MediaHistory.cshtml"
                                                      
            
            
            #line default
            #line hidden
            
            #line 145 "..\..\Views\History\MediaHistory.cshtml"
       Write(Html.HiddenFor(model => model.MediaId));

            
            #line default
            #line hidden
            
            #line 145 "..\..\Views\History\MediaHistory.cshtml"
                                                   


            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"bcms-history-table-top\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"bcms-large-titles\"");

WriteLiteral(">");

            
            #line 148 "..\..\Views\History\MediaHistory.cshtml"
                                          Write(MediaGlobalization.MediaHistory_OlderVersions);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n\r\n                <div");

WriteLiteral(" class=\"bcms-top-block-inner\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"bcms-btn-search\"");

WriteLiteral(" id=\"bcms-pagecontenthistory-search-btn\"");

WriteLiteral(">");

            
            #line 151 "..\..\Views\History\MediaHistory.cshtml"
                                                                                    Write(RootGlobalization.Button_Search);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                    <div");

WriteLiteral(" class=\"bcms-search-block\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 153 "..\..\Views\History\MediaHistory.cshtml"
                   Write(Html.TextBoxFor(m => m.SearchQuery, new { @class = "bcms-search-field-box bcms-js-search-box bcms-search-query", @placeholder = RootGlobalization.WaterMark_Search }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </div>           \r\n            </di" +
"v>\r\n");

            
            #line 157 "..\..\Views\History\MediaHistory.cshtml"


            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"bcms-history-items-list bcms-history-items-list-media\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 159 "..\..\Views\History\MediaHistory.cshtml"
           Write(Html.Grid(Model.Items).Sort(Model.GridOptions).Columns(columns).Attributes(@class => "bcms-tables bcms-history-grid").RenderUsing(new EditableHtmlTableGridRenderer<MediaHistoryItem>()));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 160 "..\..\Views\History\MediaHistory.cshtml"
           Write(Html.HiddenSubmit());

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n");

            
            #line 162 "..\..\Views\History\MediaHistory.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n</div>\r\n\r\n<script");

WriteLiteral(" type=\"text/html\"");

WriteLiteral(" id=\"bcms-history-preview-template\"");

WriteLiteral(">\r\n    <iframe src=\"\" style=\"width: 100%; height: 100%; border: 0px;\"></iframe>\r\n" +
"</script>\r\n");

        }
    }
}
#pragma warning restore 1591
