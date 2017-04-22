using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public class EmailSchedule
    {
       public int? EmailScheduleID { get; set; }

        public int? CompanyID { get; set; }

        public int? PropertyID { get; set; }

        public string To { get; set; }

        public int EmailTemplateID { get; set; }

        public int ScheduleType { get; set; }

        public DateTime? EmailSendDate { get; set; }

        public DateTime? NextSentDate { get; set; }

        public bool EmailSentFlag { get; set; }

    }
}
