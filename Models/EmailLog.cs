using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class EmailLog
    {
        public int EmailId { get; set; }
        public string EmailText { get; set; }
        public int? EmailTo { get; set; }
        public int? EmailSendBy { get; set; }
        public DateTime? EntryTime { get; set; }
    }
}
