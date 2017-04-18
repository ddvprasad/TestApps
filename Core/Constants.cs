
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public static class AppSettings
    {
        public static string DATE_FORMAT = "MM/dd/yyyy";

        public static string DATE_FORMAT_LONG = "dd-MMM-yyyy";

        public static string DATE_TIME_FORMAT = "MM/dd/yyyy HH:mm";

        public static string DATE_TIME_FORMAT1 = "MM/dd/yyyy h:mm tt";

        public static string TIME_FORMAT_COMMON = "h:mm tt";

        public static string TIME_FORMAT = @"hh\:mm\:ss";

        public static string RATE_FORMAT = "00.00";

        public static string COMMA_SEPARATOR = "#,##0.00";

        public static string COMMA_SEPARATOR_NON_DECIMAL = "#,##0";

        public static string COMMA_SEPARATOR_RATE_FORMAT_FIVE = "###,###.#####";

        public static string ROTATIVA_PDF_FOOTER = "--footer-right \"Page: [page]/[toPage]\"" +
                  " --footer-font-size \"8\" --footer-spacing 3 --footer-font-name \"calibri light\"";
    }

    public static class Messages
    {
        public static string PASSWORD_CHANGED_SUCCESS = "Password changed successfully.";

        public static string PASSWORD_RESET_LINK_EMAIL = "A password reset link has been sent to your email";

        public static string ROLE_INFORMATION_SAVED_SUCCESS = "Role information saved successfully";

        public static string AUDIT_INFORMATION_SAVED_SUCCESS = "Audit information saved successfully ";

        public static string USER_INFORMATION_SAVED_SUCCESS = "User information saved successfully";

        public static string PURCHASE_ORDER_SAVED_SUCCESS = "Purchase order saved successfully";

        public static string INVENTORY_SAVED_SUCCESS = "Inventory saved successfully";

        public static string INVOICE_SAVED_SUCCESS = "Invoice saved successfully";

        public static string SAVED_SUCCESS = "saved successfully";

        public static string SAVED_CLOSE_SUCCESS = "Save & Closed successfully";

        public static string EMPLOYMENT_INFORMATION_SAVED_SUCCESS = "Employment information saved successfully";

        public static string EMAIL_SENT_SUCCESS = "Email sent successfully";

        public static string AVAILABILITY_SAVED_SUCCESS = "Availability saved successfully";

        public static string PROPERTY_INFORMATION_SAVED_SUCCESS = "Property information saved successfully";

        public static string ROOM_INFORMATION_SAVED_SUCCESS = "Room information saved successfully";

        public static string ROOM_ITEM_SAVED_SUCCESS = "Room Items saved successfully";

        public static string REGISTRATION_INFORMATION_SAVED_SUCCESS = "Registration information saved successfully";

        public static string COMPANY_INFORMATION_SAVED_SUCCESS = "Company information saved successfully";

        public static string SCHEDULE_INFORMATION_SAVED_SUCCESS = "Schedule information saved successfully";

        public static string DOCUMENT_SAVED_SUCCESS = "Document saved successfully";

        public static string PROPERTY_CHANGED_SUCCESS = "Property changed successfully";

        public static string DOCUMENT_UPDATED = "Document Updated";

        public static string DOCUMENT_ADDED = "Document Added";

        public static string DOCUMENT_DELETED = "Document Deleted";

        public static string EMPLOYEE_SUCCESS = "Employee Created successfully";

        public static string SERVICE_SAVED_SUCCESS = "Service saved successfully";

        public static string SERVICE_TASK_SAVED_SUCCESS = "Service task saved successfully";

        public static string WORK_ORDER_TASK_SAVED_SUCCESS = "Work Order task saved successfully";

        public static string WORK_ORDER_EXECUTED_SUCCESS = "Work Order executed successfully ";

        public static string WORK_ORDER_INFORMATION_SAVED_SUCCESS = "Work Order information saved successfully";

        public static string ITEM_SAVED_SUCCESS = "Item Details saved successfully";

        public static string ITEM_CREATE_SUCCESS = "Items Created successfully";

        public static string COMMON_ERROR_MESSAGE = "Sorry, there was some problem while processing your request";

        public static string UNIT_TYPE_SAVED_SUCCESS = "Unit Type saved successfully";

        public static string ITEM_CLASS_SAVED_SUCCESS = "Item Class saved successfully";

        public static string VENDOR_EMAIL_NOT_EXISTS = "Email not exist for this vendor. Please fill email address for vendor and try again";

        public static string CHECKLIST_CLASS_SAVE_SUCCESS = "Checklist Name  saved successfully";

        public static string CHECK_LIST_SAVED_SUCCESS = "Check List saved successfully";

        public static string DUE_DATE_SAVED_SUCCESS = "Due Date updated successfully";

        public static string COMPLETED_FLAG_SAVED_SUCCESS = "Completed Flag updated successfully";

        public static string AUDIT_LOG_SETTINGS_SAVED_SUCCSS = "Audit log settings saved successfully";

        public static string AUDIT_LOG_SETTINGS_SAVING_FAILED = "Audit log settings saving failed";

        public static string CLOSED_FLAG_SAVED_SUCCESS = "Checklist closed successfully";
    }

    public static class AppConstants
    {
        public static string CONST_VALUE = "Value";

        public static string DATE_FORMAT = "MM/dd/yyyy";

        public const string EMPTY_STRING = "";

        public const string STRING_HYPHEN = "-";

        public static string DECIMAL_ZERO = "0.00";

        public static string DEFAULT_START_TIME = "09:00";

        public static string DEFAULT_END_TIME = "17:00";

        public const string STRING_NULL = "null";

        public const int NUMERIC_NO_VALUE = 0;

        public const int NUMERIC_TWENTY_VALUE = 20;

        public const int NUMERIC_HUNDRED_VALUE = 100;

        public const int NUMERIC_TWELVE_VALUE = 12;

        public const int NUMERIC_ONE_VALUE = 1;

        public const int CURRENCY_DECIMALS = 2;

        public const bool BOOL_DEFAULT_VALUE = false;

        public const bool BOOL_TRUE = true;

        public const bool BOOL_FALSE = false;

        public const decimal DECIMAL_DEFAULT_VALUE = Decimal.Zero;

        public static DateTime? DATE_NULL_VALUE = null;

        public static decimal? DECIMAL_NULL_VALUE = null;

        public static string STRING_NULL_VALUE = null;

        public static string STRING_COMMA = ",";

        public static string STRING_COMMA_SPACE = ", ";

        public static int NUMERIC_MINUS_ONE = -1;

        public static int NUMERIC_ONE = 1;

        public static int NUMERIC_TWO = 2;

        public static int EMPLOYEE_STATUS_DEFAULT_VALUE = 1;

        public static int EMPLOYMENT_STATUS_ACTIVE = 35;

        public static int EMPLOYMENT_STATUS_IN_ACTIVE = 36;

        public static int EMPLOYMENT_STATUS_TERMINATED = 37;

        public static int PO_STATUS_NEW = 29;

        public static int PO_STATUS_SENT = 30;

        public static int PO_STATUS_INVOICE_CREATED = 40;

        public static int PO_STATUS_RECEIVING = 46;

        public static int INVOICE_STATUS_NEW = 41;

        public static int ONE_ROOM_CLEANED = 30;

        public static int RECEIVING_STATUS = 45;

        public static int PRIORITY_CRITICAL_STATUS = 47;

        public static int PRIORITY_HIGH_STATUS = 48;

        public static int PRIORITY_MEDIUM_STATUS = 49;

        public static int PRIORITY_LOW_STATUS = 50;

        public static string STRING_ONE = "1";

        public static string STRING_ZERO = "0";

        public static string STRING_TWENTY = "20";

        public static string STRING_TWENTY_FIVE = "25";

        public static string TIME_STRING = "00:00";

        public static string TIME_FORMAT_STRING = "00:00:00";

        public static string DEFAULT_COUNTRY_CODE = "GB";

        public static string UK_CURRENCY_CODE = "GBP";

        public static string US_CURRENCY_CODE = "USD";

        public static string IND_CURRENCY_CODE = "INR";

        public static string POUND_SYMBOl = "£";

        public static string DOLLAR_SYMBOl = "$";

        public static string RUPEE_SYMBOl = "₹";

        public static string PERCENT_SYMBOL = "%";

        public static string CONST_DOC_TYPE_PDF = "PDF";

        public static string CONST_DOC_TYPE_DOC = "DOC";

        public static string CONST_SUBMIT_TYPE_SAVE = "Save";

        public static string CONST_SUBMIT_TYPE_SAVE_AND_CREATE_JOB_OFFER = "Save & Create Job Offer";

        public static string CONST_SUBMIT_TYPE_SAVE_AND_SCHEDULE_INTERVIEW = "Save & Schedule Interview";

        public static string LOOKUP_TYPE_INTERVIEW_STATUS = "InterviewStatus";

        public static string CONST_AUTO_GENERATED = "Auto Generated";

        public static string CONST_ENVIRONMENT = "PROD";

        //CSS Constants

        public const string CONST_ACTIVE_COLOR_RED = "active-color-red";

        public const string CONST_ACTIVE_COLOR_GREEN = "active-color-green";

        public const string CONST_ACTIVE_COLOR_ORANGE = "active-color-orange";

        public const string CONST_COLOR_RED = "red";

        public const string CONST_COLOR_GREEN = "green";

        public const string CONST_COLOR_ORANGE = "orange";

        // Grid Constants
        public const string CONST_OFFSET = "Offset";

        public const string CONST_PAGESIZE = "PageSize";

        public const string CONST_SORT_DIRECTION = "SortDirection";

        public const string CONST_SORT_COLUMN_INDEX = "SortColumnIndex";

        public const string CONST_TOTALRECORDS = "TotalRecords";

        public const string CONST_SEARCH_TEXT = "SearchText";

        public const string CONST_STATUS = "Status";

        public const string CONST_YES = "Yes";

        public const string CONST_NO = "No";

        public const string CONST_FROM_DATE = "FromDate";

        public const string CONST_TO_DATE = "ToDate";

        public const string CONST_FROMDATE = "From_Date";

        public const string CONST_TODATE = "To_Date";

        public const string CONST_MONTH = "Month";

        public const string CONST_YEAR = "Year";

        public const string CONST_FROM_YEAR = "FromYear";

        public const string CONST_TO_YEAR = "ToYear";

        public const string CONST_COMPARE_BY = "CompareBy";

        public const string CONST_INVENTORY_DATE = "InventoryDate";

        public const string CONST_SINGLE_ROOM_SOLD = "SingleRoomSold";

        public const string CONST_DOUBLE_ROOM_SOLD = "DoubleRoomSold";

        public const string CONST_ACTUALROOMS_SOLDID = "ActualRoomsSoldID";

        public const string CONST_FFROM_DATE = "FFromDate";

        public const string CONST_FTO_DATE = "FToDate";

        public const string CONST_TFROM_DATE = "TFromDate";

        public const string CONST_TTO_DATE = "TToDate";

        // Login Constants
        public const string CONST_EMAIL = "Email";

        public const string CONST_EMAIL_SENT_FLAG = "EmailSentFlag";

        public const string CONST_USER_NAME = "UserName";

        public const string CONST_PASSWORD = "Password";

        public const string CONST_NEW_PASSWORD = "NewPassword";

        public const string CONST_FORGOT_PASSWORD = "ForgotPassword";

        public const string CONST_ASTERISK = "********";

        public const string CONST_RESET_PASSWORD_GUID = "ResetPasswordGUID";

        public const string CONST_USER_ID = "UserID";

        public const string MENU_VISIBLE_FLAG = "MenuVisibleFlag";

        public const string CONST_FAILURE = "FAILURE";

        public static string CONST_TRUE = "True";

        public static string CONST_FALSE = "False";

        //Property Room Constants
        public const string CONST_PROPERTY_ROOM_ID = "PropertyRoomID";

        public const string CONST_ROOM_NUMBER = "RoomNumber";

        public const string CONST_ROOM_TYPE_KID = "RoomTypeKID";

        public const string CONST_ROOM_ITEM_ID = "RoomItemID";

        public const string CONST_UNIT_QUANTITY_REQUIRED = "UnitQuantityRequired";



        // Employee Constants
        public const string CONST_COMPANY_ID = "CompanyID";

        public const string CONST_COMPANYID = "Company_ID";

        public const string CONST_PROPERTY_ID = "PropertyID";

        public const string CONST_PROPERTY_NAME = "PropertyName";

        public const string CONST_PROPERTY_IDS = "PropertyIDS";

        public const string CONST_EMPLOYEE_ID = "EmployeeID";

        public const string CONST_DAY = "Day";

        public const string CONST_EMPLOYEEID = "Employee_ID";

        public const string CONST_REPORTING_EMPLOYEE_ID = "ReportingEmployeeID";

        public const string CONST_EMPLOYEE_IDS = "EmployeeIDS";

        public const string CONST_EMPLOYEE_NAME = "EmployeeName";

        public const string CONST_FIRST_NAME = "FirstName";

        public const string CONST_FIRSTNAME = "First_Name";

        public const string CONST_LAST_NAME = "LastName";

        public const string CONST_LASTNAME = "Last_Name";

        public const string CONST_MIDDLE_NAME = "MiddleName";

        public const string CONST_PROFILE_IMAGE = "ProfileImage";

        public const string CONST_ACTIVE_FLAG = "ActiveFlag";

        public const string CONST_ACTIVEFLAG = "Active_Flag";

        public const string CONST_ALLOW_LOGIN = "AllowLogin";

        public const string CONST_EMPLOYEE_TYPE_ID = "EmployeeTypeID";

        public const string CONST_ROLE_ID = "RoleID";

        public const string CONST_ADMIN_LEVEL = "AdminLevel";

        public const string CONST_ROLE_NAME = "RoleName";

        public const string CONST_EMPLOYEE_ADDRESS = "EmployeeAddress";

        public const string CONST_EMPLOYEE_ADDRESS2 = "EmployeeAddress2";

        public const string CONST_EMPLOYEE_CITY = "EmployeeCity";

        public const string CONST_EMPLOYEE_ZIP = "EmployeeZip";

        public const string CONST_EMPLOYEE_STATE = "EmployeeState";

        public const string CONST_EMPLOYEE_COUNTRY = "EmployeeCountry";

        public const string CONST_EMPLOYEE_COUNTY = "EmployeeCounty";

        public const string CONST_MOBILE_NUMBER = "MobileNumber";

        public const string CONST_MOBILENUMBER = "Mobile_Number";

        public const string CONST_PROFILE = "Profile";

        public const string CONST_EMPLOYEE = "Employee";

        public const string CONST_DATE_OF_BIRTH = "DateofBirth";

        public const string CONST_EMPLOYEE_SSN = "EmployeeSSN";

        public const string CONST_PRIORITY = "Priority";

        public const string CONST_EMPLOYEE_PAYMENT_TYPE_ID = "EmployeePaymentTypeID";

        public const string CONST_EMPLOYEE_PAYRATE_HOURLY = "EmployeePayrateHourly";

        public const string CONST_EMPLOYEE_PAYRATE_YEARLY = "EmployeePayrateYearly";

        public const string CONST_OBAMA_CARE_OPTED = "ObamaCareopted";

        public const string CONST_OBAMA_CARE_OFFERED = "ObamaCareOffered";

        public const string CONST_ACTIVE = "Active";

        public const string CONST_MAX_HRS_TO_WORK = "MaxHrsToWork";

        public const string CONST_MIN_HRS_TO_WORK = "MinHrsTowork";

        public const string CONST_FLOOR_ID = "FloorID";

        public const string CONST_JOINING_DATE = "JoiningDate";

        public const string CONST_TERMINATE_DATE = "TerminateDate";

        public const string CONST_IS_EMPLOYMENT_STATUS_ID = "EmploymentStatusID";

        public const string CONST_EMPLOYEE_NUMBER = "EmployeeNumber";

        public const string CONST_ADDED_ON = "AddedOn";

        public const string CONST_MODIFIED_ON = "ModifiedOn";

        public const string CONST_ADDED_BY = "AddedBy";

        public const string CONST_MODIFIED_BY = "ModifiedBy";

        public const string CONST_GENDER = "Gender";

        public const string CONST_PREFIX = "Prefix";

        public const string CONST_SUFFIX = "Suffix";

        public const string CONST_WIDGET_ID = "WidgetID";

        public const string CONST_DISPLAY_ORDER = "DisplayOrder";

        public const string CONST_VISIBLE = "Visible";

        public const string CONST_TABLE_ROLE_ACCESS_RIGHT = "TableRoleAccessRight";

        public const string CONST_TABLE_ROLE_ACCESS_RIGHT_IN = "TableRoleAccessRightIN";

        public const string CONST_TABLE_AUDIT = "TableAudit";

        public const string CONST_TABLE_ROLE_WIDGET = "TableRoleWidget";

        public const string CONST_NAME = "Name";

        public const string CONST_EMAIL_TEMPLATE_ID = "EmailTemplateID";

        public const string CONST_NEW_USER = "NewUser";

        public const string CONST_PO_CREATE = "POCreate";

        public const string CONST_REASON_FOR_PAY_RATE_CHANGE = "Reason For PayRate change";

        public const string CONST_EMAIL_SCHEDULE_ID = "EmailScheduleID";

        public const string CONST_HAS_ACCESS = "HasAccess";

        public const string CONST_ADDITIONAL_ROLE_IDS = "AdditionalRoleIDS";

        public const string CONST_ROLE_IDS = "RoleIDS";

        public const string CONST_NIGHT_AUDIT_ID = "NightAuditID";

        public const string CONST_TOTAL_ROOMS_SOLD = "TotalRoomsSold";


        public const string CONST_OVERTIME_SCHEDULE = "OvertimeSchedule";

        public const string CONST_DOCUMENT = "Document";

        public const string CONST_REGISTER = "Register";

        public const string CONST_COUNTRY_CODE = "CountryCode";

        public const string CONST_MENU_PATH = "MenuPath";

        public const string CONST_MENU_ID = "MenuID";

        public const string CONST_ACCESS_MODE = "AccessMode";

        public const string CONST_REMINDER_60TH_DAY = "Reminder60thday";

        public const string CONST_REPORTING_MANAGERS = "ReportingManagers";

        public const string CONST_PAY_RATE_INSERT_ROLES = "PayRateInsertRoles";

        public const string CONST_PAY_RATE_EIDT_ROLES = "PayRateEditRoles";

        public const string CONST_PAY_RATE_VIEW_ROLES = "PayRateViewRoles";

        public const string CONST_CREATE_ROLES = "CreateRoleIDS";

        public const string CONST_UPDATE_EMPLOYEE_ROLES = "UpdateEmployeeRoleIDS";

        public const string CONST_ADD_EMPLOYEE_EMAIL = "AddEmployeeEmail";

        public const string CONST_NEW_EMPLOYEE_EMAIL = "AddEmployeeEmail";

        public const string CONST_CREATE_EMPLOYEE_EMAIL = "CreateEmployeeEmail";

        public const string CONST_PAYRATE_CHANGE_EMAIL = "ReasonforPayRateChangeEmail";

        public const string CONST_IN_ACTIVE_EMPLOYEE_EMAIL = "InActiveEmployeeEmail";

        public const string CONST_TERMINATED_EMPLOYEE_EMAIL = "TerminatedEmployeeEmail";

        public const string CONST_VERIFIED_EMPLOYEE_EMAIL = "VerifiedEmployeeEmail";

        public const string CONST_PO_PREFIX = "POPrefix";

        public const string CONST_PO_NUMBER_START_WITH = "PONumberStartWith";

        public const string CONST_DEFAULT_GRID_SIZE = "DefaultGridSize";

        public const string CONST_PO_EMPLOYEE_EMAIL = "POEmployeeEmail";

        public const string CONST_CREATE_INVENTORY_PO = "CreateInventoryPO";

        public const string CONST_CREATE_PO_MONTHLY_CATEGORIES = "CreatePOMonthlyCategories";

        public const string CONST_CREATE_PO_WEEKLY_CATEGORIES = "CreatePOWeeklyCategories";

        public const string CONST_PAYCLOCK_ROLE_IDS = "PayClockRoleIDs";

        public const string CONST_UPDATE_SCHEDULE_ROLE_IDS = "UpdateScheduleRoleIDs";

        public const string CONST_INVOICE_EXPECTION_EMAIL = "InvoiceExpectionEmployeeIDS";

        public const string CONST_EXPECTION_ALERT_INVOICE_EMAIL = "ExpectionAlertInvoice";

        public const string CONST_EXPECTION_ALERT_IMPORT_INVOICE_EMAIL = "ExpectionAlertImportInvoicepdf";

        public const string CONST_CREATE_INVOICE_WO_PO = "CreateInvoiceWOPO";

        public const string CONST_INVOICE_WOPO_EMAIL = "CreateInvoiceWOPOEmployeeIDS";

        public const string CONST_INVIOCE_FORCE_CLOSE_EMPLOYEE_IDS = "InvoiceForceCloseEmployeeIDS";

        public const string CONST_RECEIVING_INVOICE_FLAG = "ReceivingInvoiceFlag";

        public const string CONST_CREATE_INVOICE_WO_PO_EMPLOYEE_EMAIL = "CreateInvoiceWOPOEmployeeIDS";

        public const string CONST_CLOSE_INVOICE_EMPLOYEE = "CloseInvoiceEmployeeIDS";

        public const string CONST_CLOSE_INVOICE_EMAIL = "CloseInvoiceEmail";

        public const string CONST_CLOSE_RECEIVING_EMAIL = "CloseReceivingEmail";

        public const string CONST_PAYCLOCK_IMPORT_EXCEPTION_EMPLOYEE = "PayClockImportExceptionEmployeeIDS";

        public const string CONST_CHECK_LIST_EMAIL = "MMMAlertChecklist";

        public const string CONST_INVENTORY_LOCKING_DATE = "InventoryLockingDate";

        public const string CONST_INVENTORY_LOCKING_EDIT_EMPLOYEE = "InventoryLockingEditEmployeeIDS";


        // Availability Constants
        public const string CONST_AVAILABILITY_ID = "AvailabilityID";

        public const string CONST_AVAILABLITY_STATUS = "AvailablityStatus";

        public const string CONST_AVAILABLE_HRS = "AvailableHrs";

        public const string CONST_AVAILABILITY_START_TIME = "AvailabilityStartTime";

        public const string CONST_AVAILABILITY_END_TIME = "AvailabilityEndTime";

        public const string CONST_AVAILABILITY_DATE = "AvailabilityDate";

        //Company Constants
        public const string CONST_COMPANY_NAME = "CompanyName";

        //Property Constants
        public const string CONST_ADDRESS = "Address";

        public const string CONST_ADDRESS1 = "Address1";

        public const string CONST_ADDRESS2 = "Address2";

        public const string CONST_STATE = "State";

        public const string CONST_CITY = "City";

        public const string CONST_COUNTY = "County";

        public const string CONST_ZIP = "Zip";

        public const string CONST_COUNTRY = "Country";

        public const string CONST_ROOMS = "Rooms";

        public const string CONST_IMAGE_PATH = "ImagePath";

        public const string CONST_ACQUIRED_ON = "AcquiredOn";

        public const string CONST_SHCEDULE_START_TIME = "shceduleStartTime";

        public const string CONST_SHCEDULE_END_TIME = "shceduleEndTime";

        public const string CONST_PROPERTY_CATEGORIES = "PropertyCategories";

        public const string CONST_SALES_TAX = "SalesTax";

        //Schedule Constants
        public const string CONST_SCHEDULE_ID = "ScheduleID";

        public const string CONST_SCHEDULE_DATE = "ScheduleDate";

        public const string CONST_SCHEDULED_HRS = "ScheduledHrs";

        public const string CONST_SCHEDULED_START_TIME = "ScheduledStartTime";

        public const string CONST_SCHEDULED_END_TIME = "ScheduledEndTime";

        public const string CONST_ACTUAL_HRS_WORKED = "ActualHrsWorked";

        public const string CONST_ACTUAL_START_TIME = "ActualStartTime";

        public const string CONST_ACTUAL_END_TIME = "ActualEndTime";

        public const string CONST_BREAK_MINS_IN_SHIFT = "BreakMinsInShift";

        public const string CONST_HEAD_HOUSE_KEEPING = "HeadHouseKeeping";



        //Candidates Constants
        public const string CONST_CANDIDATE_ID = "CandidateID";

        public const string CONST_TITLE = "Title";

        public const string CONST_STAGE = "Stage";

        public const string CONST_HOME_TELEPHONE = "HomeTelephone";

        public const string CONST_PERSONAL_PHONE = "PersonalPhone";

        public const string CONST_PERSONAL_EMAIL = "PersonalEmail";

        public const string CONST_DOB = "DOB";

        public const string CONST_NATIONAL_INSURANCE = "NationalInsurance";

        public const string CONST_NATIONALITY = "Nationality";

        public const string CONST_MARTIAL_STATUS = "MartialStatus";

        public const string CONST_ACCESS_TO_CAR = "AccesstoCar";

        public const string CONST_DRIVING_LICENCE = "DrivingLicence";

        public const string CONST_RIGHT_TO_WORK = "RighttoWork";

        public const string CONST_CV_FILE_PATH = "CVFilePath";

        public const string CONST_SUR_NAME = "SurName";

        public const string CONST_OTHER_NAMES = "OtherNames";

        public const string CONST_DRAFT = "Draft";

        public const string CONST_CV_FILE_CONTENT = "CVFileContent";

        public const string CONST_INTERVIEW_STATUS = "InterviewStatus";

        //Requisitions
        public const string CONST_REQUISITION_ID = "RequisitionID";

        public const string CONST_REQUISITION_STATUS = "RequisitionStatus";

        public const string CONST_ACTIVE_FROM_DATE = "ActiveFromDate";

        public const string CONST_JOB_TYPE_ID = "JobTypeID";

        public const string CONST_HIRING_MANAGER_ID = "HiringManagerID";

        public const string CONST_REFERENCE_NUMBER = "ReferenceNumber";

        public const string CONST_DEPARTMENT_ID = "DepartmentID";

        public const string CONST_LOCATION = "Location";

        public const string CONST_CLOSING_DATE = "ClosingDate";

        public const string CONST_JOB_START_DATE = "JobStartDate";

        public const string CONST_CONTACT_NAME = "ContactName";

        public const string CONST_OTHER_DETAILS = "OtherDetails";

        public const string CONST_PHONE_NUMBER = "PhoneNumber";

        //JobStatus
        public const string CONST_JOB_STATUS_ID = "JobStatusID";

        public const string CONST_JOB_DESCRIPTION = "JobDescription";

        public const string CONST_JOBDESCRIPTION = "Job_Description";

        //Recruitment_Stages
        public const string CONST_RECRUITMENT_STAGE_ID = "RecruitmentStageID";

        //JobLevels
        public const string CONST_JOB_LEVEL_ID = "JobLevelID";

        public const string CONST_JOB_LEVEL_NAME = "JobLevelName";

        //JobRoles
        public const string CONST_JOB_ROLE_ID = "JobRoleID";

        public const string CONST_JOB_ROLE_NAME = "JobRoleName";

        public const string CONST_MANAGER_LEVEL_FLAG = "ManagerLevelFlag";

        public const string CONST_SALARY_RANGE_FROM = "SalaryRangeFrom";

        public const string CONST_SALARY_RANGE_TO = "SalaryRangeTo";

        public const string CONST_BENEFITS = "Benefits";

        public const string CONST_JOB_RESPONSIBILITIES = "JobResponsibilities";

        public const string CONST_JOB_COMPETENCE = "JobCompetence";

        public const string CONST_JOB_EXPERIENCE = "JobExperience";

        //Interviews
        public const string CONST_INTERVIEWER_ID = "InterviewerID";

        public const string CONST_INTERVIEW_ID = "InterviewID";

        public const string CONST_DATE = "Date";

        public const string CONST_AUDIT_DATE = "AuditDate";

        public const string CONST_TIME = "Time";

        public const string CONST_COMMENTS = "Comments";

        //Job Offers
        public const string CONST_JOB_OFFER_ID = "JobOfferID";

        public const string CONST_MANAGER_ID = "ManagerID";

        public const string CONST_SALARY = "Salary";

        public const string CONST_SALARY_INTERVAL = "SalaryInterval";

        public const string CONST_HOLIDAYS_ANUM = "HolidaysAnum";

        public const string CONST_HOURS_PER_WEEK = "HoursPerWeek";

        public const string CONST_PROBATIONARY_PERIOD = "ProbationaryPeriod";

        public const string CONST_START_DATE = "StartDate";

        //Document constants
        public const string CONST_DOCUMENT_ID = "DocumentID";

        public const string CONST_RELATED_TO = "RelatedTo";

        public const string CONST_RELATED_TO_VALUE = "RelatedToValue";

        public const string CONST_FILE_PATH = "FilePath";

        public const string CONST_FILE_2_PATH = "File2Path";

        public const string CONST_FILE_3_PATH = "File3Path";

        public const string CONST_FILE_4_PATH = "File4Path";

        public const string CONST_FILE_TYPE = "FileType";

        public const string CONST_FILE_2_NAME = "File2Name";

        public const string CONST_FILE_3_NAME = "File3Name";

        public const string CONST_FILE_4_NAME = "File4Name";

        public const string CONST_FILE_NAME = "FileName";

        public const string CONST_TYPE = "Type";

        public const string CONST_DESCRIPTION = "Description";

        public static int CONST_DOCUMENT_EMPLOYEE = 1;

        public static int CONST_DOCUMENT_PROPERTY = 2;

        public const string CONST_DOCUMENT_TYPE_ID = "DocumentTypeID";

        public const string CONST_SHOW_ALL_EMPLOYEES = "ShowAllEmployees";

        public const string CONST_PROPERTY_DOCUMENT_TYPE_ID = "PropertyDocumentTypeID";


        //Employee
        public const string CONST_EMPLOYEE_EXPERIENCE_ID = "Employee_Experience_ID";

        public const string CONST_INSTITUTION_NAME = "Institution_Name";

        public const string CONST_QUALIFICATION = "Qualification";

        public const string CONST_STUDY_DURATION = "Study_Duration";

        public const string CONST_COMPLETION_YEAR = "Completion_Year";

        public const string CONST_INTERESTS = "Interests";

        public const string CONST_ADDITIONAL_NOTES = "Additional_Notes";


        public const string CONST_EMPLOYEE_EDUCATION_ID = "Employee_Education_ID";

        public const string CONST_PREVIOUS_COMPANY_NAME = "Previous_Company_Name";

        public const string CONST_COMPANY_ADDRESS = "Company_Address";

        public const string CONST_JOB_TITLE = "Job_Title";


        public const string CONST_EMPLOYEE_CONTACT_ID = "Employee_Contact_ID";

        public const string CONST_RELATIONSHIP = "RelationShip";

        public const string CONST_DATEOFBIRTH = "Date_of_Birth";

        public const string CONST_ADDRESS_ID = "Address_ID";

        public const string CONST_ADDRESS_TYPE = "Address_Type";

        public const string CONST_ADDRESS_SOURCE = "Address_Source";

        public const string CONST_BANK_DETAILS_ID = "Bank_Details_ID";

        public const string CONST_DISPLAY_NAME = "Display_Name";

        public const string CONST_BANK_NAME = "Bank_Name";

        public const string CONST_BANK_ACCOUNT_NO = "Bank_Account_No";

        public const string CONST_BANK_ADDRESS = "Bank_Address";

        public const string CONST_BANK_SORT_CODE = "Bank_Sort_Code";

        public const string CONST_EMPLOYEE_WORK_LOCATION_ID = "Employee_Work_Location_ID";

        public const string CONST_CONTRACT_START_DATE = "Contract_Start_Date";

        public const string CONST_CONTRACT_END_DATE = "Contract_End_Date";

        public const string CONST_COMPANYNAME = "Company_Name";

        public const string CONST_REFERENCE_ID = "Reference_ID";

        public const string CONST_REFERENCE_TYPE = "Reference_Type";

        public const string CONST_JOB_ROLE = "Job_Role";

        public const string CONST_WORK_DURATION_YEARS = "Work_Duration_Years";

        public const string CONST_WORK_DURATION_MONTHS = "Work_Duration_Months";

        public const string CONST_WILLING_EMP_AGAIN = "Willing_Emp_Again";

        // PassportDetails

        public const string CONST_PASSPORT_DETAILS_ID = "Passport_Details_ID";

        public const string CONST_NI_STATUS = "NI_Status";

        public const string CONST_NI_NUMBER = "NI_Number";

        public const string CONST_PASSPORT_STATUS = "Passport_Status";

        public const string CONST_PASSPORT_NUMBER = "Passport_Number";

        public const string CONST_PLACE_OF_ISSUE = "Place_Of_Issue";

        public const string CONST_DATE_OF_ISSUE = "Date_Of_Issue";

        public const string CONST_DATE_OF_EXPIRY = "Date_Of_Expiry";


        //VisaDetails 

        public const string CONST_VISA_DETAILS_ID = "Visa_Details_ID";

        public const string CONST_VISA_CATEGORY = "Visa_Category";

        public const string CONST_VISA_NUMBER = "Visa_Number";

        public const string CONST_VISA_ISSUE_DATE = "Visa_Issue_Date";

        public const string CONST_VISA_EXPIRY_DATE = "Visa_Expiry_Date";

        public const string CONST_ZIPCODE = "Zipcode";

        public const string CONST_HOME_NUMBER = "Home_Number";

        public const string CONST_CREATED_BY = "Created_By";


        //identity

        public const string CONST_COS_DETAILS_ID = "COS_Details_ID";

        public const string CONST_COS_START_DATE = "COS_Start_Date";

        public const string CONST_COS_END_DATE = "COS_End_Date";

        public const string CONST_UPLOAD_IMAGE = "Upload_Image";

        //employement

        public const string CONST_DESIGNATION_ID = "Designation_ID";

        public const string CONST_LOCATION_ID = "LocationID";

        public const string CONST_LOCATION_NAME = "Location_Name";

        public const string CONST_END_DATE = "End_Date";

        public const string CONST_WORK_LOCATION = "Work_Location";

        public const string CONST_SOURCE_OF_HIRE = "Source_Of_Hire";

        public const string CONST_REPORTING_TO = "Reporting_To";

        public const string CONST_SALARY_RATE = "Salary_Rate";

        public const string CONST_EMPLOYEE_STATUS = "Employee_Status";

        public const string CONST_EMPLOYEE_TYPE = "Employee_Type";

        public const string CONST_PAYMENT_INTERVAL = "Payment_Interval";

        public const string CONST_SALARY_AMOUNT_TYPE = "Salary_Amount_Type";

        public const string CONST_APPRAISAL_AMOUNT = "Appraisal_Amount";

        public const string CONST_HOLIDAYS = "Holidays";

        public const string CONST_TERMS_OF_CONTRACT = "Terms_Of_Contract";

        public const string CONST_REASON = "Reason";

        public const string CONST_SPECIAL_NOTES = "Special_Notes";

        // Shift Constants

        public const string CONST_SHIFT_ID = "Shift_ID";

        public const string CONST_SHIFT_NAME = "Shift_Name";

        //Employee Login History Details
        public const string CONST_USER_LOGIN_HISTORY_ID = "UserLoginHistoryID";

        public const string CONST_BROWSER_INFO = "BrowserInfo";

        public const string CONST_BROWSER_NAME = "BrowserName";

        public const string CONST_COMPUTER_NAME = "ComputerName";

        public const string CONST_ORIGIN = "Origin";

        public const string CONST_IS_DIRECT_LOGIN = "IsDirectLogin";

        public const string CONST_IPADDRESS = "IPAddress";

        //save error log constants
        public const string CONST_ERROR_MESSAGE = "ErrorMessage";

        public const string CONST_SCREEN_NAME = "ScreenName";

        public const string CONST_FUNCTION_NAME = "FunctionName";

        public const string CONST_PARAMETER_VALUES = "ParameterValues";

        public const string CONST_FILTER_NAME = "FilterName";

        //supplier constants
        public const string CONST_SUPPLIER_ITEM_COST = "SupplierItemcost";

        public const string CONST_SUPPLIER_ITEM_COST_ID = "SupplierItemcostID";

        public const string CONST_SUPPLIER_ITEM_CODE = "SupplierItemCode";

        public const string CONST_SUPPLIER_ID = "SupplierID";

        public const string CONST_SUPPLIER_NAME = "SupplierName";

        public const string CONST_SUPPLIER_NUMBER = "SupplierNumber";

        public const string CONST_SUPPLIER_IDS = "SupplierIDS";

        public const string CONST_ITEM_IDS = "ItemIDS";

        public const string CONST_DEFAULT_FLAG = "DefaultFlag";


        //ITEM MASTER CONSTANTS

        public const string CONST_ITEM_ID = "ItemID";

        public const string CONST_UNIT_TYPE_ID = "UnitTypeID";

        public const string CONST_ITEM_NAME = "ItemName";

        public const string CONST_ITEM_NUMBER = "ItemNumber";

        public const string CONST_ITEM_DESCRIPTION = "Description";

        public const string CONST_ITEM_CATEGORY_ID = "ItemCategoryID";

        public const string CONST_ITEM_CATEGORY_IDS = "ItemCategoryIDS";

        public const string CONST_ITEM_QUANTITYPER_UNIT = "QuantityPerUnit";

        public const string CONST_ITEM_UNITS_COST = "UnitCost";

        public const string CONST_ITEM_UNITS_ON_STOCK = "UnitsOnStock";

        public const string CONST_ITEM_REORDER_LEAVEL = "ReorderLevel";

        public const string CONST_ITEM_UNITS_ON_ORDER = "UnitsOnOrder";

        public const string CONST_ITEM_IMAGEPATH = "ImagePath";

        public const string CONST_CATEGORY_NAME = "CategoryName";

        public const string CONST_ITEM_UNIT_TYPE_ID = "UnitTypeID";

        public const string CONST_PROPERTY_IDN = "PropertyIDN";

        public const string CONST_SHOW_ALL_ITEMS = "ShowAllItems";

        public const string CONST_SHOW_DEFAULT_ITEMS = "ShowDafaultItems";

        public const string CONST_ITEM_LOCATION_ID = "ItemLocationID";

        public const string CONST_ITEM_LOCATION_NAME = "lst_Location_Name";

        public const string CONST_DEFAULT_IMAGE = "~/../images/default-user.jpg";


        //PurchaseOrder constants
        public const string CONST_PURCHASE_ORDER_ID = "POID";

        public const string CONST_PURCHASE_ORDER_NUMBER = "PONumber";

        public const string CONST_ORDER_SUB_TOTAL = "OrderSubTotal";

        public const string CONST_DISCOUNT_TOTAL = "DiscountTotal";

        public const string CONST_TAX_TOTAL = "TaxTotal";

        public const string CONST_FREIGHT = "Freight";

        public const string CONST_FEES = "Fees";

        public const string CONST_ORDER_TOTAL = "OrderTotal";

        public const string CONST_TOTAL_COST = "TotalCost";

        public const string CONST_PURCHASE_ORDER_DATE = "PODate";

        public const string CONST_PURCHASE_ORDER_LINE_ITEM_ID = "POLineItemID";

        public const string CONST_UNIT_ORDERED = "UnitOrdered";

        public const string CONST_UNIT_COST = "UnitCost";

        public const string CONST_UNIT_TOTAL = "UnitTotal";

        public const string CONST_UNIT_DISCOUNT = "UnitDiscount";

        public const string CONST_PO_FROM_DATE = "POFromDate";

        public const string CONST_PO_TO_DATE = "POToDate";

        public const string CONST_SHP_HD_CHARGES = "ShippingAndHandlingCharges";

        public const string CONST_QUOTE_NUMBER = "QuoteNumber";

        public const string CONST_NOTES = "Notes";

        public static string CONST_SUBMIT_TYPE = "SubmitType";

        public static string CONST_PO_STATUS = "POStatus";
        //Invoice constants
        public const string CONST_INVOICE_ID = "InvoiceID";

        public const string CONST_INVOICE_NUMBER = "InvoiceNumber";

        public const string CONST_INVOICE_SUB_TOTAL = "InvoiceSubTotal";

        public const string CONST_INVOICE_TOTAL = "InvoiceTotal";

        public const string CONST_INVOICE_DATE = "InvoiceDate";

        public const string CONST_ITEM_CLASS_ID = "ItemClassID";

        public const string CONST_EXIST_ITEM_CLASS_ID = "ExistItemClassID";

        public const string CONST_ROOM_TYPE_ID = "RoomTypeID";

        public const string CONST_ITEMCLASS_ID = "ItemClassDetailID";

        public const string CONST_ROOM_TYPE_DETAIL_ID = "RoomTypeDatailID";

        public const string CONST_NUMBER_OF_BEDS = "NumberofBeds";

        public const string CONST_DEFAULT_ITEM_FLAG = "DefaultItemFlag";

        public const string CONST_PAR = "PAR";

        public const string CONST_INVOICE_LINE_ITEM_ID = "InvoiceLineItemID";

        public const string CONST_RECEIVING_LINE_ITEM_ID = "ReceivingLineItemID";

        public const string CONST_TRANSACTION_TYPE_ID = "TransactionTypeID";

        public const string CONST_RECEIVING_FLAG = "ReceivingFlag";

        public const string CONST_RECEIVING_CLOSE = "CloseReceiving";

        public const string CONST_RECEIVING = "Receiving";

        public const string CONST_INVOICE = "Invoice";

        public const string CONST_TRANSACTION_REFERENCE_NUMBER = "TransactionReferenceNumber";

        //PayClock constants
        public const string CONST_BATCH_ID = "BatchID";


        public const string CONST_TRANSACTION_BATCH_ID = "TransactionBatchID";

        public const string CONST_SELECTED_IDS = "SelectedIDS";

        //Lookup constants

        public const string CONST_LOOKUP_ID = "LookupID";


        //ChartofAccount constants
        public const string CONST_CHART_OF_ACCOUNT_ID = "ChartofAccountID";

        public const string CONST_MAIN_ACCOUNT_FLAG = "MainAccountFlag";

        public const string CONST_SUB_CATEGORY_ONE_FLAG = "SubCategoryOneFlag";

        public const string CONST_SUB_CATEGORY_TWO_FLAG = "SubCategoryTwoFlag";

        public const string CONST_PARENT_CHARTOFACCOUNT_ID = "ParentChartofAccountID";

        //Audit Log Settings constants

        public const string CONST_TABLE_NAME = "TableName";

        public const string CONST_TABLE_DISPLAY_NAME = "TableDisplayName"; 

        //Folder Path
        public const string STORAGE_FOLDER = "Storage";

        public const string TEMPLATE_FOLDER = "Templates";

        public const string USER_PROFILE_PATH = "Profile/";

        public const string USER_PROPERTY_PATH = "Property/";

        public const string ITEMMASTER_IMAGE_PATH = "ItemMaster/";

        public const string EMPLOYEE_DOCUMENT_DOCUMENTS_PATH = "EmployeeDocument/";

        public const string PROPERTY_DOCUMENT_PATH = "PropertyDocument/";

        public const string INVOICE_DOCUMENT_PATH = "InvoiceDocument/";

        public const string KVA_AUDIT_FILE_PATH = "KVAAuditFile/";

        public const string EMPLOYEE_DOCUMENT_PATH = "/EmployeeDocument";

        public const string CANDIDATE_CV_PATH = "CandidateCVPath/";

        public const string EDUCATION_DOCUMENTS_PATH = "Education/";

        public const string REFERENCE_DOCUMENTS_PATH = "Reference/";

        public const string EMPLOYEE_IDENTITY_IMAGE_PATH = "Identity_Image/";

        public const string EMPLOYEE_VISA_IMAGE_PATH = "VisaDetails_Image/";

        public const string EMPLOYEE_COS_DETAILS_IMAGE_PATH = "Cos_Image/";

        public const string ITEMCATEGORY = "/ItemCategory";

        public const string UNIT_TYPE = "/UnitType";

        public const string ITEM_LOCATION = "/ItemLocation";

        public const string ITEM_CLASS = "/ItemClass";

        public const string ROOM_TYPES = "/RoomTypes";

        public const string TRANSACTION_TYPE = "/TransactionType";

        public const string BANK_TRANSACTIONS = "/BankTransactions";

        public const string CHECKLIST_DOCUMENT_PATH = "Checklist/";

        //Menu Paths for checking Full Acess rights
        public const string ROLES = "/Roles";

        public const string EMPLOYEE = "/Employee";

        public const string AVAILABILITY = "/Availability";

        public const string AUDIT = "/Audit";

        public const string AVAILABLE = "/Available";

        public const string COMPANY = "/Company";

        public const string PROPERTY = "/Property";

        public const string STOCK_MANAGEMENT = "/StockManagement";

        public const string ROOM = "/Room";

        public const string PURCHASE_ORDER = "/PurchaseOrder";

        public const string INVOICE = "/Invoice";

        public const string RECEIVING = "/Invoice/Receiving";

        public const string SCHEDULE = "/Schedule";

        public const string PRODUCTIVITY = "/Productivity";

        public const string REQUISITIONS = "/Requisitions";

        public const string CANDIDATES = "/Candidates";

        public const string JOBOFFERS = "/JobOffers";

        public const string INTERVIEWS = "/Interviews";

        public const string CANDIDATE_SEARCH = "/CandidateSearch";

        public const string JOBSTATUS = "/JobStatus";

        public const string RECRUITMENTSTAGES = "/RecruitmentStages";

        public const string JOBLEVELS = "/JobLevels";

        public const string JOBROLES = "/JobRoles";

        public const string DOCUMENTTYPE = "/DocumentType";

        public const string SUPPLIERS = "/Suppliers";

        public const string ITEMMASTER = "/ItemMaster";

        public const string INVOICE_PDF_FILE_PATH = "InvoicePdf";

        public const string STOCK_MANAGEMENT_PATH = "StockManagement/";

        public const string PROPERTY_DOCUMENT_TYPE = "/PropertyDocumentType";

        public const string ROOM_TYPE_DETAIL = "/RoomTypeDetail";

        public const string PREVENTIVE_SERVICE = "/PreventiveService";

        public const string GENERAL_SERVICE = "/GeneralService";

        public const string ACCOUNT_DETAILS = "/AccountDetails";

        public const string WORK_ORDER = "/WorkOrder";

        public const string CHART_OF_ACCOUNT = "/ChartofAccount";

        public const string BANK_TRANSACTION_PATH = "BankTransaction/";

        public const string ITEM_CLASS_DETAILS = "/ItemClassDetail";

        public const string CHECKLIST_CLASS = "/CheckListClass";

        //Email PlaceHolders
        public const string CONST_PLACE_HOLDER_NAME = "##NAME##";
        public const string CONST_PLACE_HOLDER_USERNAME = "##USERNAME##";
        public const string CONST_PLACE_HOLDER_EMAIL = "##EMAIL##";
        public const string CONST_PLACE_HOLDER_PASSWORD = "##PASSWORD##";
        public const string CONST_PLACE_HOLDER_URL = "##URL##";
        public const string CONST_PLACE_HOLDER_LOGIN_URL = "##LOGINURL##";
        public const string CONST_PLACE_HOLDER_EMAIL_BYDY = "##EMAILBODY##";
        public const string CONST_PLACE_HOLDER_OTHOURS = "##OTHOURS##";
        public const string CONST_PLACE_HOLDER_SCHEDULEBY = "##SCHEDULEDBY##";
        public const string CONST_PLACE_HOLDER_SCHEDULEDATE = "##SCHEDULEDATE##";
        public const string CONST_PLACE_ADJUSTED_DATE = "##ADJUSTEDDATE##";
        public const string CONST_PLACE_ADJUSTED_NAME = "##ADJUSTEDNAME##";
        public const string CONAT_PLACE_PREVIOUSPAY_RATE = "##PREVIOUSPAYRATE##";
        public const string CONST_PLACE_NEWPAY_RATE = "##NEWPAYRATE##";
        public const string CONST_PLACE_PROPERTY = "##PROPERTY##";
        public const string CONST_PLACE_PAYRATE_CHANGE_REASON = "##PAYRATECHANGEREASON##";
        public const string CONST_PLACE_PO_DETAILS = "##PODETAILS##";
        public const string CONST_PLACE_VENDOR = "##VENDOR##";
        public const string CONST_PLACE_PO_NUMBER = "##PONUMBER##";
        public const string CONST_PLACE_INVOICE_NUMBER = "##INVOICENUMBER##";
        public const string CONST_PLACE_NUMBER = "##NUMBER##";
        public const string CONST_PLACE_SUB_TOTAL = "##SUBTOTAL##";
        public const string CONST_PLACE_TAX = "##TAX##";
        public const string CONST_PLACE_INVOICE_TOTAL = "##INVOICETOTAL##";
        public const string CONST_PLACE_HOLDER_VENDORNAME = "##VENDORNAME##";
        public const string CONST_PLACE_HOLDER_PROPERTYNAME = "##PROPERTYNAME##";
        public const string CONST_PLACE_HOLDER_EMPLOYEENAME = "##EMPLOYEENAME##";
        public const string CONST_PLACE_HOLDER_TITLE = "##TITLE##";


        public const string CONST_PLACE_HOLDER_DOCUMENT_TYPE = "##DOCUMENTTYPE##";
        public const string CONST_PLACE_HOLDER_DOCUMENT_NAME = "##DOCUMENTNAME##";
        public const string CONST_PLACE_HOLDER_FILENAME = "##FILENAME##";
        public const string CONST_PLACE_HOLDER_DESCRIPTION = "##DESCRIPTION##";
        public const string CONST_PLACE_HOLDER_DATE_OF_JOINING = "##DATEOFJOINING##";

        //widgets
        public const string WIDGET_USER_PRODUCTIVITY = "User Productivity";
        public const string WIDGET_PRODUCTIVITY_OF_EMPLOYEES = "Productivity of Employees";
        public const string WIDGET_SCHEDULING_OF_ROOMS = "Scheduling of Rooms";
        public const string WIDGET_PRODUCTIVITY_OF_PROPERTIES = "Productivity of Properties";
        public const string WIDGET_STOCK_IN_HAND_CATEGORY = "Stock In Hand Category";
        public const string WIDGET_HIGHEST_ORDERED_ITEMS = "Highest Ordered Items";
        public const string WIDGET_NIGHT_AUDIT_LOG = "Night Audit Log";
        public const string WIDGET_PURCHASE_ORDER_STATUS_SENT = "Purchase Order status sent";
        public const string WIDGET_INVOICE_WO_PO_SUMMARY = "Invoice w/o PO Summary";
        public const string WIDGET_NOTIFICATIONS = "Notifications";

        //Lookup Types
        public static string LOOKUP_TYPE_EMPLOYEE_RELATIONSHIP = "EmployeeRelationship";

        public static string LOOKUP_TYPE_ADDRESS = "AddressType";

        public static string LOOKUP_TYPE_PAYMENT_INTERVAI = "PaymentIntervalType";

        public static string LOOKUP_TYPE_SALARY_AMOUNT = "SalaryAmountType";

        public static string LOOKUP_TYPE_WORKLOCATION = "WorkLocationType";

        public static string LOOKUP_TYPE_SALARY_INTERVAL = "SalaryInterval";

        public static string LOOKUP_TYPE_EMPLOYEE_STATUS = "EmployeeStatus";

        public static string LOOKUP_TYPE_EMPLOYEE_TYPE = "EmployeeType";

        public static string LOOKUP_TYPE_SOURCE_OF_HIRE = "SourceOfHire";

        public static string LOOKUP_TYPE_REFERENCE = "ReferenceType";

        public static string LOOKUP_TYPE_VISA_CATEGORY = "VisaType";

        public static string LOOKUP_TYPE_NATIONALITY = "NationalityType";

        public static string LOOKUP_TYPE_NISTATUS = "NIstatusType";

        public static string LOOKUP_TYPE_PASSPORTSTATUS = "PassportStatusType";

        public static string LOOKUP_TYPE_ROOM = "RoomType";

        public static string LOOKUP_TYPE_PURCHASE_ORDER_STATUS = "PurchaseOrderStatus";

        public static string LOOKUP_TYPE_GENDER = "Gender";

        public static string LOOKUP_TYPE_EMPLOYMENT_STATUS = "EmploymentStatus";

        public static string LOOKUP_TYPE_WORK_ORDER = "WorkOrder";

        public static string LOOKUP_TYPE_PRIORITY = "Priority";


        //Service Constants
        public const string CONST_SERVICE_ID = "ServiceID";

        public const string CONST_SERVICE_IDS = "ServiceIDS";

        public const string CONST_SERVICE_NAME = "ServiceName";

        public const string CONST_LAST_SERVICE_DATE = "LastServiceDate";

        public const string CONST_NEXT_SERVICE_DATE = "NextServiceDate";

        public const string CONST_GENERAL_SERVICE_FLAG = "GeneralServiceFlag";

        public const string CONST_TARGET_HOURS = "TargetHours";

        public const string CONST_SERVICE_TASK_ID = "ServiceTaskID";

        public const string CONST_TASK_NAME = "TaskName";


        //WorkOrder Constants
        public const string CONST_WORK_ORDER_ID = "WorkOrderID";

        public const string CONST_WORK_ORDER_NUMBER = "Number";

        public const string CONST_ASSIGNED_TO = "AssignedTo";

        public const string CONST_ESTIMATED_HOURS = "EstimatedHours";

        public const string CONST_ACTUAL_HOURS = "ActualHours";

        public const string CONST_WORK_ORDER_TASK_ID = "WOTaskId";


        //Message Constants

        public const string CONST_RECIPIENT_ID = "RecipientID";

        public const string CONST_MESSAGE_ID = "MessageID";

        public const string CONST_PARENT_MESSAGE_ID = "ParentMessageID";

        public const string CONST_MESSAGE = "Message";


        //check list constants
        public const string CONST_CHECK_LIST_ID = "ChecklistID";

        public const string CONST_CHECK_LIST_LINE_ITEM_ID = "ChecklistLineItemID";

        public const string CONST_CHECKLIST_CLASS_ID = "ChecklistClassID";

        public const string CONST_CHECKLIST_CLASS_NAME = "Name";

        public const string CONST_DUE_DATE_TIME = "DueDateTime";

        public const string CONST_COMPLETED_FLAG = "CompletedFlag";

        //Audit log
        public const string CONST_ACTION_TYPE = "ActionType";
    }

    public enum PageName
    {
        Supplier = 1,
        ItemMaster = 2,
    }

    class Constants
    {
    }
}
