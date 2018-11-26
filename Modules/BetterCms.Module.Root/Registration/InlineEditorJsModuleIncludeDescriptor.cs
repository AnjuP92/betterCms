﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InlineEditorJsModuleIncludeDescriptor.cs" company="Devbridge Group LLC">
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
using BetterCms.Core.Modules;
using BetterCms.Core.Modules.Projections;
using BetterCms.Module.Root.Content.Resources;

using BetterModules.Core.Web.Modules;

namespace BetterCms.Module.Root.Registration
{
    /// <summary>
    /// bcms.pages.inlineEdit.js module descriptor.
    /// </summary>
    public class InlineEditorJsModuleIncludeDescriptor : JsIncludeDescriptor
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineEditorJsModuleIncludeDescriptor" /> class.
        /// </summary>
        /// <param name="module">The container module.</param>
        public InlineEditorJsModuleIncludeDescriptor(RootModuleDescriptor module)
            : base(module, "bcms.inlineEdit")
        {

            Links = new IActionProjection[]
                {
                };

            Globalization = new IActionProjection[]
                {      
                    new JavaScriptModuleGlobalization(this, "messageDeleting", () => RootGlobalization.Message_Deleting), 
                    new JavaScriptModuleGlobalization(this, "messageSaving", () => RootGlobalization.Message_Saving),
                    new JavaScriptModuleGlobalization(this, "confirmDeleteMessage", () => RootGlobalization.Confirm_Delete_DefaultMessage),
                };
        }
    }
}