using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class EmployeeWork
    {
        public int Id { get; set; }
        public int Userid { get; set; }
        public DateTime Entrydate { get; set; }
        public string Day { get; set; }
        public int? Selfwritten { get; set; }
        public int? Translation { get; set; }
        public int? Edit { get; set; }
        public int? Approved { get; set; }
        public int? Words { get; set; }
        public string Comment { get; set; }
    }
}
