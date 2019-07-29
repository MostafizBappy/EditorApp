using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class Dcsms
    {
        public int Id { get; set; }
        public string MobileNo { get; set; }
        public string Smstext { get; set; }
        public string Status { get; set; }
        public string SmssendTime { get; set; }
    }
}
