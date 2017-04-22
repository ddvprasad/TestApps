using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class TransactionType
    {
        public int TransactionTypeID { get; set; }

        public string TransactionTypeName { get; set; }

        public string ActiveFlag { get; set; }

        public int CompanyID { get; set; }
    }
}
