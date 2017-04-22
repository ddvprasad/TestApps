using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Models
{
    public class PayClockImport
    {
        public int? BatchID { get; set; }

        public int? EmployeeID { get; set; }

        public string EmployeeName { get; set; }

        public string BatchDate { get; set; }

        public string PayClockLogDate { get; set; }

        public string FilePath { get; set; }

        public string FileName { get; set; }

        public int NumberOfEmployees { get; set; }

        public int NumberOfProcessedEmployees { get; set; }

        public string LogInTime { get; set; }

        public string LogOutTime { get; set; }

        public string IsProcessed { get; set; }

        public string Reason { get; set; }

        public string PayClockActualHours { get; set; }

        public string EmployeeNumber { get; set; }

        public string TotalHourDescription { get; set; }

        public string MMMActualHours { get; set; }
    }

}
