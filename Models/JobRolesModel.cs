using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Models
{
    public class JobRolesParentModel
    {
        public string Success_Message { get; set; }

        public string Error_Message { get; set; }
    }

    public class JobRolesModel
    {
        public int Account_ID { get; set; }

        public int Job_Role_ID { get; set; }

        public string Job_Role_ID_EN { get; set; }

        public int? Job_Level_ID { get; set; }

        [Required(ErrorMessage = "Enter  Job Role")]
        public string Job_Role_Name { get; set; }

        [Required(ErrorMessage = "Select  Manager Level")]
        public bool Manager_Level_Flag { get; set; }

        public string Salary_Range_From { get; set; }

        public string Salary_Range_To { get; set; }

        public string Benefits { get; set; }

        [AllowHtml]
        public string Job_Description { get; set; }

        [AllowHtml]
        public string Job_Responsibilities { get; set; }

        [AllowHtml]
        public string Job_Competence { get; set; }

        [AllowHtml]
        public string Job_Experience { get; set; }

        public int? Created_By { get; set; }

        public string Job_Role_Level { get; set; }

        public List<SelectListItem> lstJobLevel { get; set; }

        public string Str_Manager { get; set; }
        public string Qualifications { get; set; }

    }
}
