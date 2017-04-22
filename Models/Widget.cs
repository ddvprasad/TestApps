using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Models
{


    public class Widget
    {
        public int? WidgetID { get; set; }

        public string Name { get; set; }

        public int? DisplayOrder { get; set; }

        public bool VisibleFlag { get; set; }

        public bool HasAccess { get; set; }
    }
   
}