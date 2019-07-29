using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class DwLastStoryPagewise
    {
        public int AutoId { get; set; }
        public DateTime? StoryDate { get; set; }
        public string StoryCode { get; set; }
        public string EditionCode { get; set; }
        public int? PageNo { get; set; }
        public DateTime? StoryTime { get; set; }
    }
}
