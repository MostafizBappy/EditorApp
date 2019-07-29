using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class Area
    {
        public int AreaId { get; set; }
        public string AreaName { get; set; }
        public string EmailCc { get; set; }
        public string MobileCc { get; set; }
    }
}
