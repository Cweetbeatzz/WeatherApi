using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WeatherApi.Model
{
    public class RolesModel 
    {
        public string RoleId { get; set; } = "ROLE" + "-" + Guid.NewGuid().ToString();
        [Required, MinLength(3)]
        [DisplayName("Role Name")]
        public string RoleName { get; set; } = string.Empty;
        public string RoleDescription { get; set; }
    }
}
