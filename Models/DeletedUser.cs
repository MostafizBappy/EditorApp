using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class DeletedUser
    {
        public int AutoId { get; set; }
        public int? UserId { get; set; }
        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public string MobileNo { get; set; }
        public string UserName { get; set; }
        public string Address { get; set; }
        public string UserGroup { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
