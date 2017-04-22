using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Models
{
    public class ItemCategory
    {
        public int ItemCategoryID { get; set; }

        public int? ItemLocationID { get; set; }

        public string CategoryName { get; set; }

        public string LocationId { get; set; }

        public List<int> NameIDS { get; set; }

        public string PageName { get; set; }

        public int CompanyID { get; set; }

        public string Locations { get; set; }

        public double UnitsOnStock { get; set; }

        public int? RowNumber { get; set; }

       
        public List<SelectListItem> lstName { get; set; }

    }
}
