using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class AcAccidentType
    {
        public int AccidentTypeId { get; set; }
        public string AccidentTypeName { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
