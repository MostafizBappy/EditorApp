using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class ElOccupation
    {
        public int OccupationId { get; set; }
        public int? ElectionId { get; set; }
        public int? PersonId { get; set; }
        public int? OccupationTypeId { get; set; }
    }
}
