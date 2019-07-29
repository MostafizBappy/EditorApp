using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class DwPageWiseStory
    {
        public int AutoId { get; set; }
        public string StoryCode { get; set; }
        public int? VersionCode { get; set; }
        public int? EditionCode { get; set; }
        public int? PageNo { get; set; }
        public string FlowStatus { get; set; }
        public DateTime? StoryDate { get; set; }
    }
}
