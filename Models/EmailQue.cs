using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class EmailQue
    {
        public int EmailId { get; set; }
        public string EmailType { get; set; }
        public string EmailTitle { get; set; }
        public string EmailSubject { get; set; }
        public string EmailBody { get; set; }
        public string EmailReceipient { get; set; }
        public string EmailCc { get; set; }
        public string EmailAttachment { get; set; }
        public int? Status { get; set; }
        public DateTime? ProcessedTime { get; set; }
    }
}
