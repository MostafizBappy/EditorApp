using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class DigitalSecurityActCase
    {
        public int Id { get; set; }
        public string SerialNo { get; set; }
        public DateTime? DigitalCaseDate { get; set; }
        public int? DistrictId { get; set; }
        public int? ThanaId { get; set; }
        public string DigitalCaseNo { get; set; }
        public string Section { get; set; }
        public string Informant { get; set; }
        public string Ro { get; set; }
        public string Oc { get; set; }
        public string Io { get; set; }
        public string Contacts { get; set; }
        public string CaseState { get; set; }
        public string Incident { get; set; }
        public string Evidence { get; set; }
        public string CommentFir { get; set; }
        public string Cmnt { get; set; }
        public string Quotes { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string EditedBy { get; set; }
        public DateTime? EditedDate { get; set; }
    }
}
