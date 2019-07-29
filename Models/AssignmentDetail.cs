using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class AssignmentDetail
    {
        public int AssignmenDetailtId { get; set; }
        public int? AssignmentId { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public DateTime? ReplyTime { get; set; }
        public string PlaceofReply { get; set; }
        public string ReplyMessage { get; set; }
        public int? RepliedBy { get; set; }
    }
}
