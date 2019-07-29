using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class ElPerson
    {
        public int PersonId { get; set; }
        public string PersonName { get; set; }
        public string PhotoUrl { get; set; }
        public int? CurrentDistrictId { get; set; }
        public int? PermanentDistrictId { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
