using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Models
{
    public class Requisitions
    {
        public int AccountID { get; set; }

        [Required(ErrorMessage = "Select Job Role")]
        public int JobRoleID { get; set; }

        public string RequisitionIDEN { get; set; }

        public int RequisitionID { get; set; }

        public bool RequisitionStatus { get; set; }

        public string ActiveFromDate { get; set; }

        [Required(ErrorMessage = "Enter Reference ")]
        public string ReferenceNumber { get; set; }

        public int DepartmentID { get; set; }

        [Required(ErrorMessage = "Select Job Type")]
        public int JobTypeID { get; set; }

        public int? HiringManagerID { get; set; }

        [Required(ErrorMessage = "Enter Location")]
        public string Location { get; set; }

        [Required(ErrorMessage = "Enter Salary Range From")]
        public string SalaryRangeFrom { get; set; }

        [Required(ErrorMessage = "Enter Salary Range To")]
        public string SalaryRangeTo { get; set; }

        [Required(ErrorMessage = "Select Job Start Date")]
        public string JobStartDate { get; set; }

        public string ClosingDate { get; set; }

        [Required(ErrorMessage = "Enter Contact Name")]
        public string ContactName { get; set; }

        [Required(ErrorMessage = "Enter Email")]
        [RegularExpression(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$", ErrorMessage = "Enter valid email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter Telephone Number")]
        public string PhoneNumber { get; set; }

        public string OtherDetails { get; set; }

        public string JobTitle { get; set; }

        public string Department { get; set; }
         
        public string JobTypeName { get; set; }

        public string CandidatesCount { get; set; }

        public string DateFormat { get; set; }

        public List<SelectListItem> lstDepartment { get; set; }

        public List<SelectListItem> lstJobRoles { get; set; }

        public List<SelectListItem> lstJobTypes { get; set; }

        public List<SelectListItem> lstHiringManager { get; set; }  

    }
}
