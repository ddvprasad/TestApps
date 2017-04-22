using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Models
{
    public class BankTransaction
    {
        public int? TransactionBatchID { get; set; }

        public int? PropertyID { get; set; }

        public int? Month { get; set; }

        public string PropertyName { get; set; }

        public string strMonth { get; set; }

        public string strYear { get; set; }

        public string FileImportDate { get; set; }

        public string filePath { get; set; }

        public string FileName { get; set; }

        public string FilePath { get; set; }

        public string ReconcileStatus { get; set; }

        public string TotalTransactions { get; set; }

        public int NotReconciled { get; set; }

        public List<SelectListItem> lstProperties { get; set; }

        public List<SelectListItem> lstYears { get; set; }

        public List<SelectListItem> lstMonthNames { get; set; }

        public List<BankTransactionDetails> lstBankTransactionDetails { get; set; }
    }

    public class BankTransactionDetails
    {
        public int? TransactionDetailID { get; set; }

        public int? TransactionBatchID { get; set; }

        public string TransactionDate { get; set; }

        public string Amount { get; set; }

        public string CheckNumber { get; set; }

        public string Description { get; set; }

        public string InvoiceNumber { get; set; }

        public string Comments { get; set; }

        public string SelectedDetailIDs { get; set; }
    }
}
