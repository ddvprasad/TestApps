using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Models
{
    public class RoomTypeDetail
    {
        public int RoomTypeID { get; set; }

        public int RoomTypeDatailID { get; set; }

        public int? ItemClassID { get; set; }

        public string ItemClassIDS { get; set; }

        public string RoomTypeDatailName { get; set; }

        public string RoomTypeName { get; set; }

        public string NumberofBeds { get; set; }

        public string ActiveFlag { get; set; }

        public string UpdatePAR { get; set; }

        public string Message { get; set; }

        public string ItemCount { get; set; }

        public string ItemClassCount { get; set; }

        public string strItemClass { get; set; }

        public int CompanyID { get; set; }

        public string CurrentPAR { get; set; }

        public string ItemClassName { get; set; }

        public IEnumerable<SelectListItem> ddllstClasses { get; set; }
    }
}
