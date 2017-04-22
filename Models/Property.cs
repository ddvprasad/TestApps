using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Models
{
    public class Property
    {
        public int? CompanyID { get; set; }

        public int? PropertyID { get; set; } 

        public string PropertyIDEN { get; set; }

        [Required(ErrorMessage = "Enter Name")]
        public string PropertyName { get; set; }

        [Required(ErrorMessage = "Enter Address")]
        public string Address { get; set; }

        public string PropertyshceduleStartTime { get; set; }

        public string PropertyshceduleEndTime { get; set; }

        public string Address2 { get; set; }

        public string State { get; set; }

        public string City { get; set; }

        public string County { get; set; }

        public string Zip { get; set; }

        public string Country { get; set; }

        public string AcquiredOn { get; set; }

        public string SalesTax { get; set; }

        public int? Rooms { get; set; }

        public string ImagePath { get; set; }

        public bool ActiveFlag { get; set; }

        public List<int> CategoryIDS { get; set; }

        public string Categories { get; set; }

        public List<SelectListItem> lstCountries { get; set; }

        public List<SelectListItem> lstStates { get; set; }

        public List<SelectListItem> lstProperties { get; set; }

        public List<SelectListItem> lstCategories { get; set; }
    }
}
