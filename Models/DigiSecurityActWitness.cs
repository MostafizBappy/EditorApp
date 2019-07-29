using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class DigiSecurityActWitness
    {
        public int DigiSecurityWitnessId { get; set; }
        public int? DigitalSecurityActCaseId { get; set; }
        public string DigiSecurityWitnessName { get; set; }
        public string DigiSecurityWitnessAge { get; set; }
        public string DigiSecurityWitnessOccupation { get; set; }
    }
}
