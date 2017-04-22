using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class RoomType
    {
        public int RoomTypeID { get; set; }

        public int RoomTypeDatailID { get; set; }

        public string RoomTypeDatailName { get; set; }

        public string RoomTypeName { get; set; }

        public string ActiveFlag { get; set; }

        public int CompanyID { get; set; }
    }
}
