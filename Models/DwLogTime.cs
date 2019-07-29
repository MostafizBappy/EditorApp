using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class DwLogTime
    {
        public int AutoId { get; set; }
        public string EmployeeCode { get; set; }
        public DateTime? LoginDate { get; set; }
        public int? NoofMin { get; set; }
    }
}
