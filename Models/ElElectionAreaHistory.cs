using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class ElElectionAreaHistory
    {
        public int ElectionAreaHistoryId { get; set; }
        public int? ElectionId { get; set; }
        public int? ElectionAreaId { get; set; }
        public int? PersonId { get; set; }
        public int? PoliticalPartyId { get; set; }
        public string TotalVote { get; set; }
        public int? Position { get; set; }
        public int? IsUncompetitionally { get; set; }
    }
}
