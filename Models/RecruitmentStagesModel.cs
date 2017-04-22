using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class RecruitmentStagesModel
    {
        public int Recruitment_Stage_ID { get; set; }

        public string Name { get; set; }

        public int Account_ID { get; set; }

        public string Active_Flag { get; set; }
    }
}
