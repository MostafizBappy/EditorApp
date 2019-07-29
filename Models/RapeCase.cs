using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class RapeCase
    {
        public int RapeCaseId { get; set; }
        public DateTime? CaseDate { get; set; }
        public DateTime? IncidentDate { get; set; }
        public int? IncidentPlace { get; set; }
        public string OtherIncidentPlace { get; set; }
        public string IncidentDetail { get; set; }
        public int? DistrictId { get; set; }
        public int? UpazillaId { get; set; }
        public string InfoSource { get; set; }
        public DateTime? CaseUpdateDate { get; set; }
        public int? CaseUpdateStatus { get; set; }
        public string ContactInfo { get; set; }
        public bool IsMainConvictFugitive { get; set; }
        public DateTime? MainConvictArrestDate { get; set; }
        public int? TotalConvictedCount { get; set; }
        public string Comment { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
