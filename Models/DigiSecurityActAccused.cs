using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class DigiSecurityActAccused
    {
        public int DigiSecurityAccusedId { get; set; }
        public int? DigitalSecurityActCaseId { get; set; }
        public string DigiSecurityAccusedName { get; set; }
        public string DigiSecurityAccusedAge { get; set; }
        public string DigiSecurityAccusedOccupation { get; set; }
    }
}
