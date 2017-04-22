using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Models
{

    public class Message
    {
        public string Name { get; set; }

        public int NewMessagesCount { get; set; }

        public List<MessageDetail> lstMessages { get; set; }

    }
    public class MessageDetail
    {

        public int MessageID { get; set; }

        public int ParentMessageID { get; set; }

        public string MessageDescription { get; set; }

        public string EmployeeName { get; set; }

        public string RecipientName { get; set; }

        public string ReceivedDate { get; set; }

        public string Messages { get; set; }

        public int EmployeeID { get; set; }

        public int RecipientID { get; set; }

        public List<SelectListItem> lstEmployees { get; set; }

        public int NewMessagesCount { get; set; }

        public bool ReadFlag { get; set; }
    }

   
}
