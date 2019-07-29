using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class PlanDetail
    {
        public int PlanId { get; set; }
        public DateTime? PlanDate { get; set; }
        public string PlanSummary { get; set; }
        public int? Entryby { get; set; }
        public DateTime? EntryDate { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
