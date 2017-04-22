using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Models
{
    public class SqlTableModel
    {
        public string Table_Name { get; set; }

        public string Column_Name { get; set; }

        public string Exception_Message { get; set; }

        public DataTable dt = new DataTable();

    }
}
