using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Models
{
   public class SupplierItemCost
    {
        public int? CompanyID { get; set; }

        public int? PropertyID { get; set; }

        public string PropertyName { get; set; }

        public int? SupplierItemCostID { get; set; }

        public int? SupplierID { get; set; }

        public string SupplierName { get; set; }

        public string SupplierNumber { get; set; }

        public string PageName { get; set; }

        public string ItemName { get; set; }

        public string ItemNumber { get; set; }

        public int ItemID { get; set; }

        public decimal? SupplierItemcost { get; set; }

        public string Itemcost { get; set; }

        public string UnitType { get; set; }

        public string SupplierItemCode { get; set; }

        public bool? DefaultFlag { get; set; }

        public List<SelectListItem> lstSuppliers { get; set; }

        public List<SelectListItem> lstItemID { get; set; }

        public List<SelectListItem> lstProperty { get; set; }

        public List<int> lstPropertyIDS { get; set; }

        public string PropertyIDS { get; set; }

        public MultiSelectList ddllstProperty { get; set; }
    }
}
