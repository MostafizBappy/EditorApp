using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class DwStoryTye
    {
        public int Id { get; set; }
        public string Storycode { get; set; }
        public int? Deskcode { get; set; }
        public string Type { get; set; }
        public string Employeecode { get; set; }
        public DateTime? Storydate { get; set; }
    }
}
