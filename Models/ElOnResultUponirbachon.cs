﻿using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class ElOnResultUponirbachon
    {
        public int UponirbachonId { get; set; }
        public int? ElectionAreaId { get; set; }
        public int? ElectionId { get; set; }
        public int? PersonId { get; set; }
        public int? PoliticalPartyId { get; set; }
        public int? TotalVote { get; set; }
        public int? SerialNo { get; set; }
        public int? WithoutCompetition { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
