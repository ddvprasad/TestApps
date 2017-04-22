using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class NightAudit
    {
        public int? CompanyID { get; set; }
        
        public int? EmployeeID { get; set; }

        public int? PropertyID { get; set; }

        public int? NightAuditID { get; set; }

        public string NightAuditDate { get; set; }

        public string RoomsSoldDate { get; set; }

        public string EmployeeName { get; set; }

        public int? TotalRoomsSold { get; set; }

        public List<NightAuditLog> lstNightAuditLog { get; set; }
    }

    public class NightAuditLog
    {
        public int? NightAuditID { get; set; }

        public int? EmployeeID { get; set; }

        public string EmployeeName { get; set; }

        public string NightAuditLogDate { get; set; }

        public int? CheckOut { get; set; }

        public int? StayOver { get; set; }

        public int? DND { get; set; }
    }
}
