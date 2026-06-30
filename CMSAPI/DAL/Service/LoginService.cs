using EndocPM.WebAPI;
using HMS.DAL.Interface;
using HMS.Entities;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace HMS.DAL
{
    public class LoginService : IIoginService
    {
        public readonly IUnitOfWork _uow;

        public readonly IHttpContextAccessor _httpContextAccessor;
        public readonly IConfiguration _configuration;
        public LoginService(IUnitOfWork uow, IHttpContextAccessor httpContextAccessor, IConfiguration configuration) {

            _uow = uow;
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
        }



        public async Task<IEnumerable<UserLogin>> GetAllUsersAsync()
        {
            return await _uow.GenericRepository<UserLogin>().Table().ToListAsync();
            
        }

        public async Task<UserMaster> Authenticate(string username, string password)
        {
            // Validate user credentials (simplified, ideally hash and compare)
            return await _uow.GenericRepository<UserMaster>().Table()
                .FirstOrDefaultAsync(u => u.UserName == u.UserName && u.PasswordHash == password);
        }

        //public LoginResponse GenerateJwtToken(UserMaster user)
        //{
        //    LoginResponse model = new LoginResponse();
        //    var jwtSettings = _configuration.GetSection("JwtSettings");
        //    var key = Encoding.UTF8.GetBytes(jwtSettings["Key"]);

        //    var tokenDescriptor = new SecurityTokenDescriptor
        //    {
        //        Subject = new ClaimsIdentity(new[]
        //        {
        //        new Claim(ClaimTypes.NameIdentifier, user.UserID.ToString()),
        //        new Claim(ClaimTypes.Name, user.UserName),
             
        //    }),
        //        Expires = DateTime.UtcNow.AddHours(1),
        //        Issuer = jwtSettings["Issuer"],
        //        Audience = jwtSettings["Audience"],
        //        SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
        //    };

        //    var tokenHandler = new JwtSecurityTokenHandler();
        //    var token = tokenHandler.CreateToken(tokenDescriptor);

        //    var jwtToken = tokenHandler.WriteToken(token);

        //    model.UserName = user.UserName;
        //    model.UserID = user.UserID;
        //    model.RoleID = user.RoleID;
        //    model.token = jwtToken.ToString();
        //    model.success = " login successfully";

        //    return model;
        //}



        



         


    }
}
