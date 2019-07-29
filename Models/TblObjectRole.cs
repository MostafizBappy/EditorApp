using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class TblObjectRole
    {
        public int RoleObjectId { get; set; }
        public int? ObjectId { get; set; }
        public int? RoleId { get; set; }
    }
}
