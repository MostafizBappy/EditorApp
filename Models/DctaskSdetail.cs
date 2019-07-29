using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class DctaskSdetail
    {
        public int TaskDetailId { get; set; }
        public int? TaskId { get; set; }
        public DateTime? ReplyTime { get; set; }
        public string ReplyText { get; set; }
        public int? RepliedBy { get; set; }
        public int? ReplyStatus { get; set; }
    }
}
