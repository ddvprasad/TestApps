using System;

namespace Core
{
    public class StoredProcedure
    {
        #region Stored procedure names
        public const String SP_RETRIEVE_USERS = "BO.RetrieveUsers";

        public const String SP_EXECUTE_EMPLOYEES = "dbo.ExecuteEmployees";
        public const String SP_RETRIEVE_EMPLOYEES = "dbo.RetrieveEmployees";

        public const String SP_RETRIEVE_MENU = "dbo.RetrieveMenu";

        public const String SP_EXECUTE_ROLE_ACCESS_RIGHTS = "dbo.ExecuteRoleAccessRights";
        public const String SP_RETRIEVE_ROLE_ACCESS_RIGHTS = "dbo.RetrieveRoleAccessRights";

        public const String SP_EXECUTE_ROLE_WIDGETS = "dbo.ExecuteRoleWidgets";
        public const String SP_RETRIEVE_ROLE_WIDGETS = "dbo.RetrieveRoleWidgets";

        public const String SP_EXECUTE_ROLES = "dbo.ExecuteRoles";
        public const String SP_RETRIEVE_ROLES = "dbo.RetrieveRoles";

        public const String SP_EXECUTE_ERROR_LOG = "dbo.ExecuteErrorLog";

        public const String SP_RETRIEVE_EMAIL_TEMPLATE = "dbo.RetrieveEmailTemplate";

        public const String SP_EXECUTE_EMAIL_LOG = "dbo.ExecuteEmailLog";

        public const String SP_RETRIEVE_COMPANIES = "dbo.RetrieveCompanies";
        public const String SP_EXECUTE_COMPANIES = "dbo.ExecuteCompanies";

        public const String SP_EXECUTE_FILTER_SETTINGS = "dbo.ExecuteCompanyFilterSettings";
        public const String SP_RETRIEVE_FILTER_SETTINGS = "dbo.RetrieveCompanyFilterSettings";

        public const String SP_RETRIEVE_COUNTRIES = "dbo.RetrieveCountries";

        public const String SP_RETRIEVE_STATES = "dbo.RetrieveStates";

        public const String SP_RETRIEVE_PROPERTIES = "dbo.RetrieveProperties";
        public const String SP_EXECUTE_PROPERTIES = "dbo.ExecuteProperties";

        public const String SP_RETRIEVE_AUDIT_LOG = "dbo.RetrieveAuditLog";

        public const String SP_RETRIEVE_EMPLOYEE_PAYMENT_TYPES = "dbo.RetrieveEmployeePaymentTypes";

        public const String SP_RETRIEVE_EMPLOYEE_TYPES = "dbo.RetrieveEmployeeTypes";

        public const String SP_RETRIEVE_AVAILABILITY = "dbo.RetrieveAvailability";
        public const String SP_EXECUTE_AVAILABILITY = "dbo.ExecuteAvailability";

        public const String SP_EXECUTE_REGISTRATION = "dbo.ExecuteRegistration";

        public const String SP_RETRIEVE_DOCUMENT = "dbo.RetrieveDocument";
        public const String SP_EXECUTE_DOCUMENT = "dbo.ExecuteDocument";

        public const String SP_RETRIEVE_DOCUMENT_TYPE = "dbo.RetrieveDocumentType";
        public const String SP_EXECUTE_DOCUMENT_TYPE = "dbo.ExecuteDocumentType";

        public const String SP_RETRIEVE_SCHEDULE = "dbo.RetrieveSchedule";
        public const String SP_EXECUTE_SCHEDULE = "dbo.ExecuteSchedule";

        public const String SP_RETRIEVE_EMAIL_SCHEDULE = "dbo.RetrieveEmailSchedule";
        public const String SP_EXECUTE_EMAIL_SCHEDULE = "dbo.ExecuteEmailSchedule";

        public const String SP_RETRIEVE_ROOM = "dbo.RetrieveRoom";
        public const String SP_EXECUTE_ROOM = "dbo.ExecuteRoom";

        public const String SP_RETRIEVE_AUDIT = "dbo.RetrieveAudit";
        public const String SP_EXECUTE_AUDIT = "dbo.ExecuteAudit";

        public const String SP_RETRIEVE_PROPERTIES_ROOM = "dbo.RetrievePropertiesRoom";
        public const String SP_EXECUTE_PROPERTIES_ROOM = "dbo.ExecutePropertiesRoom";

        public const String SP_RETRIEVE_PURCHASE_ORDER = "dbo.RetrievePurchaseOrder";
        public const String SP_EXECUTE_PURCHASE_ORDER = "dbo.ExecutePurchaseOrder";

        public const String SP_RETRIEVE_INVOICE = "dbo.RetrieveInvoice";
        public const String SP_EXECUTE_INVOICE = "dbo.ExecuteInvoice";

        public const String SP_RETRIEVE_ROOM_ITEMS = "dbo.RetrieveRoomItems";
        public const String SP_EXECUTE_ROOM_ITEMS = "dbo.ExecuteRoomItems";

        public const String SP_RETRIEVE_DASHBOARD_GRAPHS = "dbo.RetrieveDashboardGraphs";

        public const String SP_RETRIEVE_CANDIDATES = "dbo.RetrieveCandidates";
        public const String SP_EXECUTE_CANDIDATES = "dbo.ExecuteCandidates";

        public const String SP_RETRIEVE_REQUISITIONS = "dbo.RetrieveRequisitions";
        public const String SP_EXECUTE_REQUISITIONS = "dbo.ExecuteRequisitions";

        public const String SP_RETRIEVE_RECRUITMENT_STAGES = "dbo.RetrieveRecruitmentStages";
        public const String SP_EXECUTE_RECRUITMENT_STAGES = "dbo.ExecuteRecruitmentStages";

        public const String SP_RETRIEVE_JOB_LEVELS = "dbo.RetrieveJobLevels";
        public const String SP_EXECUTE_JOB_LEVELS = "dbo.ExecuteJobLevel";

        public const String SP_RETRIEVE_JOB_ROLES = "dbo.RetrieveJobRoles";
        public const String SP_EXECUTE_JOB_ROLES = "dbo.ExecuteJobRoles";

        public const String SP_RETRIEVE_JOB_TYPES = "dbo.RetrieveJobTypes";
        public const String SP_EXECUTE_JOB_TYPES = "dbo.ExecuteJobTypes";

        public const String SP_RETRIEVE_LOOKUPS = "dbo.RetrieveLookups";
        public const String SP_EXECUTE_LOOKUPS = "dbo.ExecuteLookups";

        public const String SP_RETRIEVE_INTERVIEWS = "dbo.RetrieveInterviews";
        public const String SP_EXECUTE_INTERVIEWS = "dbo.ExecuteInterviews";

        public const String SP_RETRIEVE_LOOKUP = "dbo.RetrieveLookup";

        public const String SP_RETRIEVE_JOB_OFFERS = "dbo.RetrieveJobOffers";
        public const String SP_EXECUTE_JOB_OFFERS = "dbo.ExecuteJobOffers";

        public const String SP_EXECUTE_LOCATIONS = "dbo.ExecuteLocations";
        public const String SP_RETRIEVE_LOCATIONS = "dbo.RetrieveLocations";

        public const String SP_EXECUTE_EMPLOYEE_WORK_EXPERIENCE = "dbo.ExecuteEmployeeWorkExperience";
        public const String SP_RETRIEVE_EMPLOYEE_WORK_EXPERIENCE = "dbo.RetrieveEmployeeWorkExperience";

        public const String SP_EXECUTE_EMPLOYEE_EDUCATION = "dbo.ExecuteEmployeeEducation";
        public const String SP_RETRIEVE_EMPLOYEE_EDUCATION = "dbo.RetrieveEmployeeEducation";

        public const String SP_EXECUTE_EMPLOYEE_CONTACTS = "dbo.ExecuteEmployeeContacts";
        public const String SP_RETRIEVE_EMPLOYEE_CONTACTS = "dbo.RetrieveEmployeeContacts";

        public const String SP_EXECUTE_EMPLOYEE_WORK_LOCATIONS = "dbo.ExecuteEmployeeWorkLocations";
        public const String SP_RETRIEVE_EMPLOYEE_WORK_LOCATIONS = "dbo.RetrieveEmployeeWorkLocations";

        public const String SP_EXECUTE_ADDRESSES = "dbo.ExecuteAddresses";
        public const String SP_RETRIEVE_ADDRESSES = "dbo.RetrieveAddresses";

        public const String SP_EXECUTE_BANK_DETAILS = "dbo.ExecuteBankDetails";
        public const String SP_RETRIEVE_BANK_DETAILS = "dbo.RetrieveBankDetails";

        public const String SP_EXECUTE_REFERENCES = "dbo.ExecuteReferences";
        public const String SP_RETRIEVE_REFERENCES = "dbo.RetrieveReferences";

        public const String SP_RETRIVE_PASSPORTDETAILS = "dbo.RetrievePassportDetails";
        public const String SP_EXECUTE_PASSPORTDETAILSSS = "dbo.ExecutePassportDetails";

        public const String SP_RETRIEVE_EMPLOYEE_VISA_DETAILS = "dbo.RetrieveEmployeeVisaDetails";
        public const String SP_EXECUTE_EMPLOYEE_VISA_DETAILS = "dbo.ExecuteEmployeeVisaDetails";

        public const String SP_RETRIEVE_EMPLOYEE_COS_DETAILS = "dbo.RetrieveEmployeeCOSdetails";
        public const String SP_EXECUTE_EMPLOYEE_COS_DETAILS = "dbo.ExecuteEmployeeCosDetails";

        public const String SP_EXECUTE_DEPARTMENTS = "dbo.ExecuteDepartments";
        public const String SP_RETRIEVE_DEPARTMENTS = "dbo.RetrieveDepartments";

        public const String SP_EXECUTE_DESIGNATIONS = "dbo.ExecuteDesignations";
        public const String SP_RETRIEVE_DESIGNATIONS = "dbo.RetrieveDesignations";

        public const String SP_EXECUTE_SHIFTS = "dbo.ExecuteShifts";
        public const String SP_RETRIEVE_SHIFTS = "dbo.RetrieveShifts";

        public const String SP_RETRIEVE_LOGIN_HISTORY_DETAILS = "dbo.RetrieveLoginHistoryDetails";
        public const String SP_EXECUTE_LOGIN_HISTORY_DETAILS = "dbo.ExecuteLoginHistoryDetails";

        public const String SP_RETRIEVE_SUPPLIEERS = "dbo.RetrieveSuppliers";
        public const String SP_EXECUTE_ITEMMASTER = "dbo.ExecuteItemMaster";

        public const String SP_RETRIEVE_ITEMMASTER = "dbo.RetrieveItemmaster";
        public const String SP_EXECUTE_SUPPLIERS = "dbo.ExecuteSuppliers";

        public const String SP_RETRIEVE_ITEM_CATEGORY = "dbo.RetrieveItemCategory";
        public const String SP_EXECUTE_ITEM_CATEGORY = "dbo.ExecuteItemCategory";

        public const String SP_RETRIEVE_INVENTORY = "dbo.RetrieveInventory";
        public const String SP_EXECUTE_INVENTORY = "dbo.ExecuteInventory";

        public const string SP_RETRIEVE_ROOM_SOLD = "dbo.RetrieveActualRoomsSold";
        public const String SP_EXECUTE_ROOM_SOLD = "dbo.ExecuteActualRoomsSold";

        public const String SP_RETRIEVE_UNIT_TYPE = "dbo.RetrieveUnitType";
        public const String SP_EXECUTE_UNIT_TYPE = "dbo.ExecuteUnitType";

        public const String SP_RETRIEVE_ITEM_LOCATION = "dbo.RetrieveItemLocation";
        public const String SP_EXECUTE_ITEM_LOCATION = "dbo.ExecuteItemLocation";

        public const String SP_RETRIEVE_ITEM_CLASS = "dbo.RetrieveItemClass";
        public const String SP_EXECUTE_ITEM_CLASS = "dbo.ExecuteItemClass";

        public const String SP_RETRIEVE_ROOM_TYPES = "dbo.RetrieveRoomTypes";
        public const String SP_EXECUTE_ROOM_TYPES = "dbo.ExecuteRoomTypes";

        public const String SP_RETRIEVE_TRANSACTION_TYPES = "dbo.RetrieveTransactionTypes";
        public const String SP_EXECUTE_TRANSACTION_TYPES = "dbo.ExecuteTransactionTypes";

        public const String SP_RETRIEVE_PROPERTY_DOCUMENT_TYPE = "dbo.RetrievePropertyDocumentType";
        public const String SP_EXECUTE_PROPERTY_DOCUMENT_TYPE = "dbo.ExecutePropertyDocumentType";

        public const String SP_RETRIEVE_ROOM_TYPE_DETAILS = "dbo.RetrieveRoomTypeDetails";
        public const String SP_EXECUTE_ROOM_TYPE_DETAILS = "dbo.ExecuteRoomTypeDetails";

        public const String SP_RETRIEVE_PAYCLOCK = "dbo.RetrievePayClock";
        public const String SP_EXECUTE_PAYCLOCK = "dbo.ExecutePayClock";

        public const String SP_RETRIEVE_SERVICE = "dbo.RetrieveService";
        public const String SP_EXECUTE_SERVICE = "dbo.ExecuteService";


        public const String SP_RETRIEVE_WORK_ORDER = "dbo.RetrieveWorkOrder";
        public const String SP_EXECUTE_WORK_ORDER = "dbo.ExecuteWorkOrder";

        public const String SP_EXECUTE_WORK_ORDER_TASK = "dbo.ExecuteWorkOrderTask";
        public const String SP_RETRIEVE_WORK_ORDER_TASK = "dbo.RetrieveWorkOrderTask";

        public const String SP_RETRIEVE_SERVICE_TASK = "dbo.RetrieveServiceTask";
        public const String SP_EXECUTE_SERVICE_TASK = "dbo.ExecuteServiceTask";

        public const String SP_RETRIEVE_POLINEITEMS = "dbo.RetrievePOLineItems";

        public const String SP_RETRIEVE_TABLES = "dbo.RetrieveTables";

        public const String SP_RETRIEVE_CHART_OF_ACCOUNTS = "dbo.RetrieveChartofAccounts";
        public const String SP_EXECUTE_CHART_OF_ACCOUNTS = "dbo.ExecuteChartofAccounts";

        public const String SP_EXECUTE_EMPLOYEE_ATTENDANCE = "dbo.ExecuteEmployeeAttendance";

        public const String SP_RETRIEVE_NIGHT_AUDIT = "dbo.RetrieveNightAudit";
        public const String SP_EXECUTE_NIGHT_AUDIT = "dbo.ExecuteNightAudit";

        public const String SP_RETRIEVE_TRANSACTION_TYPE = "dbo.RetrieveTransactionTypes";

        public const String SP_RETRIEVE_BANK_TRANSACTION = "dbo.RetrieveBankTransaction";
        public const String SP_EXECUTE_BANK_TRANSACTION = "dbo.ExecuteBankTransaction";

        public const String SP_RETRIEVE_MESSAGE = "dbo.RetrieveMessage";
        public const String SP_EXECUTE_MESSAGE = "dbo.ExecuteMessage";

        public const String SP_RETRIEVE_COMPARE_REPORT = "dbo.RetrieveCompareReport";

        public const String SP_RETRIEVE_ITEM_CLASS_DETAILS = "dbo.RetrieveItemClassDetails";
        public const String SP_EXECUTE_ITEM_CLASS_DETAILS = "dbo.ExecuteItemClassDetails";

        public const String SP_RETRIEVE_CHECK_LIST_CLASS = "dbo.RetrieveCheckListClass";
        public const String SP_EXECUTE_CHECK_LIST_CLASS = "dbo.ExecuteCheckListClass";

        public const String SP_RETRIEVE_CHECK_LIST = "dbo.RetrieveCheckList";
        public const String SP_EXECUTE_CHECK_LIST = "dbo.ExecuteCheckList";

        public const String SP_RETRIEVE_AUDIT_LOG_SETTINGS = "dbo.RetrieveAuditLogSettings";
        public const String SP_EXECUTE_AUDIT_LOG_SETTINGS = "dbo.ExecuteAuditLogSettings";

        #endregion Stored procedure names

        #region Modes

        public const string PARAM_MODE = "Mode";

        public const int MODE_ONE = 1;

        public const int MODE_TWO = 2;

        public const int MODE_THREE = 3;

        public const int MODE_FOUR = 4;

        public const int MODE_FIVE = 5;

        public const int MODE_SIX = 6;

        public const int MODE_SEVEN = 7;

        public const int MODE_EIGHT = 8;

        public const int MODE_NINE = 9;

        public const int MODE_TEN = 10;

        public const int MODE_ELEVEN = 11;

        public const int MODE_TWELVE = 12;

        public const int MODE_THIRTEEN = 13;

        public const int MODE_FOURTEEN = 14;

        public const int MODE_FIFTEEN = 15;

        public const int MODE_SIXTEEN = 16;

        public const int MODE_SEVENTEEN = 17;

        public const int MODE_EIGHTEEN = 18;

        public const int MODE_NINETEEN = 19;

        public const int MODE_TWENTY = 20;

        public const int MODE_TWENTY_ONE = 21;

        public const int MODE_TWENTY_TWO = 22;

        public const int MODE_TWENTY_THREE = 23;

        public const int MODE_TWENTY_FOUR = 24;

        public const int MODE_TWENTY_FIVE = 25;

        public const int MODE_TWENTY_SIX = 26;

        public const int MODE_TWENTY_SEVEN = 27;

        public const int MODE_TWENTY_EIGHT = 28;

        public const int MODE_TWENTY_NINE = 29;

        public const int MODE_THIRTY = 30;

        #endregion Modes
    }
}
