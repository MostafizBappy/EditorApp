using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class ReporterSection
    {
        public int Id { get; set; }
        public string SectionName { get; set; }
        public int? Sorting { get; set; }
    }
}
