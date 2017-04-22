using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Models
{
   public class Suppliers
    {
        public int? CompanyID { get; set; }

        public int? SupplierID { get; set; }

        public int? hdnSupplierID { get; set; }

        public string SupplierIDEN { get; set; }

        [Required(ErrorMessage = "Enter Vendor Name")]
        public string SupplierName { get; set; }

        [Required(ErrorMessage = "Enter Vendor #")]
        public string SupplierNumber { get; set; }

        public List<SelectListItem> lstCountries { get; set; }

        public string Country_Address { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string State { get; set; }

        public string City { get; set; }

        public string Zip { get; set; }

        [RegularExpression(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$", ErrorMessage = "Enter valid email")]
        public string Email { get; set; }

        public List<SelectListItem> lstStates { get; set; }

        public string PageName { get; set; }

        public int iTotal_Records { get; set; }

    }
}
