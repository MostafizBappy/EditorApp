using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class ServicePermission
    {
        public int ServiceId { get; set; }
        public string ServiceName { get; set; }
        public int? UserId { get; set; }
    }
}
