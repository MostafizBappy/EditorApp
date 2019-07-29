using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class Dctask
    {
        public int TaskId { get; set; }
        public string TaskSubject { get; set; }
        public string TaskDetail { get; set; }
        public int? AssignedBy { get; set; }
        public int? AssignedTo { get; set; }
        public DateTime? AssignedTime { get; set; }
        public int? TaskStatus { get; set; }
    }
}
