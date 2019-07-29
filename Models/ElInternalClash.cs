using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class ElInternalClash
    {
        public int InternalClashId { get; set; }
        public int? ElectionId { get; set; }
        public int? ElectionAreaId { get; set; }
        public int? PoliticalPartyId { get; set; }
        public string ClashDescription { get; set; }
        public string SelfClash { get; set; }
        public string Killed { get; set; }
        public string Injured { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
