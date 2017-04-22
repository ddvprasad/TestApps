using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Models
{
    public class JobOffers
    {
        public int JobOfferID { get; set; }

        public int CompanyID { get; set; }

        [Required(ErrorMessage = "Select Candidate")]
        public int? CandidateID { get; set; }

        public string JobOfferIDEN { get; set; }

        [Required(ErrorMessage = "Select Post Applied For")]
        public int? RequisitionID { get; set; }

        [Required(ErrorMessage = "Select Job Title")]
        public int? JobRoleID { get; set; }

        [Required(ErrorMessage = "Select Employement Status")]
        public int? JobTypeID { get; set; }

        public int? DepartmentID { get; set; }

        public int? LocationID { get; set; }

        public int? ManagerID { get; set; }

        [Required(ErrorMessage = "Enter Job Location")]
        public string Location { get; set; }

        [Required(ErrorMessage = "Enter Salary")]
        public decimal? Salary { get; set; }

        [Required(ErrorMessage = "Select Salary Interval")]
        public int? SalaryInterval { get; set; }

        [Required(ErrorMessage = "Enter Annual Holidays")]
        public decimal? HolidaysAnum { get; set; }

        [Required(ErrorMessage = "Enter Hours per week")]
        public decimal? HoursPerWeek { get; set; }

        [Required(ErrorMessage = "Select Start Date")]
        public string StartDate { get; set; }

        [Required(ErrorMessage = "Enter Probationary Period")]
        public string ProbationaryPeriod { get; set; }

        public string Date { get; set; }

        public string Requisition { get; set; }

        public string Candidate { get; set; }

        public string JobTitle { get; set; }
         
        public string DateFormat { get; set; } 

        public List<SelectListItem> lstCandidates { get; set; }

        public List<SelectListItem> lstPostAppliedFor { get; set; }

        public List<SelectListItem> lstJobTitles { get; set; }

        public List<SelectListItem> lstJobTypes { get; set; }

        public List<SelectListItem> lstDepartments { get; set; }

        public List<SelectListItem> lstLocations { get; set; }

        public List<SelectListItem> lstManagers { get; set; }

        public List<SelectListItem> lstSalaryIntervels { get; set; } 
    }
}
