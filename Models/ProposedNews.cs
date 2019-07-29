using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class ProposedNews
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Author { get; set; }
        public string Edition { get; set; }
        public int? Page { get; set; }
        public string EditionPage { get; set; }
        public string Picture { get; set; }
        public string Comment { get; set; }
        public DateTime? Pubdate { get; set; }
        public string Entryby { get; set; }
        public string Ad { get; set; }
    }
}
