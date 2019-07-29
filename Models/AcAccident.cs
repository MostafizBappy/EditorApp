using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class AcAccident
    {
        public int AccidentId { get; set; }
        public DateTime? DateofAccident { get; set; }
        public string AccidentSummary { get; set; }
        public int? DistrictId { get; set; }
        public int? AreaId { get; set; }
        public string HighwayCode { get; set; }
        public string TypeofRoad { get; set; }
        public int? VehichleCausingId { get; set; }
        public int? VehichleVictimId { get; set; }
        public int? VehichleCausedLicensed { get; set; }
        public int? VehichleVictimLicensed { get; set; }
        public int? VehichleCausedFit { get; set; }
        public int? VehichleVictimFit { get; set; }
        public int? VehichleCausedInsuranced { get; set; }
        public int? VehichleVictimInsuranced { get; set; }
        public int? CausedDriverAge { get; set; }
        public int? VictimDriverAge { get; set; }
        public int? CausedRegistration { get; set; }
        public int? VictimRegistration { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
