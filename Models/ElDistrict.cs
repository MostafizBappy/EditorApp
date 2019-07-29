using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class ElDistrict
    {
        public int DistrictId { get; set; }
        public string DistrictName { get; set; }
        public string DistrictNameEn { get; set; }
        public int? DivisionId { get; set; }
    }
}
