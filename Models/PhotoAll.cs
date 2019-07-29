using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class PhotoAll
    {
        public decimal Id { get; set; }
        public string PhotoName { get; set; }
        public string PhotoPath { get; set; }
        public int? UserId { get; set; }
        public int? CenterCode { get; set; }
        public DateTime? PhotoDate { get; set; }
        public string Description { get; set; }
        public int? UsedStatus { get; set; }
        public string PhotoSize { get; set; }
        public DateTime? EntryDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string PhotoDesk { get; set; }
    }
}
