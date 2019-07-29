using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class DwEdition
    {
        public int AutoId { get; set; }
        public int? EditionCode { get; set; }
        public string EditionName { get; set; }
    }
}
