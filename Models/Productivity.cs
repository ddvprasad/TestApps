using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Models
{
    public class Productivity
    {
        public List<Room> lstRooms { get; set; }

        public int? EmployeeID { get; set; }

        public int? PropertyID { get; set; }    

        public List<SelectListItem> lstEmployees { get; set; }

        public IEnumerable<SelectListItem> ddllstEmployees { get; set; }

        public IEnumerable<SelectListItem> ddllstProperties { get; set; }

        public string Date { get; set; }

        public string FromDate { get; set; }

        public string ToDate { get; set; }

        public string Properties { get; set; }

        public string EmployeeName { get; set; }

        public string TotalHours { get; set; }

        public string EmployeeIDs { get; set; }

        public string TotalChekOut { get; set; }

        public string TotalStayOver { get; set; }

        public string TotalDND { get; set; }

        public string TotalNotCleaned { get; set; }

        public string TotalHeadHouseKeeper { get; set; }

        public string TotalLaundry { get; set; }

        public string TotalRoomSold { get; set; }

        public string TotalRoomSoldMPR { get; set; }

        public string TotalRoomCleaned { get; set; }

        public string TotalRoomCleanedMPR { get; set; }

        public string TotalRoomSoldWithHoHMPR { get; set; }

        public string TotalRoomSoldWithLaundryMPR { get; set; }

        public string TotalRoomCleanedWithHoHMPR { get; set; }

        public string TotalRoomCleanedWithLaundryMPR { get; set; }

        public string AvgRoomSoldWithHoHMPR { get; set; }

        public string AvgRoomSoldWithLaundryMPR { get; set; }

        public string AvgRoomCleanedWithHoHMPR { get; set; }

        public string AvgRoomCleanedWithLaundryMPR { get; set; }

        public string TotalTotalHrs { get; set; }

        public string TotalActualHrsWorked { get; set; }

        public string AvgChekOut { get; set; }

        public string AvgStayOver { get; set; }

        public string AvgDND { get; set; }

        public string AvgNotCleaned { get; set; }

        public string AvgHeadHouseKeeper { get; set; }

        public string AvgLaundry { get; set; }

        public string AvgRoomSold { get; set; }

        public string AvgRoomSoldMPR { get; set; }

        public string AvgRoomCleaned { get; set; }

        public string AvgRoomCleanedMPR { get; set; }

        public string AvgTotalHrs { get; set; }

        public string AvgActualHrsWorked { get; set; }

        public int ChkHSKP { get; set; }

        public int ChkLaundry { get; set; }

        public bool UpdateFlag { get; set; }

        public List<int> lstPropertyIDS { get; set; }

        public string PropertyIDS { get; set; }

        public MultiSelectList ddllstProperty { get; set; }

        public List<int> lstEmployeeIDS { get; set; }

        public MultiSelectList ddllstEmployee { get; set; }

    }

    public class Room : BaseModel
    {
        public DateTime FillDate { get; set; }

        public string Date { get; set; }

        public string StrDate { get; set; }

        public string PropertyName { get; set; }

        public int? PropertyID { get; set; }

        public string PropertyIDEN { get; set; }

        public int? ChekOut { get; set; }

        public string DayName { get; set; }

        public int? StayOver { get; set; }

        public int? DND { get; set; }

        public int? Priority { get; set; }

        public int? NotCleaned { get; set; }

        public string Housekeeping { get; set; }

        public string HeadHouseKeeper { get; set; }

        public int? SecHeadHouseKeeper { get; set; }

        public string ActualHrsWorked { get; set; }

        public string TotalHrs { get; set; }

        public int? SecTotalHrs { get; set; }

        public int? SecHouseKeeping { get; set; }

        public int? SecActualHrsWorked { get; set; }

        public DateTime ScheduleDate { get; set; }

        public string Laundry { get; set; }

        public int? SecLaundry { get; set; }

        public string TotalSold { get; set; }

        public int? TotalSoldI { get; set; }

        public string TotalCleaned { get; set; }

        public string AvailableHrs { get; set; }

        public string AvailableHrsl { get; set; }

        public string RoomSold { get; set; }

        public string RoomSoldMPR { get; set; }

        public string RoomSoldWithHoHMPR { get; set; }

        public string RoomSoldWithLaundryMPR { get; set; }

        public int? SecRoomSoldWithHoHMPR { get; set; }

        public int? SecRoomSoldWithLaundryMPR { get; set; }

        public string ClassRoomSold { get; set; }

        public string ClassRoomCleaned { get; set; }

        public string ClassRoomSoldWithHoH { get; set; }

        public string ClassRoomCleanedWithHoH { get; set; }

        public string ClassRoomSoldWithLaundry { get; set; }

        public string ClassRoomCleanedWithLaundry { get; set; }

        public int? SecRoomSoldMPR { get; set; }

        public string RoomSoldl { get; set; }

        public string RoomCleaned{ get; set; }

        public string RoomCleanedMPR { get; set; }

        public string RoomCleanedWithHoHMPR { get; set; }

        public string RoomCleanedLaundryMPR { get; set; }

        public int? SecRoomCleanedWithHoHMPR { get; set; }

        public int? SecRoomCleanedLaundryMPR { get; set; }

        public int? SecRoomCleanedMPR { get; set; }

        public string RoomCleanedl { get; set; }

        public string RoomSoldMinutes { get; set; }

        public string RoomCleanedMinutes { get; set; }

        public string Status { get; set; }

        public int RoomID { get; set; }

        public int EmployeeID { get; set; }

        public string EmployeeName { get; set; }

        public int? ActualHours { get; set; }

        public int? PropertyRoomID { get; set; }

        public string PropertyRoomIDEN { get; set; }

        [Required(ErrorMessage = "Select Room Type")]
        public int? RoomTypeKID { get; set; }

        public string RoomType { get; set; }

        public string RoomDescription { get; set; }

        [Required(ErrorMessage = "Enter Room Number")]
        public string RoomNumber { get; set; }

        public bool ActiveFlag { get; set; }

        public List<SelectListItem> lstRoomTypes { get; set; }

        public int DecimalActualHrsWorked { get; set; }

        public int? RowNumber { get; set; }

        public bool UpdateFlag { get; set; }

        public string RoleName { get; set; }

        public string TotalRoomsSold { get; set; }

        public int? FloorID { get; set; }

        public string FloorName { get; set; }

        public List<SelectListItem> lstFloors { get; set; }

    }

    public class RoomItems : BaseModel
    {
        public int? PropertyRoomID { get; set; }

        public int? RoomItemID { get; set; }

        //public int? UnitQuantityRequired { get; set; }

        public string UnitQuantityRequired { get; set; }

        public int? ItemID { get; set; }

        public string ItemName { get; set; }

        public bool ActiveFlag { get; set; }

        public string ItemClassName { get; set; }

        public int? ItemClassID { get; set; }

        public List<SelectListItem> lstItems { get; set; }

        public List<SelectListItem> lstItemClasses { get; set; }

    }

}
