using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Models
{
    public class EmailTemplate
    {
        public string Subject { get; set; }

        public string Body { get; set; }

        public string FromAddress { get; set; }

        public string Name { get; set; }
    }
}