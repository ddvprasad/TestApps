using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Models
{
    public class Menu
    {
        public int? MenuID { get; set; }

        public int? ParentMenuID { get; set; }

        //[Required(ErrorMessage = "Enter menu name")]
        public string Name { get; set; }

        //[Required(ErrorMessage = "Enter menu display name")]
        public string DisplayName { get; set; }

        public int AccessMode { get; set; }
        // [Required(ErrorMessage = "Enter menu path")]

        public string MenuPath { get; set; }
        // [Required(ErrorMessage = "Enter menu order")]

        public int? DisplayOrder { get; set; }

        public string GroupName { get; set; }

        public string ClassName { get; set; }

        public List<Menu> lstMenuModel { get; set; }

        //extra added for menulist

        public string MenuIDEN { get; set; }

        public string ParentMenuName { get; set; }

        public bool ActiveFlag { get; set; }

        public bool DisplayInMenuFlag { get; set; }

        public bool Display_In_Access_Rights_Flag { get; set; }

        public int? AccessRightsDisplayOrder { get; set; }

        public List<SelectListItem> lstParentMenu { get; set; }

        public string Active { get; set; }

        public string DisplayInAccessRightsFlag { get; set; }

        public string DisplayInMenu { get; set; }

        public bool Full { get; set; }

        public bool Add { get; set; }

        public bool Edit { get; set; }

        public bool Delete { get; set; }

        public bool View { get; set; }

        public bool None { get; set; }
    }
}