using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class DwVersionWordCount
    {
        public int WordCountId { get; set; }
        public string StoryCode { get; set; }
        public int Version { get; set; }
        public int? WordCount { get; set; }
        public string Author { get; set; }
        public string Owner { get; set; }
        public DateTime? Storydate { get; set; }
        public string Status { get; set; }
        public int? Deskcode { get; set; }
        public int? PublicationCode { get; set; }
    }
}
