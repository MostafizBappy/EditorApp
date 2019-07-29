using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class ElPoliticalParty
    {
        public int PoliticalPartyId { get; set; }
        public string PoliticalPartyName { get; set; }
        public string ElectionLogo { get; set; }
        public int? EstablishedYear { get; set; }
    }
}
