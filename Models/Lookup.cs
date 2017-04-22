using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Models
{
   public  class Lookup
    {
       public int? LookupID { get; set; }

       public string KID { get; set; }

       public string Name { get; set; }

       public string Value { get; set; }

       public int? DisplayOrder { get; set; }

       public string ActiveFlag { get; set; }

       public List<SelectListItem> lstNames { get; set; }
    }
}
