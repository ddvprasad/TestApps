using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class AttendanceModel
    {
        public int EmployeeID { get; set; }

        public string EmployeeName { get; set; }

        public int CheckID { get; set; }

        public string EmployeeNumber { get; set; }

        public DateTime? CheckInDateTime { get; set; }

        public DateTime? CheckOutDateTime { get; set; }

        public string TimeDifference { get; set; }

        public string CheckInTime { get; set; }

        public string CheckOutTime { get; set; }

        public string TotalTime { get; set; }
    }
}
