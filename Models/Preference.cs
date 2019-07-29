using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class Preference
    {
        public int PreferenceId { get; set; }
        public int? UserId { get; set; }
        public string PreferenceType { get; set; }
        public int? Status { get; set; }
    }
}
