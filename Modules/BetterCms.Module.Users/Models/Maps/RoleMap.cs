﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RoleMap.cs" company="Devbridge Group LLC">
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

namespace BetterCms.Module.Users.Models.Maps
{
    public class RoleMap : EntityMapBase<Role>
    {
        public RoleMap()
            : base(UsersModuleDescriptor.ModuleName)
        {
            Table("Roles");

            Map(x => x.Name).Length(MaxLength.Name).Not.Nullable();
            Map(x => x.Description).Length(MaxLength.Name).Nullable();
            Map(x => x.IsSystematic).Not.Nullable();

            HasMany(x => x.UserRoles).KeyColumn("RoleId").Cascade.SaveUpdate().Inverse().LazyLoad().Where("IsDeleted = 0");
        }
    }
}