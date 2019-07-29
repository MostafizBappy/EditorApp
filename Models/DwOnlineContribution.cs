using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class DwOnlineContribution
    {
        public int Id { get; set; }
        public string StoryCode { get; set; }
        public string NewStoryCode { get; set; }
        public string Heading { get; set; }
        public string Contributor { get; set; }
        public string DeskFrom { get; set; }
        public int? FromPublication { get; set; }
        public int? ToPublication { get; set; }
        public int? FromDesk { get; set; }
        public int? ToDesk { get; set; }
        public string TransferedBy { get; set; }
        public DateTime? TransferDate { get; set; }
    }
}
