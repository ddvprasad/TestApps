using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Models
{
    public class Employee
    {
        #region Constants

        public const string CONST_EMPLOYEE_ID = "EmployeeID";

        #endregion Constants

        public int? CompanyID { get; set; }

        public string CompanyName { get; set; }

        public string ScreenName { get; set; }

        public int? EmployeeID { get; set; }

        public int? EmployeeTypeID { get; set; }

        public string EmployeeIDEN { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public string EmployeeName { get; set; }

        public string EmployeeAddress { get; set; }

        public string EmployeeAddress2 { get; set; }

        public string EmployeeCity { get; set; }

        public string EmployeeState { get; set; }

        public string Employeezip { get; set; }

       //[Required(ErrorMessage = "Enter User Name")]
        public string UserName { get; set; }

        public string Prefix { get; set; }

        public string Suffix { get; set; }

       // public bool Gender { get; set; }

        public int? Gender { get; set; }

        //[Required(ErrorMessage = "Enter Email")]
        //[RegularExpression(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$", ErrorMessage = "Enter valid email")]
        public string Email { get; set; }

        public string Password { get; set; }

        public string PhoneNumber { get; set; }

        public string RoleName { get; set; }

        public int? RoleID { get; set; }

        public string MobileNumber { get; set; }

        public string PropertyLogName { get; set; }

        public int? PropertyLogID { get; set; }

        public string Address2 { get; set; }

        public string Address1 { get; set; }

        public string City { get; set; }

        public string Zipcode { get; set; }

        public string StateCode { get; set; }

        public string StateText { get; set; }

        public string Country { get; set; }

        public string ProfileImage { get; set; }

        public List<SelectListItem> lstRoles { get; set; }

        public List<SelectListItem> lstCompanies { get; set; }

        public bool ActiveFlag { get; set; }

        public bool AllowLoginFlag { get; set; }

        public bool? MenuVisibleFlag { get; set; }

        public bool EmailSentFlag { get; set; }

        public string ErrorMessage { get; set; }

        public List<SelectListItem> lstCountries { get; set; }

        public List<SelectListItem> lstStates { get; set; }

        public string PasswordEN { get; set; }

        public string DefaultGridSize { get; set; }

        public string AdminLevel { get; set; }

        public string EmployeeSSN { get; set; }

        public string EmployeeSSNEncrypt { get; set; }

        public string EmployeeNumber { get; set; }

        public bool ProfileFlag { get; set; }

        public string ScreenFlag { get; set; }

        public string Property { get; set; }

        public string EmployeeType { get; set; }

        public bool ObamaCareopted { get; set; }

        public bool ObamaCareOffered { get; set; }

        public bool NewEmployeeFlag { get; set; }

        public string JoiningDate { get; set; }

        public string TerminateDate { get; set; }

        public List<SelectListItem> lstEmployeTypes { get; set; }

        public string ReportingEmployeeEmail { get; set; }

        public int? ReportingEmployeeID { get; set; }

        public List<SelectListItem> lstEmployees { get; set; }

        //[Required(ErrorMessage = "Select Property")]

        public int? PropertyID { get; set; }

        public int? Priority { get; set; }

        public int? PropertyCount { get; set; }

        public string PropertyName { get; set; }

        public List<SelectListItem> lstProperties { get; set; }

        public List<SelectListItem> lstGenders { get; set; }

        public string DateofBirth { get; set; }

        public string County { get; set; }

        public string ClassDocument { get; set; }

        public int? EmployeePaymentTypeID { get; set; }

        public List<SelectListItem> lstEmployePaymentTypes { get; set; }

        public int? DocumentID { get; set; }

        public IEnumerable<SelectListItem> lstPropertyPolicies { get; set; }

        public List<SelectListItem> lstDocumentTypes { get; set; }

        public decimal? EmployeePayRateHourly { get; set; }

        public decimal? EmployeePayRateHourlyOld { get; set; }

        public string Reason { get; set; }

        public decimal? EmployeePayRateYearly { get; set; }

        public int? MaxHoursToWork { get; set; }

        public int? MinHoursToWork { get; set; }

        public List<Menu> lstMenu { get; set; }

        public List<Widget> lstWidgets { get; set; }

        public string PropertyshceduleStartTime { get; set; }

        public string PropertyshceduleEndTime { get; set; }

        public int? UserLoginHistoryID { get; set; }

        public string LoginDate { get; set; }

        public string LogInTime { get; set; }

        public string LogoutTime { get; set; }

        public string IP { get; set; }

        public string POPrefix { get; set; }

        //public bool IsTerminated { get; set; }

        public int? EmploymentStatusID { get; set; }

        public int? EmploymentCurrentStatusID { get; set; }

        public List<SelectListItem> lstEmploymentStatus { get; set; }

        public bool IsEmployeeExist { get; set; }

        public bool InsertPayRateFlag { get; set; }

        public bool EditPayRateFlag { get; set; }

        public MultiSelectList ddllstRoles { get; set; }

        public List<int> lstAdditionalRoleIDS { get; set; }

        public string AdditionalRoleIDS { get; set; }

        public bool IsEditEmployeeflag { get; set; }

        public bool IsLoggedIn { get; set; }

    }

    public class BirthdayEmployees
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Date { get; set; }
    }

    public class EmployementModel
    {

        public int? Account_ID { get; set; }

        public int? Employee_ID { get; set; }

        public int? Department_ID { get; set; }

        [Required(ErrorMessage = "Select Job Role")]
        public int? Designation_ID { get; set; }

        [Required(ErrorMessage = "Select Location")]
        public int? Location_ID { get; set; }

        public string Employee_ID_EN { get; set; }

        public string Work_Location { get; set; }

        public int? Source_Of_Hire { get; set; }

        public int? Reporting_To { get; set; }

        [Required(ErrorMessage = "Select Employment Status")]
        public int? Employee_Status { get; set; }

        [Required(ErrorMessage = "Select Job Type")]
        public string Employee_Type { get; set; }

        [Required(ErrorMessage = "Select Start Date")]
        public string Join_Date { get; set; }

        public string End_Date { get; set; }

        public int? Shift_ID { get; set; }

        public List<SelectListItem> lstPaymentInterval { get; set; }

        public List<SelectListItem> lstSalaryAmountTypes { get; set; }

        public string Error_Message { get; set; }

        public string Message { get; set; }

        public string Department_Name { get; set; }

        public string Designation_Name { get; set; }

        public string Employee_Name { get; set; }

        public string Date_Format { get; set; }

        public decimal? Salary_Rate { get; set; }

        public decimal? Salary_Rate_New { get; set; }

        public string Salary_Rate_New_str { get; set; }

        public List<SelectListItem> lstDepartments { get; set; }

        public List<SelectListItem> lstDesignations { get; set; }

        public List<SelectListItem> lstEmployeeStatus { get; set; }

        public List<SelectListItem> lstEmployeeTypes { get; set; }

        public List<SelectListItem> lstSourceOfHire { get; set; }

        public List<SelectListItem> lstEmployees { get; set; }

        public List<SelectListItem> lstLocations { get; set; }

        public List<Menu> lstMenuModel { get; set; }

        public string Currency { get; set; }

        public string Screen_Flag { get; set; }

        public string Shift_Start_Time { get; set; }

        public string Shift_End_Time { get; set; }

        public DateTime? Joining_Date { get; set; }

        public List<SelectListItem> lstDates { get; set; }

        public List<SelectListItem> lstShifts { get; set; }

        public string Password_EN { get; set; }

        public string Default_Grid_Size { get; set; }

        public int? Holidays { get; set; }

        public bool Appraisal_Flag { get; set; }

        public string Terms_Of_Contract { get; set; }

        public int? Payment_Interval { get; set; }

        public string New_Sal_Amt_Reason { get; set; }

        public decimal? New_Salary_Amount { get; set; }

        public int? Salary_Amount_Type { get; set; }


    }

    public class EmployeeWorkExperienceModel
    {
        public int? Employee_ID { get; set; }

        public int? Account_ID { get; set; }

        public int Employee_Experience_ID { get; set; }

        [Required(ErrorMessage = "Enter Previous Company Name")]
        public string Previous_Company_Name { get; set; }

        [Required(ErrorMessage = "Select Job Role")]
        public int? Job_Title { get; set; }

        public string Job_Name { get; set; }

        [Required(ErrorMessage = "Select From Date")]
        public string From_Date { get; set; }

        [Required(ErrorMessage = "Select To Date")]
        public string To_Date { get; set; }

        public string Job_Description { get; set; }

        public string Date_Format { get; set; }

        [Required(ErrorMessage = "Enter Company Address")]
        public string Company_Address { get; set; }

        public string Zipcode { get; set; }

        public string State_Code { get; set; }

        public string State_Text { get; set; }

        public string Country { get; set; }

        public List<SelectListItem> lstDesignations { get; set; }

        public List<SelectListItem> lstCountries { get; set; }

        public List<SelectListItem> lstStates { get; set; }

        public List<SelectListItem> lstJobRoles { get; set; }
    }

    public class EmployeeEducationModel
    {
        public int? Employee_ID { get; set; }

        public int? Account_ID { get; set; }

        public int Employee_Education_ID { get; set; }

        [Required(ErrorMessage = "Enter Institution Name")]
        public string Institution_Name { get; set; }

        [Required(ErrorMessage = "Enter Qualification")]
        public string Qualification { get; set; }

        [Required(ErrorMessage = "Enter Completion Year")]
        public string Completion_Year { get; set; }

        public string Study_Duration { get; set; }

        public string Additional_Notes { get; set; }

        public string Interests { get; set; }

        public string Date_Format { get; set; }

        public string strFile_Path { get; set; }
    }

    public class EmployeeContactModel
    {
        public int? Employee_ID { get; set; }

        public int? Account_ID { get; set; }

        public int Employee_Contact_ID { get; set; }

        public string Name_Contact { get; set; }

        [Required(ErrorMessage = "Enter First Name")]
        public string First_Name_Contact { get; set; }

        [Required(ErrorMessage = "Enter Last Name")]
        public string Last_Name_Contact { get; set; }

        public string Prefix { get; set; }

        [Required(ErrorMessage = "Select Relationship")]
        public int? RelationShip { get; set; }

        public string Relationship_Name { get; set; }

        [Required(ErrorMessage = "Enter Mobile Number")]
        public string Mobile_Number_Contact { get; set; }

        public string Home_Number_Contact { get; set; }

        public string Date_Format { get; set; }

        public string Address2_Contact { get; set; }

        [Required(ErrorMessage = "Enter Address 1")]
        public string Address1_Contact { get; set; }

        public string City_Contact { get; set; }

        public string Zipcode_Contact { get; set; }

        public string State_Code_Contact { get; set; }

        public string State_Text_Contact { get; set; }

        public string Country_Contact { get; set; }

        public List<SelectListItem> lstRelations { get; set; }

        public List<SelectListItem> lstPrefixes { get; set; }

        public List<SelectListItem> lstCountries { get; set; }

        public List<SelectListItem> lstStates { get; set; }
    }
    
    public class EmployeeAddressModel
    {
        public int Address_ID { get; set; }

        public int? Employee_ID { get; set; }

        public int? Account_ID { get; set; }

        [Required(ErrorMessage = "Select Address Type")]
        public int? Address_Type { get; set; }

        public string Address_Type_Name { get; set; }

        public string Address2 { get; set; }

        [Required(ErrorMessage = "Enter Address1")]
        public string Address1 { get; set; }

        [Required(ErrorMessage = "Enter City")]
        public string City { get; set; }

        [Required(ErrorMessage = "Enter Zipcode")]
        public string Zipcode { get; set; }

        public string State_Code_Address { get; set; }

        public string State_Text_Address { get; set; }

        public string Country_Address { get; set; }

        public bool Active_Flag { get; set; }

        public string Class_Name { get; set; }

        public int? Created_By { get; set; }

        public List<SelectListItem> lstAddressTypes { get; set; }

        public List<SelectListItem> lstCountries { get; set; }

        public List<SelectListItem> lstStates { get; set; }
    }

    public class EmployeeBankDetailsModel
    {
        public int Bank_Details_ID { get; set; }

        public int? Employee_ID { get; set; }

        public int? Account_ID { get; set; }

        [Required(ErrorMessage = "Enter Display Name")]
        public string Display_Name { get; set; }

        [Required(ErrorMessage = "Enter Bank Name")]
        public string Bank_Name { get; set; }

        [Required(ErrorMessage = "Enter Bank Account Number")]
        public string Bank_Account_No { get; set; }

        public string Bank_Address { get; set; }

        public string Bank_Sort_Code { get; set; }

        public string Comments { get; set; }

        public bool Active_Flag { get; set; }

        public string Active { get; set; }

        public string Class_Name { get; set; }

        public int? Created_By { get; set; }


    }

    public class EmployeeWorkLocationModel
    {
        public int Employee_Work_Location_ID { get; set; }

        public int? Employee_ID { get; set; }

        public int? Account_ID { get; set; }

        [Required(ErrorMessage = "Select Work Location ")]
        public int Work_Location { get; set; }

        public string Location_Name { get; set; }

        [Required(ErrorMessage = "Enter Address1")]
        public string Address1_Work_Location { get; set; }

        public string Address2_Work_Location { get; set; }

        [Required(ErrorMessage = "Select Contract Start Date")]
        public string Contract_Start_Date { get; set; }

        public string Contract_End_Date { get; set; }

        public string Date_Format { get; set; }

        [Required(ErrorMessage = "Enter City")]
        public string City_WorkLocation { get; set; }

        [Required(ErrorMessage = "Enter Postcode")]
        public string Zipcode_WorkLocation { get; set; }

        public string State_Code_WorkLocation { get; set; }

        public string State_Text_WorkLocation { get; set; }

        [Required(ErrorMessage = "Select Country")]
        public string Country_WorkLocation { get; set; }

        public int? Created_By { get; set; }

        public List<SelectListItem> lstCountries { get; set; }

        public List<SelectListItem> lstStates { get; set; }

        public List<SelectListItem> lstWorkLocations { get; set; }

    }

    public class ReferenceModel
    {
        public int? Employee_ID { get; set; }

        public int? Account_ID { get; set; }

        public int Reference_ID { get; set; }

        [Required(ErrorMessage = "Enter  Name")]
        public string Name_Reference { get; set; }

        [Required(ErrorMessage = "Enter Company Name")]
        public string Company_Name { get; set; }

        [Required(ErrorMessage = "Enter  Email")]
        [RegularExpression(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$", ErrorMessage = "Enter valid email")]
        public string Email_Reference { get; set; }

        public string Address1_Reference { get; set; }

        [Required(ErrorMessage = "Select Reference Type ")]
        public int? Reference_Type { get; set; }

        public string Reference_Type_Name { get; set; }

        [Required(ErrorMessage = "Select Job Role ")]
        public int? Job_Role_Reference { get; set; }

        public int? Work_Duration_Years { get; set; }

        public int? Work_Duration_Months { get; set; }

        public bool Willing_Emp_Again { get; set; }

        public string Date_Format { get; set; }

        public string strFile_Path_Reference { get; set; }

        public List<SelectListItem> lstDesignations { get; set; }

        public List<SelectListItem> lstReferenceTypes { get; set; }

        public List<SelectListItem> lstDurationYears { get; set; }

        public List<SelectListItem> lstDurationMonths { get; set; }

        public List<SelectListItem> lstJobRoles { get; set; }

    }

    public class EmployeeDocumentsModel
    {
        public int? Employee_ID { get; set; }

        public int? Account_ID { get; set; }

        public int Document_ID { get; set; }

        //[Required(ErrorMessage = "Enter Document Name")]
        public string Document_Name { get; set; }

        public string Date { get; set; }

        public string Document_Type_Name { get; set; }

        //[Required(ErrorMessage = "Select Document Type ")]
        public int? Document_Type { get; set; }

        public string strFile_Path_Document { get; set; }

        public string Date_Format { get; set; }

        public List<SelectListItem> lstDocumentTypes { get; set; }


    }

    public class EmployeeIdentityDetailsModel
    {
        public int Employee_ID { get; set; }

        public int Account_ID { get; set; }

        public int Passport_Details_ID { get; set; }

        [Required(ErrorMessage = "Select NI_Status")]
        public int? NI_Status { get; set; }

        [Required(ErrorMessage = "Select Passport Status")]
        public int? Passport_Status { get; set; }

        [Required(ErrorMessage = "Enter NI Number")]
        public string NI_Number { get; set; }

        public List<SelectListItem> lstNIstatus { get; set; }

        public List<SelectListItem> lstNationality { get; set; }

        public List<SelectListItem> lstPassportStatus { get; set; }

        [Required(ErrorMessage = "Enter Passport Number")]
        public string Passport_Number { get; set; }

        [Required(ErrorMessage = "Enter Place Of Issue")]
        public string Place_Of_Issue { get; set; }

        [Required(ErrorMessage = "Select Date Of Issue")]
        public string Date_Of_Issue { get; set; }

        [Required(ErrorMessage = "Select Date Of Expiry ")]
        public string Date_Of_Expiry { get; set; }

        [Required(ErrorMessage = "Enter Nationality")]
        public string Nationality { get; set; }

        public int? Nationality_ID { get; set; }

        public string Special_Notes { get; set; }

        public string Upload_Image_Passport { get; set; }

        public string Date_Format { get; set; }
    }

    public class EmployeeIdentityVisaDetailsModel
    {
        public int? Employee_ID { get; set; }

        public int? Account_ID { get; set; }

        public int Visa_Details_ID { get; set; }

        [Required(ErrorMessage = "Select Visa Category")]
        public int Visa_Category { get; set; }

        [Required(ErrorMessage = "Enter Visa Number")]
        public string Visa_Number { get; set; }

        public string Visa_Category_Name { get; set; }

        [Required(ErrorMessage = "Select Visa Issue Date")]
        public string Visa_Issue_Date { get; set; }

        [Required(ErrorMessage = "Select Visa Expiry Date")]
        public string Visa_Expiry_Date { get; set; }

        public string Date_Format { get; set; }

        public string Special_Notes { get; set; }

        public string Upload_Image_Visa { get; set; }

        public List<SelectListItem> lstVisaCategory { get; set; }
        
    }

    public class EmployeeIdentityCOSDetailsModel
    {
        public int? Employee_ID { get; set; }

        public int? Account_ID { get; set; }

        public int COS_Details_ID { get; set; }

        public string Upload_Image_COS { get; set; }

        public string Special_Notes { get; set; }

        [Required(ErrorMessage = "Select COS Start Date")]
        public string COS_Start_Date { get; set; }

        [Required(ErrorMessage = "Select COS End Date")]
        public string COS_End_Date { get; set; }

        public string Date_Format { get; set; }



    }

}