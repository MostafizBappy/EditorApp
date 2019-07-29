using System.Threading.Tasks;
using EditorApp.API.Models;

namespace EditorApp.API.Data
{
    public interface IAuthRepository
    {
        Task<TblUser> GetLoggedInUser(string lDapId);
    }
}