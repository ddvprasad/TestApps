using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Models
{
    public class Schedule
    {
        public int? ScheduleID { get; set; }

        public string ScheduleIDEN { get; set; }

        //[Required(ErrorMessage = "Select Employee")]
        public int? EmployeeID { get; set; }

        public string EmployeeIDEN { get; set; }

        public List<int> lstEmployeeIDs { get; set; }

        public string EmployeeIDs { get; set; }

        public bool UpdateFlag { get; set; }

        public string EmployeeName { get; set; }

        public int Priority { get; set; }

        public string AdminLevel { get; set; }

        public string ScheduledEmployeeName { get; set; }

        //[Required(ErrorMessage = "Select Schedule Date")]
        public string ScheduleDate { get; set; }

        public DateTime Date { get; set; }

        //[Required(ErrorMessage = "Enter Schedule Hour")]
        public string strScheduledHrs { get; set; }

        public List<SelectListItem> lstEmployees { get; set; }

        //[Required(ErrorMessage = "Select Schedule Start Time")]
        public string ScheduledStartTime { get; set; }

         //[Required(ErrorMessage = "Select Schedule End Time")]
        public string ScheduledEndTime { get; set; }

        // [Required(ErrorMessage = "Select Employee")]
        public decimal? ScheduledHrs { get; set; }

        public string strActualHrsWorked { get; set; }

        public decimal? ActualHrsWorked { get; set; }

        public string ActualStartTime { get; set; }

        //[Required(ErrorMessage = "Enter Availability Hrs")]
        public string ActualEndTime { get; set; }

        public int? ActualHours { get; set; }

       // [Required(ErrorMessage = "Select Availability Start Time")]
        public string BreakMinsInShift { get; set; }

        public string BreakTimeInShift { get; set; }

        public int? PropertyID { get; set; }

        public string PropertyName { get; set; }

        public List<SelectListItem> lstProperties { get; set; }

        public string AddedOn { get; set; }

        public int RoomsCount { get; set; }

        public string Str_Date { get; set; }

        //[Required(ErrorMessage = "Select Availability End Time")]
       // public string AvailabilityEndTime { get; set; }

        public bool IsPayClockHours { get; set; }

        public int iTotal_Records { get; set; }

        public MultiSelectList ddllstEmployees { get; set; }
    }
}
