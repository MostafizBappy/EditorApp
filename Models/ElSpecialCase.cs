using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class ElSpecialCase
    {
        public int SpecialCaseId { get; set; }
        public int? ElectionId { get; set; }
        public int? ElectionAreaId { get; set; }
        public string Thana { get; set; }
        public string Case2014 { get; set; }
        public string Case2015 { get; set; }
        public string TotalAccused { get; set; }
        public string SpecialAccused { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
