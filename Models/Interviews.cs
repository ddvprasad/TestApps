using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Models
{
    public class Interviews
    {
        public int CompanyID { get; set; }

        public int InterviewStatus { get; set; }

        public string Status { get; set; }

        [Required(ErrorMessage = "Select Candidate")]
        public int? CandidateID { get; set; }

        [Required(ErrorMessage = "Select Interviewer")]
        public int? InterviewerID { get; set; }

         
        public int InterviewID { get; set; }

        public string InterviewIDEN { get; set; }

        public string DateFormat { get; set; }

        [Required(ErrorMessage = "Select Date")]
        public string Date { get; set; }
        
        [Required(ErrorMessage = "Select  Post Applied For")]
        public int? RequisitionID { get; set; }

        
        public string Time { get; set; }

        [Required(ErrorMessage = "Select Time Hours")]
        public string TimeHours { get; set; }

        [Required(ErrorMessage = "Select Time Minutes")]
        public string TimeMinutes { get; set; }

        [Required(ErrorMessage = "Enter  Location")]
        public string Location { get; set; }

        public string Comments { get; set; }

        public string Candidate { get; set; }

        public string Reference { get; set; }

        public string Interviewer { get; set; }

        public List<SelectListItem> lstPostApplied { get; set; }

        public List<SelectListItem> lstCandidates { get; set; }

        public List<SelectListItem> lstInterviewer { get; set; }

        public List<SelectListItem> lstTimeHours { get; set; }

        public List<SelectListItem> lstTimeMinutes { get; set; }

        public List<SelectListItem> lstInterviewStatus { get; set; } 
    }
}
