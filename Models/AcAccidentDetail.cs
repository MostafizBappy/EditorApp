using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class AcAccidentDetail
    {
        public int AccidentDetailId { get; set; }
        public int? AccidentId { get; set; }
        public int? AccidentTypeId { get; set; }
    }
}
