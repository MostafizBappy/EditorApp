using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class ElPersonPartyHistory
    {
        public int PersonPartyHistoryId { get; set; }
        public int? ElectionId { get; set; }
        public int? PersonId { get; set; }
        public string CentralPost { get; set; }
        public string LocalPost { get; set; }
        public int? FromYear { get; set; }
        public int? ToYear { get; set; }
        public int? IsCurrent { get; set; }
    }
}
