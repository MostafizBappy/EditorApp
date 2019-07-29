using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class ActivityDetail
    {
        public decimal ActivityId { get; set; }
        public int? UserId { get; set; }
        public string ActivityDescription { get; set; }
        public DateTime? EntryDate { get; set; }
        public string Heading { get; set; }
    }
}
