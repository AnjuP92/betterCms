﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DocumentSavingEventArgs.cs" company="Devbridge Group LLC">
// 
// Copyright (C) 2015,2016 Devbridge Group LLC
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public License
// along with this program.  If not, see http://www.gnu.org/licenses/. 
// </copyright>
// 
// <summary>
// Better CMS is a publishing focused and developer friendly .NET open source CMS.
// 
// Website: https://www.bettercms.com 
// GitHub: https://github.com/devbridge/bettercms
// Email: info@bettercms.com
// </summary>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;

using BetterCMS.Module.LuceneSearch.Services.IndexerService;
using BetterCMS.Module.LuceneSearch.Services.WebCrawlerService;

using Lucene.Net.Documents;

// ReSharper disable CheckNamespace
namespace BetterCms.Events
// ReSharper restore CheckNamespace
{
    public class DocumentSavingEventArgs: EventArgs
    {
        public Document Document { get; set; }

        public PageData PageData { get; set; }

        public bool ExcludeDefaultDocumentFromIndex { get; set; }

        public IList<DocumentData> AdditionalDocuments { get; set; }

        public DocumentSavingEventArgs(Document document, PageData pageData)
        {
            Document = document;
            PageData = pageData;
            ExcludeDefaultDocumentFromIndex = false;
            AdditionalDocuments = new List<DocumentData>();
        }
    }
}
