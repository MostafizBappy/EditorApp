using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class VideoSummary
    {
        public decimal Id { get; set; }
        public string VideoName { get; set; }
        public string VideoPath { get; set; }
        public int? UserId { get; set; }
        public int? CenterCode { get; set; }
        public DateTime? VideoDate { get; set; }
        public string Description { get; set; }
        public string VideoSize { get; set; }
        public DateTime? EntryDate { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
