using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class DwEmployee
    {
        public int Id { get; set; }
        public string Employeecode { get; set; }
        public string Displayname { get; set; }
        public int? Deskcode { get; set; }
        public int? Publicationcode { get; set; }
        public string Ldapint { get; set; }
        public int? Groupcode { get; set; }
        public string Reportingdesk { get; set; }
    }
}
