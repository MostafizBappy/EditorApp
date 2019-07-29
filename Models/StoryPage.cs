using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class StoryPage
    {
        public decimal StoryPageId { get; set; }
        public int? StoryId { get; set; }
        public int? EditionId { get; set; }
        public int? PageNo { get; set; }
        public string Flown { get; set; }
    }
}
