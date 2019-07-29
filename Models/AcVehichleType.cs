using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class AcVehichleType
    {
        public int VehichleTypeId { get; set; }
        public string VehichleTypeName { get; set; }
        public string VehichleCategory { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
