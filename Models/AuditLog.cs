using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Models
{
    public class AuditLog
    {
        public string Screen { get; set; }

        public string Action { get; set; }

        public string OldValue { get; set; }

        public string NewValue {get; set; }

        public string ActionBy { get; set; }

        public string ActionOn { get; set; }

        public List<SelectListItem> lstTables { get; set; }
    }
}
