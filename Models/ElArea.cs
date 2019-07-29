using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class ElArea
    {
        public int AreaId { get; set; }
        public int? DistrictId { get; set; }
        public string AreaName { get; set; }
        public int? IsUpazila { get; set; }
        public int? IsUnion { get; set; }
        public int? IsThana { get; set; }
    }
}
