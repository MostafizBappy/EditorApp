using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class DeskPermission
    {
        public int DeskPermissionId { get; set; }
        public int? UserId { get; set; }
        public string DeskCode { get; set; }
    }
}
