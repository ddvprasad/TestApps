using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Models
{
   public class ItemMaster
    {
        public int ItemID { get; set; }

        public int hdnItemID { get; set; }

        public string CategoryName { get; set; }

        public string ItemName { get; set; }

        public string SupplierName { get; set; }

        public string ItemNumber { get; set; }

        public string SupplierItemCode { get; set; }

        public string ItemIDEN { get; set; }

        public string UnitType { get; set; }

        public string Description { get; set; }

        public int? ItemCategoryID { get; set; }

        public int? QuantityPerUnit { get; set; }

        public string UnitsOnStock { get; set; }

        public string ReorderLevel { get; set; }

        public string UnitsOnOrder { get; set; }

        public int? CompanyID { get; set; }

        public string ImagePath { get; set; }

        public string PageName { get; set; }

        public string strFilePathDocument { get; set; }

        public string Properties { get; set; }

        public int? PropertyID { get; set; }

        public int? UnitTypeID { get; set; }

        public string FileName { get; set; }

        public string Itemcost { get; set; }

        public bool ActiveFlag { get; set; }

        public int? ItemClassID { get; set; }

        public string ItemClassName { get; set; }      

        public bool DefaultItemFlag { get; set; }

        public int iTotal_Records { get; set; }

        public bool Created { get; set; }

        public IEnumerable<SelectListItem> ddllstProperty { get; set; }

        public List<int> PropertyIDS { get; set; }

        public List<SelectListItem> lstProperty { get; set; }

        public List<SelectListItem> lstCategory { get; set; }

        public List<SelectListItem> lstItemUnitTypes { get; set; }

        public List<ItemProperties> lstItemProperties { get; set; }

        public List<SelectListItem> lstItemClasses { get; set; }
    }

   public class Propertylist
   {
       public string Properties { get; set; }
   }

   public class ItemProperties
   {
       public int? InventoryID { get; set; }

       public bool Inventory { get; set; }

       public bool DefaultItemID { get; set; }

       public int? PropertyID { get; set; }

       public string PropertyName { get; set; }

       public string UnitsOnStock { get; set; }

       public string ReorderLevel { get; set; }

       public string UnitsOnOrder { get; set; }
   }


   public class Item
   {
       public int? SupplierID { get; set; }

       public List<ItemMaster> lstItemMaster { get; set; }
   }
}
