using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class ElUpload
    {
        public int UploadId { get; set; }
        public int? ElectionAreaId { get; set; }
        public string FileName { get; set; }
        public string Remarks { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
