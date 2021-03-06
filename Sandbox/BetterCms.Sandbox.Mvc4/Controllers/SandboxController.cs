﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SandboxController.cs" company="Devbridge Group LLC">
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
using System.Web.Mvc;
using System.Web.Security;

using BetterCms.Module.Api;
using BetterCms.Module.Api.Operations.Pages.Sitemaps;
using BetterCms.Module.Api.Operations.Pages.Sitemaps.Sitemap.Tree;
using BetterCms.Module.Api.Operations.Root.Languages;
using BetterCms.Module.Api.Operations.Root.Languages.Language;
using BetterCms.Module.Users.Provider;
using BetterCms.Sandbox.Mvc4.Helpers;
using BetterCms.Sandbox.Mvc4.Models;

using httpContext = System.Web.HttpContext;
using System.Net.Mail;
using System.Net;
using System.Configuration;
using System.Windows.Forms;

namespace BetterCms.Sandbox.Mvc4.Controllers
{
    public class SandboxController : Controller
    {
        private static Guid defaultSitemapId = new Guid("17ABFEE9-5AE6-470C-92E1-C2905036574B");

        public ActionResult Content()
        {
            return Content("Hello from the web project controller.");
        }

        public ActionResult Hello()
        {
            return PartialView("Partial/Hello");
        }

        public ActionResult Widget05()
        {
            return PartialView("~/Views/Widgets/05.cshtml");
        }

        public ActionResult TestRewrite(string url)
        {
            url = string.Concat("/", url.Trim('/'), "/");
            Server.TransferRequest(url);

            return new EmptyResult();
        }

        [AllowAnonymous]
        [HttpGet]
        public ActionResult Login(string roles)
        {
            if (Roles.Enabled && Roles.Provider is CmsRoleProvider)
            {
                var model = new LoginViewModel
                                {
                                    Identity =  User.Identity
                                };

                return View(model);
            }

            AuthenticationHelper.CreateTicket(!string.IsNullOrWhiteSpace(roles) ? roles.Split(',') : new[] { "Owner" });

            return Redirect("/");
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult Login(LoginViewModel login)
        {
            if (Membership.ValidateUser(login.UserName, login.Password))
            {
                var roles = Roles.GetRolesForUser(login.UserName);
                AuthenticationHelper.CreateTicket(roles, login.UserName);

                return Redirect("/");
            }

            return Login((string)null);
        }

        [AllowAnonymous]
        public ActionResult Logout()
        {
            AuthenticationHelper.Logout();
            
            return Redirect("/");
        }

        public ActionResult TestNavigationApi()
        {

            var message = new StringBuilder("No sitemap data found!");

            return Content(message.ToString());
        }

        public ActionResult NotFound()
        {
            return View("NotFound");
        }


        public ActionResult SitemapMenu(string languageCode)
        {
            var renderIFrame = string.IsNullOrWhiteSpace(languageCode);
            var model = new SitemapMenuViewModel
                        {
                            ObsoleteMenuItems = new List<MenuItemViewModel>(),
                            MenuItems = new List<MenuItemViewModel>(),
                            RenderIFrame = renderIFrame,
                            LanguageCode = languageCode
                        };

            using (var api = ApiFactory.Create())
            {
                var languageId = GetLanguageId(api, languageCode);
                var sitemapId = GetSitemapId(api);
                if (sitemapId.HasValue)
                {
                    var request = new Module.Api.Operations.Pages.Sitemap.Tree.GetSitemapTreeRequest { SitemapId = sitemapId.Value };
                    request.Data.LanguageId = languageId ?? new Guid();
                    var response = api.Pages.Sitemap.Tree.Get(request);
                    if (response.Data.Count > 0)
                    {
                        model.ObsoleteMenuItems = response.Data.Select(mi => new MenuItemViewModel { Caption = mi.Title, Url = mi.Url, IsPublished = mi.PageIsPublished }).ToList();
                    }

                    var request1 = new Module.Api.Operations.Pages.Sitemaps.Sitemap.Tree.GetSitemapTreeRequest { SitemapId = sitemapId.Value };
                    request1.Data.LanguageId = languageId ?? new Guid();
                    var response1 = api.Pages.SitemapNew.Tree.Get(request1);
                    if (response.Data.Count > 0)
                    {
                        model.MenuItems = response1.Data.Select(mi => new MenuItemViewModel { Caption = mi.Title, Url = mi.Url, IsPublished = mi.PageIsPublished }).ToList();
                    }
                }

                if (model.RenderIFrame)
                {
                    model.LanguageCodes = api.Root.Languages.Get(new GetLanguagesRequest()).Data.Items.Select(l => l.Code).ToList();
                }
            }

            return View("~/Views/SitemapMenu/Index.cshtml", model);
        }

        private Guid? GetLanguageId(IApiFacade api, string languageCode)
        {
            if (string.IsNullOrEmpty(languageCode))
            {
                return null;
            }

            try
            {
                var request = new GetLanguageRequest { LanguageCode = languageCode };
                var response = api.Root.Language.Get(request);
                return response.Data.Id;
            }
            catch
            {
            }

            return Guid.Empty;
        }

        private Guid? GetSitemapId(IApiFacade api)
        {
            var allSitemaps = api.Pages.Sitemaps.Get(new GetSitemapsRequest());
            if (allSitemaps.Data.Items.Count > 0)
            {
                var sitemap = allSitemaps.Data.Items.FirstOrDefault(map => map.Id == defaultSitemapId) ?? allSitemaps.Data.Items.First();
                return sitemap.Id;
            }

            return null;
        }

        [HttpPost]
        public ActionResult ContactForm(string name,string email,string tel, string msg)
        {
            

            try
            {
                SmtpClient client = new SmtpClient();
                client.Host = ConfigurationManager.AppSettings["host"];//"smtp.office365.com";
                var userName = ConfigurationManager.AppSettings["userName"];
                var password = ConfigurationManager.AppSettings["password"];
                var sender = ConfigurationManager.AppSettings["sender"];
                client.Credentials = new System.Net.NetworkCredential(userName, password);
                client.Port = 587;
                client.EnableSsl = true;

                MailMessage message = new MailMessage();
                message.From = new MailAddress(sender);
                message.IsBodyHtml = true;
                message.Subject = "Enquiry from "+name;//mailSubject;
                message.Body = "Dear D" +",<br/> Have a nice day!<br/>My telephone: "+tel + "<br/>My EmailId: " + email +"<br/><br/>"+msg; //mailBody;

                //message.Sender = new MailAddress(email);
                message.To.Add(userName);
                client.Send(message);

                message = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            

            return new JsonResult
            {
                Data = new
                {
                    message = true ? "Your message successfully send." : "Sorry there has been an error while sending your message, please try again later."
                }
            };
        }
    }
}
