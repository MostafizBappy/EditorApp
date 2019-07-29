using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class ElCentralPolitician
    {
        public int CentralPoliticianId { get; set; }
        public int? ElectionId { get; set; }
        public int? ElectionAreaId { get; set; }
        public int? PersonId { get; set; }
        public string PersonName { get; set; }
        public string CurrentDesignation { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
