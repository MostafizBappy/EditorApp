using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class RapeCaseDetail
    {
        public int RapeCaseDetailId { get; set; }
        public int RapeCaseId { get; set; }
        public string ConvictName { get; set; }
        public string ConvictAge { get; set; }
        public string ConvictIdentityOrRelationship { get; set; }
        public string ConvictsOccupation { get; set; }
    }
}
