using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class UnitType
    {
        public int UnitTypeID { get; set; }

        public string UnitName { get; set; }

        public string ActiveFlag { get; set; }

        public int CompanyID { get; set; }
    }
}
