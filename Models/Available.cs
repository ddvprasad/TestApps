using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Models
{
    public class Available
    {
        public int? EmployeeID { get; set; }

        public string EmployeeIDS { get; set; }

        public IEnumerable<SelectListItem> ddllstEmployees { get; set; }

        public int? Month { get; set; }

        public List<SelectListItem> lstMonthNames { get; set; }

        public int? Year { get; set; }

        public List<SelectListItem> lstYears { get; set; }

        public List<SelectListItem> lstEmployees { get; set; }

        public List<AvailableDates> lstAvailableDates { get; set; }
    }

    public class AvailableDates : BaseModel
    {
        public string AvailabilityDate { get; set; }

        public string DayName { get; set; }

        public string Status { get; set; }

        public decimal? AvailableHrs { get; set; }

        public string strAvailableHrs { get; set; }

        public string AvailabilityStartTime { get; set; }

        public string AvailabilityEndTime { get; set; }

        public int? EmployeeID { get; set; }

        public DateTime? Date { get; set; }

        public int? AvailabilityID { get; set; }
    }
}
