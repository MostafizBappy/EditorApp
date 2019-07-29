using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class DigiSecurityActVictim
    {
        public int DigiSecurityVictimId { get; set; }
        public int? DigitalSecurityActCaseId { get; set; }
        public string DigiSecurityVictimName { get; set; }
        public string DigiSecurityVictimAge { get; set; }
        public string DigiSecurityVictimOccupation { get; set; }
    }
}
