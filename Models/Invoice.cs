using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Models
{
    public class Invoice
    {
        public string InvoiceNumber { get; set; }

        public string InvoiceDate { get; set; }

        public string PONumber { get; set; }

        public string PurchaseOrderDate { get; set; }

        public string ItemClassName { get; set; }

        public string MainAccountName { get; set; }

        public string ItemName { get; set; }

        public string SupplierName { get; set; }

        public string CreateInvoice { get; set; }

        public string ManualPO { get; set; }

        public int? InvoiceID { get; set; }

        public string InvoiceIDEN { get; set; }

        public int? POID { get; set; }

        public int? SupplierID { get; set; }

        public int? hdnSupplierID { get; set; }

        public string Description { get; set; }

        public string strStatus { get; set; }

        public string InvoiceSubTotal { get; set; }

        public string DiscountTotal { get; set; }

        public string Freight { get; set; }

        public string Fees { get; set; }

        public string TotalCost { get; set; }

        public string FilePath { get; set; }

        public string File2Path { get; set; }

        public string File3Path { get; set; }

        public string File4Path { get; set; }

        public string FileName { get; set; }

        public string File2Name { get; set; }

        public string File3Name { get; set; }

        public string File4Name { get; set; }

        public string SalesTax { get; set; }

        public string PropertyName { get; set; }

        public string strFilePathDocument { get; set; }

        public string strFilePathDocument2 { get; set; }

        public string strFilePathDocument3 { get; set; }

        public string strFilePathDocument4 { get; set; }

        public string ShippingAndHandlingCharges { get; set; }

        public string ItemNumber { get; set; }

        public string ItemNumbers { get; set; }

        public string SubmitType { get; set; }

        public string ErrorMessage { get; set; }

        public string EmailMessage { get; set; }

        public string POVisible { get; set; }

        public int iTotal_Records { get; set; }

        public List<SelectListItem> lstPurchaseOrders { get; set; }

        public List<SelectListItem> lstSuppliers { get; set; }

        public List<InvoiceLineItems> lstInvoiceLineItems { get; set; }

        public string ErrorMessageItem { get; set; }

        public string ErrorMessageUnitCost { get; set; }

        public string ErrorMessageQuantity { get; set; }

        [Required(ErrorMessage = "Select Status")]
        public int? Status { get; set; }

        public List<SelectListItem> lstStatus { get; set; }

        public string ManualPOFlag { get; set; }

        public bool BTReconcile { get; set; }

        public string ScreenName { get; set; }

        public string ReceivingFlag { get; set; }

        public int? InvoiceLineItemID { get; set; }

        public string NumberOfUnitsOrdered { get; set; }

        public string NumberOfUnitsReceived { get; set; }

        public string NumberOfUntis { get; set; }

        public string UnitCost { get; set; }

        public string TaxTotal { get; set; }

        public string UnitTotal { get; set; }

        public string InvoiceTotal { get; set; }

        public string TransactionReferenceNumber { get; set; }

        public string TransactionType { get; set; }

        public int? TransactionTypeID { get; set; }

        public List<SelectListItem> lstTransactionTypes { get; set; }


    }

    public class InvoiceLineItems
    {
        public string InvoiceNumber { get; set; }

        public int? InvoiceLineItemID { get; set; }

        public int? ReceivingLineItemID { get; set; }

        public int? POLineItemID { get; set; }

        public int? InvoiceID { get; set; }

        public int? POID { get; set; }

        public int? ItemID { get; set; }

        public int? hdnItemID { get; set; }

        public int? ItemCategoryID { get; set; }

        public string ItemCategoryName { get; set; }

        public string Item { get; set; }

        public string NumberOfUnitsOrdered { get; set; }

        public string NumberOfUnitsReceived { get; set; }

        public string NumberOfUnits { get; set; }

        public string DateReceived { get; set; }

        public string UnitCost { get; set; }

        public string UnitType { get; set; }

        public string SupplierItemCode { get; set; }

        public string UnitTotal { get; set; }

        public string hdnUnitTotal { get; set; }

        public string ItemName { get; set; }

        public int? ItemClassID { get; set; }

        public string ItemClassName { get; set; }

        public string UnitDiscount { get; set; }

        public List<SelectListItem> lstItems { get; set; }

        public int? ChartofAccountID { get; set; }

        public string ChartofAccount { get; set; }

        public List<SelectListItem> lstMainAccount { get; set; }

        public Guid? ddlID { get; set; }

        public string ItemNumber { get; set; }

        public string QtyORD { get; set; }

        public string QtySHIP { get; set; }

        public string UM { get; set; }

        public string ShipWeight { get; set; }

        public string PackSize { get; set; }

        public string Brand { get; set; }

        public string Description { get; set; }

        public string Tax { get; set; }

        public string Comments { get; set; }

        public string strScreenName { get; set; }

        public string UnitPrice { get; set; }

        public string Amount { get; set; }

        public bool Allow { get; set; }

        public Guid? ddlIDItem { get; set; }

        public Guid? ddlIDCat { get; set; }

        public Guid? chkAllow { get; set; }

        public Guid? ddlIDMainAccount { get; set; }

        public Guid? ddlIDSubCategoryOne { get; set; }

        public Guid? ddlIDSubCategoryTwo { get; set; }

        public List<SelectListItem> lstItemClass { get; set; }

        public int? TransactionTypeID { get; set; }

        public string TransactionReferenceNumber { get; set; }

        public string TransactionTypeName { get; set; }

        public Guid? ddlIDTransactionType { get; set; }

        public List<SelectListItem> lstTransactionTypes { get; set; }

        public bool ForceCloseInvoiceFlag { get; set; }

        


    }
}