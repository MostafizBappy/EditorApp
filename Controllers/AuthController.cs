using System;
using System.DirectoryServices.AccountManagement;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using EditorApp.API.Data;
using EditorApp.API.Dtos;
using EditorApp.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace EditorApp.API.Controllers
{
    [Route("api/[controller]")]
    public class AuthController : Controller
    {
        private readonly IConfiguration _config;
        private readonly IMapper _mapper;
        private readonly ReporterContext _context;
        private readonly IAuthRepository _repo;

        public AuthController(IConfiguration config, IMapper mapper, ReporterContext context, IAuthRepository repo)
        {
            _repo = repo;
            _context = context;
            _mapper = mapper;
            _config = config;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody]UserForLoginDto userForLoginDto)
        {
            var authenticatedUser = await Task.Run(() =>
            {
                using (var adContext = new PrincipalContext(ContextType.Domain, "palonet.org"))
                {
                    var result = adContext.ValidateCredentials(userForLoginDto.UserName, userForLoginDto.Password);
                    return result;
                }
            });

            if (authenticatedUser)
            {
                // generate token
                string displayName = GetADInfo(userForLoginDto.UserName);
                var tokenHandler = new JwtSecurityTokenHandler();
                var key = Encoding.ASCII.GetBytes(_config.GetSection("AppSettings:token").Value);
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                     {
                        new Claim(ClaimTypes.NameIdentifier, userForLoginDto.UserName),
                        new Claim(ClaimTypes.Name, displayName)
                    }),
                    Expires = DateTime.Now.AddDays(1),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key),
                        SecurityAlgorithms.HmacSha512Signature)
                };
                var token = tokenHandler.CreateToken(tokenDescriptor);
                var tokenString = tokenHandler.WriteToken(token);

                var userFromRepo = await _repo.GetLoggedInUser(userForLoginDto.UserName);
                var user = _mapper.Map<UserForLoginDto>(userFromRepo);

                return Ok(new { tokenString, user });

            }
            else
            {
                return Unauthorized();
            }

        }

        public string GetADInfo(string empId)
        {
            string displayName = "";
            if(!String.IsNullOrEmpty(empId))
            {
                var oroot = new System.DirectoryServices.DirectoryEntry("LDAP://DC=palonet,DC=org");
                var osearcher = new System.DirectoryServices.DirectorySearcher(oroot);
                osearcher.Filter = string.Format("(&(sAMAccountName={0}))", empId);
                var oresult = osearcher.FindAll();
                if(oresult.Count == 1)
                {
                    if (oresult[0].Properties.Contains("displayname"))
                        displayName = oresult[0].Properties["displayname"][0].ToString();
                }
            }
            return displayName;
        }
    }
}