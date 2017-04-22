
using System.Collections.Generic;
using System.Web.Mvc;
namespace Models
{
    public class BaseModel
    {
        public string ErrorMessage { get; set; }

        public string DateErrorMessage { get; set; }

        public string HrsErrorMessage { get; set; }

        public string ValidateScheduleEmail { get; set; }

        public decimal OverTime { get; set; }

        public string Name { get; set; }

        public string ScheduledHrs { get; set; }

        public int Offset { get; set; }

        public int PageSize { get; set; }

        public int SortBy { get; set; }

        public string SortDirection { get; set; }

    }
}
