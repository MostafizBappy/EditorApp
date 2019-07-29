using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class ElAsset
    {
        public int AssetId { get; set; }
        public int? ElectionId { get; set; }
        public int? ElectionAreaId { get; set; }
        public int? PersonId { get; set; }
        public string PersonName { get; set; }
        public string SelfAsset { get; set; }
        public string DependentAsset { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
