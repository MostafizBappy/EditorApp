using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class Event
    {
        public int EventId { get; set; }
        public DateTime? EventDate { get; set; }
        public string EventDescription { get; set; }
        public int? EntryBy { get; set; }
        public DateTime? EntryDate { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? EventDay { get; set; }
        public int? EventMonth { get; set; }
        public int? EventYear { get; set; }
        public string EventBar { get; set; }
    }
}
