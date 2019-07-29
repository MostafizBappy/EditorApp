using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class Smsque
    {
        public int SmsId { get; set; }
        public string SmsType { get; set; }
        public string MobileNo { get; set; }
        public string EmpId { get; set; }
        public string SmsBody { get; set; }
        public bool? Status { get; set; }
        public DateTime? ProcessedTime { get; set; }
    }
}
