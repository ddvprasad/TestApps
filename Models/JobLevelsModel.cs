using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class JobLevelsModel
    {
        public int Job_Level_ID { get; set; }

        public string Job_Level_Name { get; set; } 

        public int Account_ID { get; set; }

        public string Active_Flag { get; set; }
    }
}
