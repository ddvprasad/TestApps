using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Models
{
    public class Service
    {
        public int? ServiceID { get; set; }

        [Required(ErrorMessage = "Enter Service Name")]
        public string ServiceName { get; set; }

        public string Description { get; set; }

        public string LastServiceDate { get; set; }

        public string NextServiceDate { get; set; }

        public int? LastServiceSetBy { get; set; }

        public int? NextServiceSetBy { get; set; }

        public int AssetsRequired { get; set; }

        public int NumberOfTasks { get; set; }

        public string ServiceIDEN { get; set; }

        public bool ActiveFlag { get; set; }

        public string LastServiceDoneBy { get; set; }

        public bool GeneralServiceFlag { get; set; }

        public string ServiceLocationList { get; set; }

        public List<ServiceTask> lstServiceTasks { get; set; }

        //public List<int> lstServiceLocation { get; set; }

        //public MultiSelectList ddlServiceLocation { get; set; }

        public List<ServiceLocation> lstServiceLocation { get; set; }


        public string IsFrom { get; set; }
    }


    


    public class ServiceTask
    {
        public int? ServiceTaskID { get; set; }

        public int? ServiceID { get; set; }

        public string TaskName { get; set; }

        public string TaskDescription { get; set; }

        public string TargetHours { get; set; }

        public string Instructions { get; set; }

        public string ItemNames { get; set; }

        public string SafetyandRestrictions { get; set; }

        public int Order { get; set; }

        public string TaskItemList { get; set; }

        public List<int> lstTaskItems { get; set; }

        public MultiSelectList ddlTaskItems { get; set; }

        public List<ServiceTaskItem> lstServiceTaskItems { get; set; }
    }


   

    public class ServiceTaskItem
    {
        public int? ServiceTaskItemID { get; set; }

        public int? ServiceTaskID { get; set; }

        public int? ServiceID { get; set; }

        public int ItemID { get; set; }

        public string ItemName { get; set; }

        public string RelatedTo { get; set; }

        public int QuantityRequired { get; set; }
    }

    public class ServiceLocation
    {
        public int? ServiceLocationID { get; set; }

        public int? ServiceID { get; set; }

        public int LocationID { get; set; }

        public string LocationName { get; set; }

        public string RelatedTo { get; set; }
    }
}


    