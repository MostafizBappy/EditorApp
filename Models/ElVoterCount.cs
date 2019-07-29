using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class ElVoterCount
    {
        public int VoterCountId { get; set; }
        public int? ElectionAreaId { get; set; }
        public int? LastUpdatedYear { get; set; }
        public int? MaleVoter { get; set; }
        public int? FemaleVoter { get; set; }
        public int? TotalVoter { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
