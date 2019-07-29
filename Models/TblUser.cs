using System;
using System.Collections.Generic;

namespace EditorApp.API.Models
{
    public partial class TblUser
    {
        public int UserId { get; set; }
        public string UserCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string MobileNo { get; set; }
        public int DesignationId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int? EntryBy { get; set; }
        public DateTime? EntryDate { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? IsReporter { get; set; }
        public int? GroupId { get; set; }
        public string Holiday { get; set; }
        public string NewswrapCode { get; set; }
        public string NewswrapDesk { get; set; }
        public int? NewswrapCenter { get; set; }
        public int? AreaId { get; set; }
        public string BishalGroup { get; set; }
        public string Address { get; set; }
        public int? DistrictNameId { get; set; }
        public int? UpazillaNameId { get; set; }
        public int? IsMohanogor { get; set; }
        public string ReportGroup { get; set; }
        public int? ReportOrder { get; set; }
        public int? ApprovePermission { get; set; }
        public int? SectionId { get; set; }
        public bool? IsPhotoHead { get; set; }
    }
}
