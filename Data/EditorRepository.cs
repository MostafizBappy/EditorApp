using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.API.Data;
using DatingApp.API.Helpers;
using EditorApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace EditorApp.API.Data
{
    public class EditorRepository : IEditorRepository
    {
        private readonly ReporterContext _context;
        public EditorRepository(ReporterContext context)
        {
            _context = context;

        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<PagedList<View_StorySearch>> GetStories(StoryParams param)
        {
            var stories = _context.View_StorySearch.Where(s => s.UserCode != null).OrderByDescending(o => o.StoryDate).AsQueryable();

            DateTime fDate;
            DateTime tDate;
            if (param.FromDate == null || param.FromDate == "undefined")
            {
                if (param.ToDate == null || param.ToDate == "undefined")
                {
                }
                else
                {
                    tDate = System.Convert.ToDateTime(param.ToDate);
                    stories = stories.Where(s => s.StoryDate.Value.Date <= tDate.Date);
                }
            }
            else
            {
                if (param.ToDate == null || param.ToDate == "undefined")
                {
                    fDate = System.Convert.ToDateTime(param.FromDate);
                    stories = stories.Where(s => s.StoryDate.Value.Date >= fDate.Date);
                }
                else
                {
                    fDate = System.Convert.ToDateTime(param.FromDate);
                    tDate = System.Convert.ToDateTime(param.ToDate);
                    stories = stories.Where(s => s.EntryDate.Value.Date >= fDate.Date && s.EntryDate.Value.Date <= tDate.Date);
                }
            }

            if (param.Center > 0)
            {
                stories = stories.Where(s => s.NewswrapCenter == param.Center);
            }

            if (param.Author == "undefined" || param.Author == null || param.Author == "null")
            {
            }
            else
            {
                stories = stories.Where(s => s.UserCode == param.Author);
            }

            if (param.StoryDesk == "undefined" || param.StoryDesk == null || param.StoryDesk == "null")
            {
            }
            else
            {
                stories = stories.Where(s => s.StoryDesk == param.StoryDesk);
            }

            if (param.Heading == "undefined" || param.Heading == null || param.Heading == "null")
            {
            }
            else
            {
                stories = stories.Where(s => s.StoryHeading.Contains(param.Heading));
            }

            if (!string.IsNullOrEmpty(param.OrderBy))
            {
                switch (param.OrderBy)
                {
                    case "oldest":
                        stories = stories.OrderBy(o => o.StoryDate);
                        break;
                    default:
                        stories = stories.OrderByDescending(o => o.StoryDate);
                        break;
                }
            }
            return await PagedList<View_StorySearch>.CreatedAsync(stories, param.PageNumber, param.PageSize);
        }

        public async Task<Story> GetStory(int id)
        {
            var story = await _context.Story.FirstOrDefaultAsync(x => x.StoryId == id);
            return story;
        }

        public async Task<List<DwEmployee>> GetAuthorList()
        {
            var authors = await _context.DwEmployee.OrderBy(o => o.Displayname).ToListAsync();
            return authors;
        }

        public async Task<List<Ncenter>> GetCenterList()
        {
            var centers = await _context.Ncenter.OrderBy(o => o.CenterName).ToListAsync();
            return centers;
        }

        public bool IsHeadingExists(string heading)
        {
            bool isExists = false;
            var storyWithHeading = _context.Story.Where(s => s.StoryHeading == heading && s.StoryDate.Value.Date == DateTime.Now.Date).FirstOrDefault();
            if(storyWithHeading != null)
                isExists = true;
            return isExists;
        }
    }
}