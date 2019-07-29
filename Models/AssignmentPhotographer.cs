using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class AssignmentPhotographer
    {
        public int Id { get; set; }
        public int AssignmentId { get; set; }
        public int? AssignedById { get; set; }
        public int? AssignedPgid { get; set; }
        public DateTime? AssignedDate { get; set; }
    }
}
