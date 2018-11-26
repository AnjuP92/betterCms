﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CategoryTreeMap.cs" company="Devbridge Group LLC">
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
using BetterModules.Core.Models;

namespace BetterCms.Module.Root.Models.Maps
{
    public class CategoryTreeMap : EntityMapBase<CategoryTree>
    {
        public CategoryTreeMap()
            : base(RootModuleDescriptor.ModuleName)
        {
            Table("CategoryTrees");

            Map(x => x.Title).Not.Nullable().Length(MaxLength.Name);
            Map(x => x.Macro).Nullable().Length(MaxLength.Text);

            HasMany(f => f.Categories).Table("Categories").KeyColumn("CategoryTreeId").Inverse().Cascade.SaveUpdate().Where("IsDeleted = 0");
            HasMany(x => x.AvailableFor).KeyColumn("CategoryTreeId").Cascade.SaveUpdate().Inverse().LazyLoad().Where("IsDeleted = 0");
        }
    }
}