using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class Anientry
    {
        public int AniNewsId { get; set; }
        public string NewsName { get; set; }
        public string FileName { get; set; }
        public int? Createdby { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
