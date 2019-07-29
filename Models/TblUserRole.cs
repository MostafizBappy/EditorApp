using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class TblUserRole
    {
        public int UserRoleId { get; set; }
        public int? RoleId { get; set; }
        public int? UserId { get; set; }
    }
}
