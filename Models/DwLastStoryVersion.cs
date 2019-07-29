using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class DwLastStoryVersion
    {
        public long AutoId { get; set; }
        public string StoryCode { get; set; }
        public string LastHeading { get; set; }
        public int LastVersion { get; set; }
    }
}
