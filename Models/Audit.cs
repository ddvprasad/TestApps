using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;


namespace Models
{
    public class Audit
    {
        public int CompanyID { get; set; }

        public int PropertyID { get; set; }

        public string CostHeadName { get; set; }

        public int DetailAuditLogID { get; set; }

        public int ParentCostHeadID { get; set; }

        public string Code { get; set; }

        public int DisplayOrder { get; set; }

        public int TotalFlag { get; set; }

        public bool DisplayColumnFlag { get; set; }

        public decimal Value { get; set; }

        public decimal ToDay { get; set; }

        public decimal MTD { get; set; }

        public int intToDay { get; set; }

        public int intMTD { get; set; }

        public string Message { get; set; }

        public string Date { get; set; }

        public string FilePath { get; set; }

        public int? Room { get; set; }

        public bool LedgerFlag { get; set; }

        public string PropertyName { get; set; }

        public List<Audit> lstAudit { get; set; }

        public List<Audit> lstParentAudit { get; set; }

        public List<Audit> lstRightTable { get; set; }

        public List<Audit> lstRightTableLedger { get; set; }

        public List<Audit> lstParentLedger { get; set; }

        public List<Audit> lstParentRightTable { get; set; }

        public List<Audit> lstheader { get; set; }

        public List<Audit> lstheaderValues { get; set; }

        public List<SelectListItem> lstProperty { get; set; }
    }
}
