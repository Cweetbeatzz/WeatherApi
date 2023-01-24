using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Security.Claims;
using WeatherApi.Model;

namespace WeatherApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
   {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        [HttpGet("GetWeatherForecast")]
        public IActionResult Get()
        {
            var user = GetLoggedUserIdAndRole();

            return Ok(Summaries);
        }
        //#############################################################################

        [HttpGet("getOne")]
        [Authorize(Roles = "Admin,Manager")]
        public IActionResult getOne()
        {
            var user = GetLoggedUserIdAndRole();

            return Ok("Cool");
        }

        //#############################################################################


        [HttpGet("getTwo")]
        [Authorize(Roles = "Admin,Ceo")]
        public IActionResult getTwo()
        {
            var user = GetLoggedUserIdAndRole();

         
            return Ok("Mild");
        }
        //#############################################################################

        [HttpGet("getThree")]
        [Authorize(Roles = "Admin")]
        public IActionResult getThree()
        {
            var user = GetUser();

            return Ok("Warm");
        }

        //#####################################################
        protected string GetLoggedUserIdAndRole()
        {
            return User.FindFirst(ClaimTypes.NameIdentifier).Value;
        }
        //#####################################################

        protected CustomerModel GetUser()
        {
            var identity = User.Identity as ClaimsIdentity;

            if (identity != null)
            {
                var getUser = identity.Claims;

                return new CustomerModel
                {
                    Firstname = getUser.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value,
                    Email = getUser.FirstOrDefault(x => x.Type == ClaimTypes.Email)?.Value,
                    Lastname = getUser.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.Value,
                    SingleRole = getUser.FirstOrDefault(x => x.Type == ClaimTypes.Role)?.Value,
                };
            }
            return null;
        }
        //#############################################################################

    }
}
