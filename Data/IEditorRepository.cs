using System.Collections.Generic;
using System.Threading.Tasks;
using DatingApp.API.Helpers;
using EditorApp.API.Models;

namespace DatingApp.API.Data
{
    public interface IEditorRepository
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveAll();
        Task<PagedList<View_StorySearch>> GetStories(StoryParams param);
        Task<Story> GetStory(int id);
        Task<List<DwEmployee>> GetAuthorList();
        Task<List<Ncenter>> GetCenterList();
        bool IsHeadingExists(string heading);
    }
}