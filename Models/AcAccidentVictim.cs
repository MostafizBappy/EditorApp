using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class AcAccidentVictim
    {
        public int AccidentVictimId { get; set; }
        public int? AccidentId { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public string Gender { get; set; }
        public string InjuredorKilled { get; set; }
        public int? VictimDistrictId { get; set; }
    }
}
