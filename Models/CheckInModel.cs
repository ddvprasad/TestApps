using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class CheckInModel
    {
        public int EmployeeID { get; set; }

        public int CheckID { get; set; }

        public string EmployeeNumber { get; set; }

        public DateTime?  CheckInDateTime { get; set; }

        public DateTime? CheckOutDateTime { get; set; }
    }
}
