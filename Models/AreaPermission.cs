using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class AreaPermission
    {
        public int AreaPermissionId { get; set; }
        public int? UserId { get; set; }
        public int? AreaId { get; set; }
    }
}
