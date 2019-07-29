using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class DwUserWiseStory
    {
        public int AutoId { get; set; }
        public string EmployeeCode { get; set; }
        public string StoryCode { get; set; }
        public int Version { get; set; }
        public DateTime StoryDate { get; set; }
        public string Status { get; set; }
    }
}
