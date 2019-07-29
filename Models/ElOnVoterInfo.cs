using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class ElOnVoterInfo
    {
        public int VoterInfoId { get; set; }
        public int? ElectionAreaId { get; set; }
        public int? ElectionId { get; set; }
        public int? TotalVoter { get; set; }
        public int? TotalCenter { get; set; }
        public int? ValidVote { get; set; }
        public int? NonValidVote { get; set; }
        public int? NoVote { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
