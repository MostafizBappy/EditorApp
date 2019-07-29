using System;

namespace EditorApp.API.Models
{
    public class View_StorySearch
    {
        public int StoryId { get; set; }
        public string StoryHeading { get; set; }
        public string StoryBody { get; set; }
        public int? StoryWord { get; set; }
        public DateTime? EntryDate { get; set; }
        public DateTime? StoryDate { get; set; }
        public string StoryDesk { get; set; }
        public string Keyword { get; set; }
        public string UserCode { get; set; }
        public string StoryType { get; set; }
        public int? NewswrapCenter { get; set; }
        public string ldapint { get; set; }
        public string displayname { get; set; }
        public string CenterName { get; set; }

    }
}