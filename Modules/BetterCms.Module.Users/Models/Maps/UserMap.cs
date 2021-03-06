﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UserMap.cs" company="Devbridge Group LLC">
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
    public class UserMap : EntityMapBase<User>
    {
        public UserMap()
            : base(UsersModuleDescriptor.ModuleName)
        {
            Table("Users");

            Map(x => x.UserName).Length(UsersModuleConstants.UserNameMaxLength).Not.Nullable();
            Map(x => x.FirstName).Length(MaxLength.Name).Nullable();
            Map(x => x.LastName).Length(MaxLength.Name).Nullable();
            Map(x => x.Password).Length(MaxLength.Password).Nullable();
            Map(x => x.Email).Length(MaxLength.Email).Not.Nullable();
            Map(x => x.Salt).Length(MaxLength.Password).Nullable();
            
            References(x => x.Image).Cascade.SaveUpdate().LazyLoad();

            HasMany(x => x.UserRoles).KeyColumn("UserId").Cascade.SaveUpdate().Inverse().LazyLoad().Where("IsDeleted = 0");
        }
    }
}