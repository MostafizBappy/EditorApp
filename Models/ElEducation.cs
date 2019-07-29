using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class ElEducation
    {
        public int EducationId { get; set; }
        public int? ElectionId { get; set; }
        public int? PersonId { get; set; }
        public int? EducationTypeId { get; set; }
    }
}
