using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Models
{
    public class Candidates
    {
        public int CompanyID { get; set; }

        public int CandidateID { get; set; }

        [Required(ErrorMessage = "Select Stage")]
        public int? RecruitmentStageID { get; set; }

        public string CandidateIDEN { get; set; }

        public string DateFormat { get; set; }

        //public string Town { get; set; }

        [Required(ErrorMessage = "Select  Post Applied For")]
        public int? RequisitionID { get; set; }

        [Required(ErrorMessage = "Select Available Date")]
        public string AvailabilityDate { get; set; }

        [Required(ErrorMessage = "Enter First Name")]
        public string FirstName { get; set; }

        public string HomeTelephone { get; set; }

        [Required(ErrorMessage = "Enter Personal Mobile")]
        public string PersonalPhone { get; set; }

        [Required(ErrorMessage = "Enter Personal Email")]
        [RegularExpression(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$", ErrorMessage = "Enter valid email")]
        public string PersonalEmail { get; set; }

        
        [Required(ErrorMessage = "Enter Last Name")]
        public string LastName { get; set; }

        public string PostApplied { get; set; }

        public string Reference { get; set; }

        public string Stage { get; set; }

        //public string Date { get; set; }

        public string MiddleName { get; set; }

        public string Prefix { get; set; }

        public string DOB { get; set; }

        public string NationalInsurance { get; set; }

        [Required(ErrorMessage = "Enter Nationality")]
        public string Nationality { get; set; }

        public bool MartialStatus { get; set; }

        [Required(ErrorMessage = "Enter Address1")]
        public string Address1 { get; set; }
         
        public string Address2 { get; set; }

        [Required(ErrorMessage = "Enter City")]
        public string City { get; set; }

        public string CVFileContent { get; set; }

        //[Required(ErrorMessage = "Select State")]
        public string StateCodeAddress { get; set; }

       // [Required(ErrorMessage = "Enter State")]
        public string StateTextAddress { get; set; }

        [Required(ErrorMessage = "Enter Zip")]
        public string Zip { get; set; }

        [Required(ErrorMessage = "Select Country")]
        public string Country { get; set; }

        public bool Gender { get; set; }

        public bool AccesstoCar { get; set; }

        public bool DrivingLicence { get; set; }

        public bool RighttoWork { get; set; }

        public string CVFilePath { get; set; }

        public List<SelectListItem> lstPostApplied { get; set; }

        public List<SelectListItem> lstStages { get; set; }

        public List<SelectListItem> lstStates { get; set; }

        public List<SelectListItem> lstCountries { get; set; }

        public IEnumerable<SelectListItem> lstTitle { get; set; }

        public List<SelectListItem> lstNationality { get; set; }

        //public List<SelectListItem> lstMaritalStatus { get; set; }
    }
}
