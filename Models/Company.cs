using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Models
{
    public class Company
    {
        public int CompanyID { get; set; }

        public string SMTPServer { get; set; }

        public string SMTPUser { get; set; }

        public string SMTPPassword { get; set; }

        public int? SMTPPort { get; set; }

        public bool EnableSSLFlag { get; set; }

        public bool CompanyLevelEmailSettingsFlag { get; set; }

        public string CompanyName { get; set; }

        public string POPrefix { get; set; }

        public string PONumberStartWith { get; set; }

        public string ActiveFlag { get; set; }

        public string Name { get; set; }

        public string Value { get; set; }

        public string DefaultGridSize { get; set; }

        public string NumberOfEmployees { get; set; }

        public string NumberOfProperties { get; set; }

        public string NumberOfItems { get; set; }

        public string NumberOfRooms { get; set; }

        //public IEnumerable<SelectListItem> ddllstRoles { get; set; }

        public MultiSelectList ddllstRoles { get; set; }

        public MultiSelectList ddllstPayRate { get; set; }

        public int? RoleID { get; set; }

        public List<int> lstRoleIDS { get; set; }

        public string RoleIDS { get; set; }

        public string AddEmployeeIDS { get; set; }

        public string CreateEmployeeIDS { get; set; }

        public string PayRateEmployeeIDS { get; set; }

        public string TerminatedEmployeeIDS { get; set; }

        public string InactiveEmployeeIDS { get; set; }

        public List<int> lstAddEmployees { get; set; }

        public List<int> lstdeleteEmployees { get; set; }

        public List<int> lstInactiveEmployees { get; set; }

        public List<int> lstPayRate { get; set; }

        public MultiSelectList ddllstAddEmployees { get; set; }

        public List<int> lstCreateEmployees { get; set; }

        public MultiSelectList ddllstCreateEmployees { get; set; }

        public MultiSelectList ddllstDeleteEmployees { get; set; }

        public MultiSelectList ddllstInactiveEmployees { get; set; }

        public IEnumerable<SelectListItem> ddllstLookupTypes { get; set; }

        public string POEmployeeIDS { get; set; }

        public List<int> lstPOEmployees { get; set; }

        public MultiSelectList ddllstPOEmployees { get; set; }

        public string MonthlyCategoryIDS { get; set; }

        public List<int> lstMonthlyCategories { get; set; }

        public string WeeklyCategoryIDS { get; set; }

        public List<int> lstWeeklyCategories { get; set; }

        public MultiSelectList ddllstCategories { get; set; }

        public List<int> lstPayClockRoleIDS { get; set; }

        public List<int> lstPayRateInsertRoleIDS { get; set; }

        public List<int> lstPayRateEditRoleIDS { get; set; }

        public List<int> lstPayRateViewRoleIDS { get; set; }

        public List<int> lstCreateRoleIDS { get; set; }

        public List<int> lstUpdateEmployeeRoleIDS { get; set; }

        public string PayClockRoleIDS { get; set; }

        public string PayRateEditRoleIDS { get; set; }

        public string PayRateInsertRoleIDS { get; set; }

        public string PayRateViewRoleIDS { get; set; }

        public string CreateRoleIDS { get; set; }

        public string UpdateEmployeeRoleIDS { get; set; }

        public List<int> lstUpdateScheduleRoleIDS { get; set; }

        public string UpdateScheduleRoleIDS { get; set; }

        public string InvoiceForceCloseEmployeeIDS { get; set; }

        public List<int> lstInvoiceForceCloseEmployees { get; set; }

        public MultiSelectList ddllstInvoiceForceCloseEmployees { get; set; }

        public string CreateInvoiceWOPOEmployeeIDS { get; set; }

        public List<int> lstWOPOEmployees { get; set; }

        public MultiSelectList ddllstWOPOEmployees { get; set; }

        public string InvoiceExpectionEmployeeIDS { get; set; }

        public string InvoiceCloseEmployeeIDS { get; set; }

        public List<int> lstInvoiceExpectionEmployees { get; set; }

        public List<int> lstInvoiceColsedEmployees { get; set; }

        public MultiSelectList ddllstInvoiceExpectionEmployees { get; set; }

        public string PayClockImportExceptionEmployeeIDS { get; set; }

        public List<int> lstPayClockImportExceptionEmployees { get; set; }

        public string LockingDate { get; set; }

        public string InventoryLockingEditEmployeeIDS { get; set; }

        public List<int> lstInventoryLockingEditEmployees { get; set; }

        public MultiSelectList ddllstLockingEditEmployees { get; set; }
    }
}
