using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Models
{
    public class ItemClass
    {
        public int ItemClassID { get; set; }

        public string ItemClassName { get; set; }

        public string ActiveFlag { get; set; }

        public int CompanyID { get; set; }

        public string Name { get; set; }

        public int ItemClassDetailID { get; set; }

        public List<SelectListItem> lstPrefix { get; set; }

        public List<SelectListItem> lstSuffix { get; set; }

        public string ddlID { get; set; }

        public List<SelectListItem> lstChartofAccount { get; set; }

        public int? ChartofAccountID { get; set; }

        public string MainAccount { get; set; }
    }
}
