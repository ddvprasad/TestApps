using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Models
{
    public class ChartofAccount
    {
        public int ChartofAccountID { get; set; }

        public int? ItemCategoryID { get; set; }

        public string MainAccount { get; set; }

        public string ActiveFlag { get; set; }

        public string ItemCategoryName { get; set; }

        public int CompanyID { get; set; }

        public string Cost { get; set; }

        public List<ChartofAccount> lstChartofAccount { get; set; }

    }
}
