using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Models
{
    public class WorkOrder : BaseModel
    {

        public int WorkOrderID { get; set; }

        public string WorkOrderIDEN { get; set; }
        
        public int CompanyID { get; set; }

        public int PropertyID { get; set; }

        public string Number { get; set; }

        public string Description { get; set; }

        public string WOServiceName { get; set; }

        public int NumberOfTasks { get; set; }

        public int AssignedTo { get; set; }

        public string AssignedName { get; set; }

        public int? Status { get; set; }

        public string StatusName { get; set; }

        public DateTime? StartDateTime { get; set; }

        public DateTime? EndDateTime { get; set; }

        public decimal EstimatedHours { get; set; }

        public decimal ActualHours { get; set; }

        public bool FreezeFlag { get; set; }

        public DateTime? AddedOn { get; set; }

        public int AddedBy { get; set; }

        public string AddedByName { get; set; }

        public string IsFrom { get; set; }

        public string ServiceIDS { get; set; }

        public int? LocationID { get; set; }

        public string RelatedTo { get; set; }

        public int? FloorID { get; set; }

        public List<int> lstServices { get; set; }

        public List<SelectListItem> lstAssignedTo { get; set; }

        public MultiSelectList ddllstServices { get; set; }

        public List<WorkOrderLocation> lstWorkOrderLocation { get; set; }

        public List<WorkOrderTask> lstWOTasks { get; set; }

        public string WorkOrderLocationList { get; set; }

        public List<SelectListItem> lstStatus { get; set; }

        public List<WorkOrderParts> lstWOTaskItems { get; set; }

        public int TotalRecords { get; set; }

        public string SearchText { get; set; }

        public int CreatedBy { get; set; }

        public string Submit_Type { get; set; }
    }

    public class WorkOrderLocation
    {
        public int? WOLocationID { get; set; }

        public int? WorkOrderID { get; set; }

        public int? LocationID { get; set; }

        public string LocationName { get; set; }

        public int FloorID { get; set; }

        public string RelatedTo { get; set; }

        public string Notes { get; set; }

        public int? Status { get; set; }
    }


    public class WorkOrderTask
    {
        public int WOTaskID { get; set; }

        public int WorkOrderID { get; set; }

        public string RelatedTo { get; set; }

        public int? LocationID { get; set; }

        public int FloorID { get; set; }

        public string Name { get; set; }

        public string ItemNames { get; set; }

        public string Description { get; set; }

        public int? QuantityRequired { get; set; }

        public string TargetHours { get; set; }

        public int? Status { get; set; }

        public int? Type { get; set; }

        public string Instructions { get; set; }

        public string SafetyandRestrictions { get; set; }

        public int Order { get; set; }

        public string Notes { get; set; }

        public int CreatedBy { get; set; }

        public string ResultMessage { get; set; }

        public DateTime? CreatedOn { get; set; }

        public string TaskItemList { get; set; }

        public List<int> lstTaskItems { get; set; }

        public MultiSelectList ddlTaskItems { get; set; }

        public List<WorkOrderParts> lstWOTaskItems { get; set; }


    }
    public class WorkOrderParts
    {
        public int WOTaskId { get; set; }

        public int ItemID { get; set; }

        public string ItemName { get; set; }

        public int QuantityRequired { get; set; }

        public int QuantityUsed { get; set; }
    }
}


