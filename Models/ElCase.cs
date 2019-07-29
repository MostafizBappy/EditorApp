using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class ElCase
    {
        public int CaseId { get; set; }
        public int? ElectionId { get; set; }
        public int? PersonId { get; set; }
        public int? CurrentCase { get; set; }
        public string PreviousCase { get; set; }
    }
}
