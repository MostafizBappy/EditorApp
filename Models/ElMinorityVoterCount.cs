using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class ElMinorityVoterCount
    {
        public int MinorityVoterCountId { get; set; }
        public int? ElectionAreaId { get; set; }
        public int? LastUpdatedYear { get; set; }
        public int? HinduVoter { get; set; }
        public int? BuddhaVoter { get; set; }
        public int? ChristianVoter { get; set; }
        public int? TribalVoter { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
