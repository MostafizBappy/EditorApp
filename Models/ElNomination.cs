using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class ElNomination
    {
        public int NominationId { get; set; }
        public int? ElectionId { get; set; }
        public int? ElectionAreaId { get; set; }
        public int? PersonId { get; set; }
        public int? PoliticalPartyId { get; set; }
    }
}
