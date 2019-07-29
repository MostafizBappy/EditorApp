using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class ElElectionArea
    {
        public int ElectionAreaId { get; set; }
        public int? ElectionId { get; set; }
        public string ElectionAreaName { get; set; }
        public int? ElectionAreaSerial { get; set; }
        public string RegularorReserved { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
