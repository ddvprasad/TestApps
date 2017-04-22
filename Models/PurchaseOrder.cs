using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Models
{
    public class PurchaseOrder
    {
        [Required(ErrorMessage = "Enter Purchase Order #")]
        public string PONumber { get; set; }

        public int? POID { get; set; }

        public string POIDEN { get; set; }

        public string Description { get; set; }

        [Required(ErrorMessage = "Select Purchase Order Date")]
        public string PODate { get; set; }

        [Required(ErrorMessage = "Select Supplier")]
        public int? SupplierID { get; set; }

        public string SupplierName { get; set; }

        public string SupplierEmail { get; set; }

        public string SupplierCity { get; set; }

        public string SupplierState { get; set; }

        public string SupplierAddress { get; set; }

        [Required(ErrorMessage = "Select Status")]
        public int? Status { get; set; }

        public string strStatus { get; set; }

        public string OrderSubTotal { get; set; }

        public string DiscountTotal { get; set; }

        public string TaxTotal { get; set; }

        public string Freight { get; set; }

        public string Fees { get; set; }

        public string OrderTotal { get; set; }

        public string TotalCost { get; set; }

        public string UnitCost { get; set; }

        public string ErrorMessage { get; set; }

        public int? ItemCategoryID { get; set; }

        public string ShippingAndHandlingCharges  { get; set; }

        public string QuoteNumber { get; set; }

        public string Notes { get; set; }

        public string ManualPOFlag { get; set; }

        public int iTotal_Records { get; set; }

        public List<SelectListItem> lstSuppliers { get; set; }

        public List<SelectListItem> lstStatus { get; set; }

        public List<SelectListItem> lstItems { get; set; }

        public List<PurchaseOrderLineItems> lstPOLineItems { get; set; }

        public List<SelectListItem> lstCategory { get; set; }

        public string OPEmails { get; set; }

        public string PropertyName { get; set; }

        public string PropertyState { get; set; }

        public string PropertyCity { get; set; }

        public string PropertyCountry { get; set; }

        public string PropertyAddress { get; set; }

        public double POWeek { get; set; }

        public double POMonth { get; set; }

        public double POQuarter { get; set; }

        public double POAboveQuarter { get; set; }

        public double TotalPO { get; set; }
    }

    public class PurchaseOrderLineItems
    {

        public int? POLineItemID { get; set; }

        public int? POID { get; set; }

        public int? ItemID { get; set; }

        public int? hdnItemID { get; set; }

        public int? SupplierID { get; set; }

        public int? ItemCategoryID { get; set; }

        public int? ItemClassID { get; set; }

        public string UnitOrdered { get; set; }

        public string UnitCost { get; set; }

        public string UnitTotal { get; set; }

        public string UnitType { get; set; }

        public string ItemName { get; set; }

        public string VendorItemcode { get; set; }

        public string ddlStatus { get; set; }

        public string UnitDiscount { get; set; }

        public string Comments { get; set; }

        public string ScreenName { get; set; }

        public List<SelectListItem> lstItems { get; set; }

        public List<SelectListItem> lstCategory { get; set; }

        public List<SelectListItem> lstItemClass { get; set; }

        public int ddlCount { get; set; }

        public bool Allow { get; set; }

        public Guid? ddlIDItem { get; set; }

        public Guid? ddlIDCat { get; set; }

        public Guid? chkAllow { get; set; }

        public double TotalUnitsOrdered { get; set; }

        public List<SelectListItem> lstSuppliers { get; set; }
    }
}
