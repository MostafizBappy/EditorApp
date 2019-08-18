using System;
using Microsoft.AspNetCore.Http;

namespace EditorApp.API.Dtos
{
    public class PhotoDto
    {
        public decimal Id { get; set; }
        public string PhotoName { get; set; }
        public string UserId { get; set; }
        public IFormFile File { get; set; }
        public string PhotoPath { get; set; }
        public DateTime? PhotoDate { get; set; }
        public string Description { get; set; }
        public DateTime? EntryDate { get; set; }
        public int? UsedStatus { get; set; }
        public string PhotoSize { get; set; }
        public string PhotoDesk { get; set; }
        public string UserCode { get; set; }

        public PhotoDto()
        {
            PhotoDate = DateTime.Now;
            EntryDate = DateTime.Now;
        }
    }
}