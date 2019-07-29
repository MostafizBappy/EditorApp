using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class ElAreaAssignment
    {
        public int AreaAssignmentId { get; set; }
        public int? ElectionAreaId { get; set; }
        public int? UserId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
