using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class GroupPermission
    {
        public int GroupPermissionId { get; set; }
        public int? UserId { get; set; }
        public int? GroupId { get; set; }
    }
}
