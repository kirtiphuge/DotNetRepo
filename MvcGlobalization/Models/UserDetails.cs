using MvcGlobalization.LocalResource;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace MvcGlobalization.Models
{
    public class UserDetails
    {
        [Display(Name = "FirstName", ResourceType = typeof(Resource))]
        public string Firstname { get; set; }

        [Display(Name = "LastName", ResourceType = typeof(Resource))]
        public string Lastname { get; set; }
    }
}