using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class ElElection
    {
        public int ElectionId { get; set; }
        public string ElectionName { get; set; }
        public int? ElectionYear { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public int? MajorityPartyId { get; set; }
        public int? OppositionPartyId { get; set; }
        public string Comments { get; set; }
    }
}
