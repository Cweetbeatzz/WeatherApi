using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WeatherApi.Dto
{
    public class LoginDto
    {

        //public bool RememberMe { get; set; }

        [Required(ErrorMessage = "Email is Required")]
        [DataType(DataType.EmailAddress)]
        [DisplayName("EMAIL")]
        //[RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}",
        //ErrorMessage = "Email is is not valid.")]
        public string Email//#########################
        {
            get; set;
        } = string.Empty;

        [Required(ErrorMessage = "Password is Required")]
        [DisplayName("PASSWORD")]
        [DataType(DataType.Password)]
        public string Password//#########################
        {
            get; set;
        } = string.Empty;
    }
}
