using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class DwStorySummaryBreakdown
    {
        public int Id { get; set; }
        public string Employeecode { get; set; }
        public string Displayname { get; set; }
        public DateTime? StoryDate { get; set; }
        public int? Selfwritten { get; set; }
        public int? Translated { get; set; }
        public int? Compiled { get; set; }
        public int? Assignment { get; set; }
        public int? Report { get; set; }
        public int? Interview { get; set; }
        public int? Edited { get; set; }
        public int? Approved { get; set; }
        public int? TotalStories { get; set; }
        public int? TotalWords { get; set; }
        public int? DaysWorked { get; set; }
        public int? AvgWordsPerDay { get; set; }
        public string Remark { get; set; }
    }
}
