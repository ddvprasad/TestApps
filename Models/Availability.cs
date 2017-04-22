using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Models
{
    public class Availability
    {
        public int? AvailabilityID { get; set; }

        public string AvailabilityIDEN { get; set; }

        [Required(ErrorMessage = "Select Availability Date")]
        public string AvailabilityDate { get; set; }

        public DateTime Date { get; set; }

        public IEnumerable<SelectListItem> ddllstEmployees { get; set; }

        //[Required(ErrorMessage = "Select Employee")]
        public int? EmployeeID { get; set; }

        public string EmployeeIDS { get; set; }

        [Required(ErrorMessage = "Select Employee")]
        public string strEmployeeIDS { get; set; }

        public List<SelectListItem> lstEmployees { get; set; }

        public int? Month { get; set; }

        public List<SelectListItem> lstMonthNames { get; set; }

        public int? Year { get; set; }

        public List<SelectListItem> lstYears { get; set; }

        public int? CompanyID { get; set; }

        public string CompanyName { get; set; }

        public string EmployeeName { get; set; }

        public bool AvailablityStatus { get; set; }

        [Required(ErrorMessage = "Enter Available Hours")]
        public decimal? AvailableHrs { get; set; }

        [Required(ErrorMessage = "Enter Available Hours")]
        public string strAvailableHrs { get; set; }

         [Required(ErrorMessage = "Select Start Time")]
        public string AvailabilityStartTime { get; set; }

        [Required(ErrorMessage = "Select End Time")]
        public string AvailabilityEndTime { get; set; }

        public int? Priority { get; set; }

    }

    public class AvailabilityList : BaseModel
    {
        public int EmployeeID { get; set; }

        public int Month { get; set; }

        public int Year { get; set; }

        public int Priority { get; set; }

        public List<AvailabilityDates> lstAvailabilityDates { get; set; }

    }

    public class AvailabilityDates : BaseModel
    {
        public string AvailabilityDate { get; set; }

        public decimal? AvailableHrs { get; set; }

        public string strAvailableHrs { get; set; }

        public string AvailabilityStartTime { get; set; }

        public string AvailabilityEndTime { get; set; }

    }
}
