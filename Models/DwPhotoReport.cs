using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class DwPhotoReport
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Employeecode { get; set; }
        public DateTime? PhotoDate { get; set; }
        public int? Uploaded { get; set; }
        public int? Published { get; set; }
        public int? DeskCode { get; set; }
    }
}
