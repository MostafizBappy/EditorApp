using System.Threading.Tasks;
using EditorApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace EditorApp.API.Data
{
    public class AuthRepository : IAuthRepository
    {
        private readonly ReporterContext _context;
        public AuthRepository(ReporterContext context)
        {
            _context = context;
        }
        public async Task<TblUser> GetLoggedInUser(string lDapId)
        {
            DwEmployee employeeCode = await _context.DwEmployee.FirstOrDefaultAsync(x => x.Ldapint == lDapId);
            var code = employeeCode.Employeecode;
            var user = await _context.TblUser.FirstOrDefaultAsync(u => u.NewswrapCode == code);

            return user;
        }
    }
}