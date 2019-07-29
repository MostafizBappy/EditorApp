using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class Story
    {
        public int StoryId { get; set; }
        public string StoryHeading { get; set; }
        public string StoryBody { get; set; }
        public int? StoryWord { get; set; }
        public int? EntryBy { get; set; }
        public DateTime? EntryDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string NewswrapCode { get; set; }
        public int? Status { get; set; }
        public DateTime? StoryDate { get; set; }
        public string StoryDesk { get; set; }
        public string Keyword { get; set; }
        public string ApprovalStatus { get; set; }
        public int? PublishedWord { get; set; }
        public int? StoryVersion { get; set; }
        public string TransferStoryCode { get; set; }
        public DateTime? ApprovedTime { get; set; }
        public DateTime? UploadTime { get; set; }
        public int? ApprovalCheck { get; set; }
        public int? PageCheck { get; set; }
        public string LastHeading { get; set; }
        public int? SaveMsword { get; set; }
        public string UserCode { get; set; }
        public string StoryType { get; set; }
    }
}
