using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Models
{
    public class Roles
    {
        public int? RoleID { get; set; }

        [Required(ErrorMessage = "Enter Role Name")]
        public string RoleName { get; set; }

        public bool? DefaultFlag { get; set; }

        public bool? Selected { get; set; }
    }

    public class RoleAccessRights
    {
        public int? RoleID { get; set; }

        [Required(ErrorMessage = "Enter Role Name")]
        public string Name { get; set; }

        public List<Menu> lstMenu { get; set; }

        public List<Menu> lstParentMenu { get; set; }

        public List<Widget> lstWidget { get; set; }
      
    }   
}