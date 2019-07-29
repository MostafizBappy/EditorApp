using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class TblDeskinchargeReport
    {
        public int Id { get; set; }
        public string DeskIncharge { get; set; }
        public string Subordinates { get; set; }
        public string Comment { get; set; }
    }
}
