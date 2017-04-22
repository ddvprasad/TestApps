using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Models
{
    public class CompareReport
    {
        public int? PropertyID { get; set; }

        public string PropertyIDS { get; set; }

        public string ItemCategoryIDS { get; set; }

        public int ItemCategoryID { get; set; }

        public string FromPurchasing { get; set; }

        public string ToPurchasing { get; set; }

        public string Name { get; set; }

        public string FromEmployeeCost { get; set; }

        public string ToEmployeeCost { get; set; }

        public string FromTotalCostPerRoom { get; set; }

        public string ToTotalCostPerRoom { get; set; }

        public string DiffPurchasing { get; set; }

        public string DiffEmployeeCost { get; set; }

        public string DiffTotalCostPerRoom { get; set; }

        public string FromCost { get; set; }

        public string ToCost { get; set; }

        public string DiffCost { get; set; }

        public string CategoryName { get; set; }

        public string FFromDate { get; set; }

        public string FToDate { get; set; }

        public string TFromDate { get; set; }

        public string TToDate { get; set; }

        public List<SelectListItem> lstProperties { get; set; }

        public List<SelectListItem> lstItemCategories { get; set; }

        public List<CompareReport> lstCompareReport { get; set; }

        public List<SelectListItem> lstYears { get; set; }

        public List<SelectListItem> lstStatus { get; set; }
    }
}
