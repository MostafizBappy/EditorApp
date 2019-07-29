using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class CsCaseSummary
    {
        public int CaseId { get; set; }
        public string CaseDetails { get; set; }
        public DateTime? CaseDate { get; set; }
        public int CaseDistrictId { get; set; }
        public string CaseThanaName { get; set; }
        public string CaseSection { get; set; }
        public DateTime? ChargeSheetDate { get; set; }
        public string ChargeSheetPerson { get; set; }
        public string ArrestedPerson { get; set; }
        public string CaseClosedViaMedia { get; set; }
        public string CaseFiledType { get; set; }
        public string CaseFiledByName { get; set; }
        public string CaseFiledByDesignation { get; set; }
        public string CaseFiledAgainstType { get; set; }
        public string CaseFiledAgainstName { get; set; }
        public string CaseFiledAgainstAddress { get; set; }
        public string CaseFiledAgainstAge { get; set; }
        public int CaseFiledAgainstOccupation { get; set; }
        public string CaseFiledAgainstPoliticalIdentity { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
