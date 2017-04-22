using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace Models
{
    public class Inventory
    {
        public int? Month { get; set; }

        public string strMonth { get; set; }

        public bool Updateflag { get; set; }

        public List<SelectListItem> lstMonthNames { get; set; }

        public int? ItemCategoryID { get; set; }

        public int? RoomProjection { get; set; }

        public string PreviousRoomProjection { get; set; }

        public string ItemCategoryName { get; set; }

        public List<SelectListItem> lstCategory { get; set; }

        public List<ItemLocationHeaders> lstHeader { get; set; }

        public List<StockLocation> lstItemLocation { get; set; }

        public List<InventoryMovement> lstInventoryMovement { get; set; }

        public string strYear { get; set; }

        public List<SelectListItem> lstYears { get; set; }

        public List<SelectListItem> lstRoomTypeDetails { get; set; }

        public bool IsMonthlyCategory { get; set; }

        public string strDate { get; set; }

        public string strProjection { get; set; }

        public List<RoomDetailType> lstRoomDetailType { get; set; }

        public int singleRS { get; set; }

        public int doubleRS { get; set; }

        public int? ActualRoomsSoldID { get; set; }

        public bool LockingFlag { get; set; }
    }

    public class RoomDetailType
    {

        public string RoomTypeDatailName { get; set; }

        public string Value { get; set; }

        public int RoomTypeDatailID { get; set; }

    }

    public class ItemLocationHeaders
    {
        
        public string Name { get; set; }

        public bool Updatefalg { get; set; }

        public int ItemLocationID { get; set; }

    }

    public class StockLocation
    {
        public int ItemLocationID { get; set; }

        public string Name { get; set; }

        public int ItemID { get; set; }

        public string Value { get; set; }

        public string UnitName { get; set; }
    }

    public class InventoryMovement
    {
        public int ItemID { get; set; }

        public int SupplierID { get; set; }

        public string ReorderLevel { get; set; }

        public string TotalProperty { get; set; }

        public string NeedToOrder { get; set; }

        public bool CreatePO { get; set; }

        public string ItemNumber { get; set; }

        public string UnitType { get; set; }

        public string ItemName { get; set; }

        public string SupplierItemcost { get; set; }

        public string ItemClassName { get; set; }

        public string UnitName { get; set; }

        public string UnitsRequired { get; set; }
    }
}
