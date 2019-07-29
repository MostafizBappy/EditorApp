using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class Smslog
    {
        public int SmsId { get; set; }
        public string Smstext { get; set; }
        public int? Smsto { get; set; }
        public int? SmssendBy { get; set; }
        public DateTime? EntryTime { get; set; }
    }
}
