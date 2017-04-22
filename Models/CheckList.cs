using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Models
{
    public class CheckList
    {
       public int? ChecklistID { get; set; }

       public string Title { get; set; }

       public int? EmployeeID { get; set; }

       public string EmployeeName { get; set; }

       public string Name { get; set; }

       public List<CheckListItem> lstCheckList { get; set; }

       public List<CheckListItemLog> lstCheckListItemLog { get; set; }

       public string EmployeeIDS { get; set; }

       public List<int> lstEmployees { get; set; }

       public MultiSelectList ddllstEmployees { get; set; }

       public int? ChecklistLineItemID { get; set; }

       public bool SendEmail { get; set; }
    }

    public class CheckListItem
    {
        public string EmployeeName { get; set; }

        public int? CheckListClassID { get; set; }

        public int? ChecklistLineItemID { get; set; }

        public int? CheckListID { get; set; }

        public string CheckListIDEN { get; set; }

        public int? PriorityID { get; set; }

        public string Description { get; set; }

        public string ClassName { get; set; }

        public string ClassCompleted { get; set; }

        public string CssClass { get; set; }

        public string Priority { get; set; }

        public string Title { get; set; }

        public string Date { get; set; }

        public string Time { get; set; }

        public string FileName { get; set; }

        public string FilePath { get; set; }

        public string FileSize { get; set; }

        public string OwnerID { get; set; }

        public Guid? ddlCheckListClass { get; set; }

        public Guid? ddlPriority { get; set; }

        public List<SelectListItem> lstCheckListClass { get; set; }

        public List<SelectListItem> lstPriority { get; set; }

        public List<CheckListItem> lstCheckListMessages { get; set; }

        public string RecipientName { get; set; }

        public string ReceivedDate { get; set; }

        public string Messages { get; set; }

        public bool ReadFlag { get; set; }

        public bool CompletedFlag { get; set; }

        public string Completed { get; set; }

        public string Pending { get; set; }

        public string DueDate { get; set; }

        public bool ClosedFlag { get; set; }
    }
    public class CheckListItemLog
    {
        public string EmployeeName { get; set; }

        public int? ChecklistLineItemID { get; set; }

        public int? CheckListID { get; set; }

        public int? ChecklistLineItemLogID { get; set; }

        public string Response { get; set; }

        public string ReceivedDate { get; set; }

        public int RespondedBy { get; set; }

        public string FilePath { get; set; }

        public string FileName { get; set; }
    }
}
