﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Models
{
    public class JobStatusModel
    {
        public int Job_Status_ID { get; set; }

        public string Name { get; set; }

        public int Account_ID { get; set; }

        public string Active_Flag { get; set; }

    }
}
