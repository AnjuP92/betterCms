﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="JavaScriptModulesHelper.cs" company="Devbridge Group LLC">
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
using System.Linq;
using System.Text;
using System.Web;

using BetterCms.Core.Modules;
using BetterCms.Module.Root.ViewModels.Rendering;

namespace BetterCms.Module.Root.Mvc.Helpers
{
    /// <summary>
    /// Java script module helper methods.
    /// </summary>
    public static class JavaScriptModulesHelper
    {
        /// <summary>
        /// Renders the comma separated names.
        /// </summary>
        /// <param name="modules">The modules.</param>
        /// <returns>Html string of comma separated names.</returns>
        public static HtmlString RenderCommaSeparatedNames(this IEnumerable<JavaScriptModuleInclude> modules)
        {
            return new HtmlString(string.Join(", ", modules.Select(f => string.Concat("'", f.Name, "'"))));
        }

        /// <summary>
        /// Renders the comma separated friendly names.
        /// </summary>
        /// <param name="modules">The modules.</param>
        /// <returns>Html string of comma separated js friendly names.</returns>
        public static HtmlString RenderCommaSeparatedFriendlyNames(this IEnumerable<JavaScriptModuleInclude> modules)
        {
            return new HtmlString(string.Join(", ", modules.Select(f => f.FriendlyName)));
        }

        /// <summary>
        /// Renders the comma separated name and path pairs.
        /// </summary>
        /// <param name="modules">The modules.</param>        
        /// <param name="useMinifiedPaths">if set to <c>true</c> use minified paths.</param>
        /// <returns>
        /// Html string of comma separated js friendly names.
        /// </returns>
        public static HtmlString RenderCommaSeparatedNamePathPairs(this IEnumerable<JavaScriptModuleInclude> modules, bool useMinifiedPaths = false)
        {
            return new HtmlString(string.Join(", ", modules.Select(f => string.Concat("'", f.Name, "' : '", GetPathForJsInclude(f, useMinifiedPaths), "'"))));
        }

        public static HtmlString RenderCommaSeparatedNameShimConfigPairs(this IEnumerable<JavaScriptModuleInclude> modules)
        {
            return new HtmlString(string.Join(", ", modules.Where(f => f.ShimConfig != null).Select(f => string.Concat("'", f.Name, "' : {", FormatShimConfiguration(f.ShimConfig), "}"))));
        }

        private static string FormatShimConfiguration(JavaScriptModuleShimConfigurationViewModel shimConfig)
        {
            if (shimConfig == null)
            {
                return string.Empty;
            }

            var config = new List<string>();

            if (shimConfig.Depends != null)
            {
                config.Add(string.Format("deps : [{0}]", string.Join(", ", shimConfig.Depends.Select(d => string.Concat("'", d, "'")))));
            }

            if (shimConfig.Exports != null)
            {
                config.Add(string.Format("exports : '{0}'", shimConfig.Exports));
            }

            return string.Join(", ", config);
        }

        private static string GetPathForJsInclude(JavaScriptModuleInclude jsInclude, bool useMinifiedPaths = false)
        {
            string path = useMinifiedPaths && !jsInclude.IsAutoGenerated ? RemoveJsExtension(jsInclude.MinifiedPath) : RemoveJsExtension(jsInclude.Path);
            if (jsInclude.IsAutoGenerated)
            {
               // path = path + "?v=" + DateTime.Now.Ticks;
            }

            return path.ToLowerInvariant();
        }

        private static string RemoveJsExtension(string path)
        {
            int index = path.LastIndexOf(".js", StringComparison.OrdinalIgnoreCase);
            if (index > 0)
            {                
                return path.Substring(0, index);
            }

            return path;
        }
    }
}