using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class ReporterSms
    {
        public int Id { get; set; }
        public int? AssignmentId { get; set; }
        public string Status { get; set; }
        public string SmssendTime { get; set; }
    }
}
