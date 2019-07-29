using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class ReporterStory
    {
        public int Id { get; set; }
        public string StoryHeading { get; set; }
        public string StoryBody { get; set; }
        public DateTime? EntryDate { get; set; }
        public int? UserId { get; set; }
        public string StoryType { get; set; }
        public string SubmitDesk { get; set; }
        public string StoryCode { get; set; }
        public DateTime? StoryDate { get; set; }
        public string Media { get; set; }
        public int? Status { get; set; }
        public string Keyword { get; set; }
    }
}
