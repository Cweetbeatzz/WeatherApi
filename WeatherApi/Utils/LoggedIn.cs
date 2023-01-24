using System.Security.Claims;
using WeatherApi.Model;

namespace WeatherApi.Utils
{
    public class LoggedIn
    {
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
