
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WeatherApi.Dto;
using WeatherApi.Model;
using WeatherApi.Utils;

namespace WeatherApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        private readonly IConfiguration configuration;

        public AuthController(IConfiguration configuration)
        {

            this.configuration = configuration;
        }
        //#############################################################################
        //[HttpPost("Login")]
        //[AllowAnonymous]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        //[ProducesResponseType(StatusCodes.Status204NoContent)]
        //[ProducesResponseType(StatusCodes.Status500InternalServerError)]
        //public async Task<IActionResult> Login(LoginDto loginDto)
        //{
        //    try
        //    {
        //        var getUserByEmail = Authenticate(loginDto);

        //        if (getUserByEmail != null)
        //        {
        //            var token = GenerateToken(getUserByEmail);
        //            return Ok(token);
        //        }

        //        return NotFound();
        //    }
        //    catch (Exception)
        //    {
        //        return StatusCode(500, "An unknowwn error occured");
        //    }


        //}

        //private string GenerateToken(CustomerModel customer)
        //{
        //    var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(this.configuration["JWT:Key"]));
        //    var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
        //    var claims = new[]
        //    {
        //       new Claim(ClaimTypes.NameIdentifier, customer.Id.ToString()),
        //       new Claim(ClaimTypes.Email, customer.Email),
        //       new Claim(ClaimTypes.Name, customer.Lastname),
        //       new Claim(ClaimTypes.Role, customer.SingleRole),
        //    };
        //    var token = new JwtSecurityToken(this.configuration["JWT:Issuer"], this.configuration["JWT:Audience"], claims,
        //        DateTime.UtcNow.AddMinutes(5), signingCredentials: credentials);

        //    return new JwtSecurityTokenHandler().WriteToken(token);
        //}

        private CustomerModel Authenticate(LoginDto login)
        {
            var foundUser = UserConst.Cust.FirstOrDefault(x => x.Email == login.Email && x.Password == login.Password);

            if (foundUser != null)
            {
                return foundUser;

            }
            return null;
        }

        [HttpPost("Custom/Login")]
        public async Task<IActionResult> Login2(LoginDto login)
        {

            var getUserByEmail = Authenticate(login);

            if (getUserByEmail != null)
            {
                var tokendescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[] {

                       new Claim(ClaimTypes.NameIdentifier, getUserByEmail.Id.ToString()),
                       new Claim(ClaimTypes.Email, getUserByEmail.Email),
                       new Claim(ClaimTypes.Name, getUserByEmail.Lastname),
                       new Claim(ClaimTypes.Role, getUserByEmail.SingleRole),

                    }),
                        Expires = DateTime.UtcNow.AddMinutes(5),
                    SigningCredentials = new SigningCredentials
                      (new SymmetricSecurityKey(Encoding.UTF8.GetBytes(this.configuration["JWT:Key"])),
                       SecurityAlgorithms.HmacSha256Signature)
                };
                var tokenhandler = new JwtSecurityTokenHandler();
                var securitytoken = tokenhandler.CreateToken(tokendescriptor);
                var token = tokenhandler.WriteToken(securitytoken);
                return Ok(new { token });
            }

            return NotFound();

        }


        //#############################################################################


    }
}
