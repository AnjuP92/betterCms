using BetterCms.Module.Root.ViewModels.Cms;
using FluentMigrator.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BetterCms.Sandbox.Mvc4.Models
{
    public class ContactFormViewModel : RenderWidgetViewModel
    {
        [Required]
        public string Name { get; set; }

        /*[Required]*/
        /*[Email(ErrorMessages = "Invalid Email address")]*/
        public string Email { get; set; }

        [Required]
        public string Message { get; set; }

        public string EmailTo { get; set; }

        public override string ToString()
        {
            return string.Format("Name: {0}, Email: {1}, Phone: {2}, Message: {3}", Name, Email, Message);
        }
    }
}