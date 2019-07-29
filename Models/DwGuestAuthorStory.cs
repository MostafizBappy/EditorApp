using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class DwGuestAuthorStory
    {
        public int Id { get; set; }
        public string Storycode { get; set; }
        public int? Version { get; set; }
        public DateTime? StoryDate { get; set; }
        public string AuthorName { get; set; }
        public string ActionBy { get; set; }
        public string Flag { get; set; }
        public string Heading { get; set; }
        public int? DeskCode { get; set; }
        public int? PublicationCode { get; set; }
        public string DisplayName { get; set; }
        public int? AuthorDeskCode { get; set; }
        public string Publication { get; set; }
        public string Desk { get; set; }
    }
}
