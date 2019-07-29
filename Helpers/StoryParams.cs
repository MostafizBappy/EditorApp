using System;

namespace DatingApp.API.Helpers
{
    public class StoryParams
    {
        private const int MaxPageSize = 50;
        public int PageNumber { get; set; } = 1;
        private int pageSize = 10;
        public int PageSize
        {
            get { return pageSize;}
            set { pageSize = (value > MaxPageSize) ? MaxPageSize : value;}
        }

        public int UserId { get; set; }
        public string Author { get; set; }
        public string StoryDesk { get; set; }
        public string OrderBy { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public int Center { get; set; }
        public string Heading { get; set; }
    }
}