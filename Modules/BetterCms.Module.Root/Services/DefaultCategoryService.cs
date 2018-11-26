﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DefaultCategoryService.cs" company="Devbridge Group LLC">
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

using BetterCms.Core.DataContracts;
using BetterCms.Core.Services;
using BetterCms.Events;

using BetterCms.Module.Root.Models;
using BetterCms.Module.Root.ViewModels.Category;

using BetterModules.Core.DataAccess;
using BetterModules.Core.DataAccess.DataContext;
using BetterModules.Core.Exceptions.DataTier;
using BetterModules.Core.Models;

using NHibernate;
using NHibernate.Criterion;
using NHibernate.Linq;
using NHibernate.Transform;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using BetterCms.Core.WebServices;

namespace BetterCms.Module.Root.Services
{
    internal class DefaultCategoryService : ICategoryService
    {
        /// <summary>
        /// The repository
        /// </summary>
        private readonly IRepository repository;

        /// <summary>
        /// The unit of work
        /// </summary>
        private readonly IUnitOfWork unitOfWork;

        private ITWebClient _webClient;

        private readonly ISecurityService securityService;

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultCategoryService" /> class.
        /// </summary>
        /// <param name="repository">The repository.</param>
        /// <param name="cmsConfiguration">The CMS configuration.</param>
        /// <param name="unitOfWork">The unit of work.</param>
        /// <param name="securityService">Security service get information about authorization.</param>
        public DefaultCategoryService(IRepository repository, IUnitOfWork unitOfWork, ISecurityService securityService)
        {
            this.repository = repository;
            this.unitOfWork = unitOfWork;
            this.securityService = securityService;
            _webClient = new TWebClient();
        }

        public IEnumerable<Guid> GetSelectedCategoriesIds<TEntity, TEntityCategory>(Guid? entityId)
            where TEntity : Entity, ICategorized
            where TEntityCategory : Entity, IEntityCategory
        {
            CategoryTree categoryTreeAlias = null;
            Category categoryAliasa = null;
            TEntity entityAlias = null;
            TEntityCategory categoryAlias = default(TEntityCategory);

            IEnumerable<Guid> val = repository.AsQueryOver(() => categoryAliasa)
                             .JoinQueryOver(() => categoryAliasa.CategoryTree, () => categoryTreeAlias)
                             .Where(() => !categoryTreeAlias.IsDeleted && !categoryAliasa.IsDeleted)
                             .WithSubquery.WhereProperty(() => categoryAliasa.Id)
                             .In(QueryOver.Of(() => entityAlias)
                                     .JoinQueryOver(() => entityAlias.Categories, () => categoryAlias)
                                     .Where(() => entityAlias.Id == entityId && !categoryAlias.IsDeleted)
                                     .SelectList(list => list.Select(() => categoryAlias.Category.Id)))
                             .Select(category => category.Id)
                             .Future<Guid>();

            return repository.AsQueryOver(() => categoryAliasa)
                             .JoinQueryOver(() => categoryAliasa.CategoryTree, () => categoryTreeAlias)
                             .Where(() => !categoryTreeAlias.IsDeleted && !categoryAliasa.IsDeleted)
                             .WithSubquery.WhereProperty(() => categoryAliasa.Id)
                             .In(QueryOver.Of(() => entityAlias)
                                     .JoinQueryOver(() => entityAlias.Categories, () => categoryAlias)
                                     .Where(() => entityAlias.Id == entityId && !categoryAlias.IsDeleted)
                                     .SelectList(list => list.Select(() => categoryAlias.Category.Id)))
                             .Select(category => category.Id)
                             .Future<Guid>();
        }

        public IEnumerable<LookupKeyValue> GetSelectedCategories<TEntity, TEntityCategory>(Guid? entityId)
            where TEntity : Entity, ICategorized
            where TEntityCategory : Entity, IEntityCategory
        {


            
           
            
           
            
            CategoryTree categoryTreeAlias = null;
            Category categoryAliasa = null;
            TEntity entityAlias = null;
            //IList<LookupKeyValue> valueAlias = null;
            TEntityCategory categoryAlias = default(TEntityCategory);
            LookupKeyValue valueAlias = null;

            //IEnumerable<LookupKeyValue> valueAlias = new List<LookupKeyValue>();
            //List<LookupKeyValue> valueList = new List<LookupKeyValue>();


            //try
            //{
            //    // set flag = 1 to perform delete in pagecategory table
            //    JObject saveitem = new JObject();
            //    saveitem.Add("Id", entityId);
            //    saveitem.Add("Flag", 1);
            //    string js = JsonConvert.SerializeObject(saveitem);
            //    var model = _webClient.DownloadData<JArray>("Root/ApiFetchCategory", new { JS = js });
            //    for (int i = 0; i < model.Count; i++)
            //    {
            //        LookupKeyValue value = new LookupKeyValue();
            //        value.Key = model[i]["Id"].ToString();
            //        value.Value = model[i]["Name"].ToString();
            //        valueList.Add(value);
            //    }
            //    valueAlias = valueList.AsEnumerable();
            //}
            //catch (Exception e)
            //{

            //}



            //return valueAlias;

            return repository.AsQueryOver(() => categoryAliasa)
                             .JoinQueryOver(() => categoryAliasa.CategoryTree, () => categoryTreeAlias)
                             .Where(() => !categoryTreeAlias.IsDeleted && !categoryAliasa.IsDeleted)
                             .WithSubquery.WhereProperty(() => categoryAliasa.Id)
                             .In(QueryOver.Of(() => entityAlias)
                                     .JoinQueryOver(() => entityAlias.Categories, () => categoryAlias)
                                     .Where(() => entityAlias.Id == entityId && !categoryAlias.IsDeleted)
                                     .SelectList(list => list.Select(() => categoryAlias.Category.Id)))
                             .SelectList(l => l
                                 .Select(NHibernate.Criterion.Projections.Cast(NHibernateUtil.String, NHibernate.Criterion.Projections.Property(() => categoryAliasa.Id))).WithAlias(() => valueAlias.Key)
                                 .Select(() => categoryAliasa.Name).WithAlias(() => valueAlias.Value))
                             .TransformUsing(Transformers.AliasToBean<LookupKeyValue>())
                             .Future<LookupKeyValue>();
        }

        public void CombineEntityCategories<TEntity, TEntityCategory>(TEntity entity, IEnumerable<Guid> currentCategories)
            where TEntity : Entity, ICategorized
            where TEntityCategory : Entity, IEntityCategory, new()
        {
            var categories = currentCategories != null ? currentCategories.ToList() : new List<Guid>();

            if (entity != null)
            {
                var newCategoryIds = entity.Categories != null ? categories.Where(cId => entity.Categories.All(pc => pc.Category.Id != cId)).ToArray() : categories.ToArray();
                var newCategories = repository.AsQueryOver<Category>().WhereRestrictionOn(t => t.Id).IsIn(newCategoryIds).Future<Category>();
                //IEnumerable<Category> newCategories = new List<Category>();
                //List<Category> newcategories = new List<Category>();

                //foreach (var Id in newCategoryIds)
                //{
                //    JObject Jitem = new JObject();
                //    Jitem.Add("Id", Id);
                //    string js = JsonConvert.SerializeObject(Jitem);
                //    var model = _webClient.DownloadData<JObject>("Root/ApiIdCategory", new { JS = js });
                //    Category categoryobject = new Category();
                //    if (model.Count > 0)
                //    {
                //        categoryobject.Id = Id;
                //        categoryobject.Version = (int)model["Version"];
                //        categoryobject.Name = model["Name"].ToString();
                //        categoryobject.DisplayOrder = (int)model["DisplayOrder"];
                //        categoryobject.Macro = model["Macro"].ToString();
                //        CategoryTree categorytree = new CategoryTree();
                //        categorytree.Id = new Guid(model["CategoryTree"].ToString());
                //        categoryobject.CategoryTree = categorytree;
                //        categoryobject.IsDeleted = (bool)model["IsDeleted"];
                //        newcategories.Add(categoryobject);
                //    }
                //}
                //newCategories = newcategories;

                if (entity.Categories != null)
                {
                    // Remove categories
                    var removedCategories = entity.Categories.Where(c => !categories.Contains(c.Category.Id)).ToList();

                    if (removedCategories.Any())
                    {
                        UpdateModifiedInformation(entity);
                    }
                    foreach (var removedCategory in removedCategories)
                    {

                        entity.RemoveCategory(removedCategory);
                        unitOfWork.Session.Delete(removedCategory);
                        //try
                        //{
                        //    // set flag = 1 to perform delete in pagecategory table
                        //    JObject saveitem = new JObject();
                        //    saveitem.Add("Id", removedCategory.Id);
                        //    saveitem.Add("Flag", 1);
                        //    string js = JsonConvert.SerializeObject(saveitem);
                        //    var model = _webClient.DownloadData<string>("Root/ApiRemoveCategory", new { JS = js });



                        //}
                        //catch (Exception e)
                        //{

                        //}

                    }
                }

                if (newCategories.Any())
                {
                    UpdateModifiedInformation(entity);
                }

                // Attach new categories
                foreach (var newCategory in newCategories)
                {
                    var newentityCategory = new TEntityCategory();
                    newentityCategory.Category = newCategory;
                    newentityCategory.SetEntity(entity);
                    // newentityCategory.Version = 0;
                    entity.AddCategory(newentityCategory);
                }
            }
        }

        public void CombineEntityCategories<TEntity, TEntityCategory>(TEntity entity, IEnumerable<LookupKeyValue> currentCategories)
            where TEntity : Entity, ICategorized
            where TEntityCategory : Entity, IEntityCategory, new()
        {
            CombineEntityCategories<TEntity, TEntityCategory>(entity, currentCategories != null ? currentCategories.Select(c => Guid.Parse(c.Key)) : Enumerable.Empty<Guid>());
        }

        public void DeleteCategoryNode(Guid id, int version, Guid? categoryTreeId = null)
        {
            IList<ICategory> deletedNodes = new List<ICategory>();

            var node = repository.AsQueryable<Category>()
                .Where(sitemapNode => sitemapNode.Id == id && (!categoryTreeId.HasValue || sitemapNode.CategoryTree.Id == categoryTreeId.Value))
                .Fetch(sitemapNode => sitemapNode.CategoryTree)
                .Distinct()
                .First();

            // Concurrency.
            if (version > 0 && node.Version != version)
            {
                throw new ConcurrentDataException(node);
            }

            unitOfWork.BeginTransaction();

            //  ArchiveSitemap(node.Sitemap.Id);

            DeleteCategoryNode(node, ref deletedNodes);

            unitOfWork.Commit();

            var updatedCategories = new List<ICategoryTree>();
            foreach (var deletedNode in deletedNodes)
            {
                RootEvents.Instance.OnCategoryDeleted(deletedNode);
                if (!updatedCategories.Contains(deletedNode.CategoryTree))
                {
                    updatedCategories.Add(deletedNode.CategoryTree);
                }
            }

            foreach (var sitemap in updatedCategories)
            {
                RootEvents.Instance.OnCategoryTreeUpdated(sitemap);
            }
        }

        public IEnumerable<Guid> GetChildCategoriesIds(Guid categoryId)
        {
            var allCategoryNodes = repository.AsQueryable<Category>().Where(c =>
                                                    repository.AsQueryable<Category>().Where(cat => cat.Id == categoryId && !cat.IsDeleted)
                                                    .Any(catT => catT.CategoryTree.Id == c.CategoryTree.Id && !catT.IsDeleted)
                                                    ).Select(c => new CategoryViewModel()
                                                    {
                                                        Id = c.Id,
                                                        Title = c.Name,
                                                        DisplayOrder = c.DisplayOrder,
                                                        CategoryTreeId = c.CategoryTree.Id,
                                                        ParentCategoryId = c.ParentCategory != null ? c.ParentCategory.Id : (Guid?)null
                                                    }).ToList();
            // Find given category
            var mainCategory = allCategoryNodes.First(c => c.Id == categoryId);
            var childCategories = new List<CategoryViewModel>() { mainCategory };

            FillChildCategories(allCategoryNodes, mainCategory, childCategories);

            return childCategories.Select(c => c.Id);
        }

        public IEnumerable<Guid> GetCategoriesIds(IEnumerable<string> categoriesNames)
        {
            return repository.AsQueryable<Category>()
                        .Where(c => categoriesNames.Contains(c.Name) && !c.IsDeleted)
                        .Select(c => c.Id).ToList();
        }

        private void FillChildCategories(List<CategoryViewModel> allItems, CategoryViewModel mainCategory, List<CategoryViewModel> childCategories)
        {
            var childItems = allItems.Where(item => item.ParentCategoryId == mainCategory.Id && item.Id != mainCategory.Id).OrderBy(node => node.DisplayOrder).ToList();

            foreach (var item in childItems)
            {
                childCategories.Add(item);

                FillChildCategories(allItems.Except(childCategories).ToList(), item, childCategories);
            }
        }

        private void DeleteCategoryNode(ICategory node, ref IList<ICategory> deletedNodes)
        {
            if (node.ChildCategories != null)
            {
                foreach (var childNode in node.ChildCategories)
                {
                    DeleteCategoryNode(childNode, ref deletedNodes);
                }
            }

            repository.Delete(node);
            //try
            //{
            //    // set flag = 2 to perform delete in category table
            //    JObject saveitem = new JObject();
            //    saveitem.Add("Id", node.Id);
            //    saveitem.Add("Flag", 2);
            //    string js = JsonConvert.SerializeObject(saveitem);
            //    var model = _webClient.DownloadData<string>("Root/ApiRemoveCategory", new { JS = js });

            //}
            //catch (Exception e)
            //{

            //}


            deletedNodes.Add(node);
        }

        private void UpdateModifiedInformation(Entity entity)
        {
            entity.ModifiedOn = DateTime.Now;
            entity.ModifiedByUser = securityService.CurrentPrincipalName;
            unitOfWork.Session.SaveOrUpdate(entity);
        }


        public IList<CategoryLookupModel> GetCategoriesLookupList(string categoriesFilterKey)
          {
              //var query = repository.AsQueryable<Category>().Where(c => !c.IsDeleted);

              //query = query.Where(c => !c.CategoryTree.IsDeleted && c.CategoryTree.AvailableFor.Any(e => e.CategorizableItem.Name == categoriesFilterKey));
              //var parentCategories = query.Where(x => x.ParentCategory == null).ToList();
              //var treeLikeList = ConstructTreeList(parentCategories);
              IList<CategoryLookupModel> treeLikeList = new List<CategoryLookupModel>();
              List<CategoryLookupModel> treeList = new List<CategoryLookupModel>();



              try
              {
                  // set flag = 1 to perform delete in  table
                  JObject saveitem = new JObject();
                  saveitem.Add("key", categoriesFilterKey);
                  saveitem.Add("Flag", 1);
                  string js = JsonConvert.SerializeObject(saveitem);
                  var model = _webClient.DownloadData<JArray>("Root/ApiFetchCategoryList", new { JS = js });
                  for (int i = 0; i < model.Count; i++)
                  {
                      CategoryLookupModel Categorymodel = new CategoryLookupModel();
                      Categorymodel.id = model[i]["Id"].ToString();
                      
                      Categorymodel.parent = (!string.IsNullOrEmpty(model[i]["Parent"].ToString())) ? model[i]["Parent"].ToString() : null; 
                      Categorymodel.text = model[i]["text"].ToString();
                      for (int j = 0; j < model.Count; j++)
                      {
                          if (model[j]["Parent"].ToString() == model[i]["Id"].ToString())
                          {
                              CategoryLookupModel CategorymodelChild = new CategoryLookupModel();
                              CategorymodelChild.id = model[i]["Id"].ToString();
                              CategorymodelChild.parent = (!string.IsNullOrEmpty(model[i]["Parent"].ToString())) ? model[i]["Parent"].ToString() : null; 
                              CategorymodelChild.text = model[i]["text"].ToString();
                              Categorymodel.children.Add(CategorymodelChild);
                          }
                      }
                      treeList.Add(Categorymodel);

                  }

                  treeLikeList = treeList;

              }
              catch (Exception e)
              {

              }



            return treeLikeList;
        }

        private IList<CategoryLookupModel> ConstructTreeList(List<Category> categories)
        {
            var treeLikeList = new List<CategoryLookupModel>();
            foreach (var category in categories)
            {
                var categoryModel = new CategoryLookupModel { id = category.Id.ToString(), text = category.Name };
                if (category.ParentCategory != null)
                {
                    categoryModel.parent = category.ParentCategory.Id.ToString();
                }
                if (category.ChildCategories != null)
                {
                    categoryModel.children = ConstructTreeList(category.ChildCategories.ToList());
                }
                treeLikeList.Add(categoryModel);
            }
            return treeLikeList;
        }
    }
}