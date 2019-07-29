using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class RapeCaseDetailVictim
    {
        public int RapeCaseVictimId { get; set; }
        public int RapeCaseId { get; set; }
        public string VictimsName { get; set; }
        public string VictimsAge { get; set; }
        public string VictimsCondition { get; set; }
        public string VictimsOccupation { get; set; }
    }
}
