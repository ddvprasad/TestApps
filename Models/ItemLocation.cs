using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ItemLocation
    {
        public int ItemLocaionID { get; set; }

        public string ItemLocationName { get; set; }

        public string ActiveFlag { get; set; }

        public int CompanyID { get; set; }
    }
}
