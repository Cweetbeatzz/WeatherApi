using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Web.Resource;
using System.Security.Claims;
using WeatherApi.Model;

namespace WeatherApi.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    [RequiredScope(RequiredScopesConfigurationKey = "AzureAd:Scopes")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }



        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet("getOne")]
        [Authorize(Roles = "Admin,Manager")]
        public IActionResult getOne()
        {
            //var user = GetUser();

            //if (user.SingleRole != "Admin" || user.SingleRole != "Manager")
            //{
            //    return BadRequest("Unauthorized Access...");
            //}
            return Ok("Cool");
        }

        //[HttpGet("getTwo")]
        //[Authorize(Roles = "Admin,Ceo")]
        //public IActionResult getTwo()
        //{
        //    var user = GetUser();

        //    //if (user.SingleRole != "Admin" || user.SingleRole != "Ceo")
        //    //{
        //    //    return BadRequest("Unauthorized Access...");
        //    //}
        //    return Ok("Mild");
        //}

        //[HttpGet("getThree")]
        //[Authorize(Roles = "Admin")]
        //public IActionResult getThree()
        //{
        //    var user = GetUser();

        //    //if (user.SingleRole != "Admin")
        //    //{
        //    //    return BadRequest("Unauthorized Access...");
        //    //}
        //    return Ok("Warm");
        //}

        //public CustomerModel GetUser()
        //{
        //    var identity = HttpContext.User.Identity as ClaimsIdentity;

        //    if (identity != null)
        //    {
        //        var getUser = identity.Claims;

        //        return new CustomerModel
        //        {
        //            Firstname = getUser.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value,
        //            Email = getUser.FirstOrDefault(x => x.Type == ClaimTypes.Email)?.Value,
        //            Lastname = getUser.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.Value,
        //            SingleRole = getUser.FirstOrDefault(x => x.Type == ClaimTypes.Role)?.Value,
        //        };
        //    }
        //    return null;
        //}

    }
}