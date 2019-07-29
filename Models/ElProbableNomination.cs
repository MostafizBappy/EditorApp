using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class ElProbableNomination
    {
        public int ProbableNominationId { get; set; }
        public int? ElectionId { get; set; }
        public int? ElectionAreaId { get; set; }
        public int? PersonId { get; set; }
        public string PersonName { get; set; }
        public int? PoliticalPartyId { get; set; }
        public string Designation { get; set; }
        public string Age { get; set; }
        public int? EducationTypeId { get; set; }
        public int? OccupationTypeId { get; set; }
        public string ChangeHistory { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
