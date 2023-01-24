using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace WeatherApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        protected string GetLoggedUserIdAndRole()
        {
            return User.FindFirst(ClaimTypes.NameIdentifier).Value;
        }
    }
}
