using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;


namespace Models
{
    public class AuditLogSettings
    {
        public string TableName { get; set; }

        public string TableDisplayName { get; set; }

        public string ColumnName { get; set; }

        public string ColumnDataType { get; set; }

        public string ColumnDisplayName { get; set; }

        public bool ShowInInsert { get; set; }

        public bool ShowInUpdate { get; set; }

        public bool ShowInDelete { get; set; }

        public string Query { get; set; }

        public List<SelectListItem> lstTables { get; set; }

        public List<AuditLogSettings> lstTableDetails { get; set; }
    }
}
