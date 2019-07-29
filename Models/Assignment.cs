using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class Assignment
    {
        public int AssignmentId { get; set; }
        public DateTime? AssignmentDate { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string AssgingmentSubject { get; set; }
        public string AssignmentPlace { get; set; }
        public string AssignmentOrganization { get; set; }
        public string AssignmentPersonality { get; set; }
        public int? AssignedBy { get; set; }
        public int? AssignedTo { get; set; }
        public DateTime? AssignedDate { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string PictureNeed { get; set; }
        public int? OnLeave { get; set; }
        public string SpecialNote { get; set; }
        public int? AssignmentDay { get; set; }
        public int? Followup { get; set; }
        public int? AssignmentStatus { get; set; }
        public int? AssignmentTypeId { get; set; }
        public string EmployeeCode { get; set; }
        public bool? IsPhotographerAssigned { get; set; }
    }
}
