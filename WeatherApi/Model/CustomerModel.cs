using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WeatherApi.Model
{
    public class CustomerModel 
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "Firstname is Required")]
        [DisplayName("FIRST NAME")]
        [MaxLength(20, ErrorMessage = "Firstname must not exceed 20 Characters")]
        [DataType(DataType.Text)]

        public string Firstname //#########################
        {
            get; set;
        } = string.Empty;

        [Required(ErrorMessage = "Lastname is Required")]
        [DisplayName("LAST NAME")]
        [MaxLength(20, ErrorMessage = "Lastname must not exceed 20 Characters")]
        [DataType(DataType.Text)]
        public string Lastname //#########################
        {
            get; set;
        } = string.Empty;

        [Required(ErrorMessage = "Othername is Required")]
        [DisplayName("OTHERNAME")]
        [MaxLength(20, ErrorMessage = "Othername must not exceed 20 Characters")]
        [DataType(DataType.Text)]
        public string Othername //#########################
        {
            get; set;
        } = string.Empty;

        [Required(ErrorMessage = "Email is Required")]
        [DataType(DataType.EmailAddress)]
        [DisplayName("EMAIL")]
        //[RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}",
        //    ErrorMessage = "Email is is not valid.")]
        public string Email//#########################
        {
            get; set;
        } = string.Empty;

        [Required(ErrorMessage = "Address is Required")]
        [DataType(DataType.Text)]
        [DisplayName("ADDRESS")]
        [MaxLength(100, ErrorMessage = "Address must not exceed 100 Characters")]

        public string Address//#########################
        {
            get; set;
        } = string.Empty;

        [Required(ErrorMessage = "State is Required")]
        [DataType(DataType.Text)]
        [DisplayName("STATE")]
        [MaxLength(20, ErrorMessage = "State must not exceed 20 Characters")]
        public string State//#########################
        {
            get; set;
        } = string.Empty;

        [Required(ErrorMessage = "City is Required")]
        [DataType(DataType.Text)]
        [DisplayName("CITY")]
        [MaxLength(20, ErrorMessage = "City must not exceed 20 Characters")]
        public string City//#########################
        {
            get; set;
        } = string.Empty;

        [Required(ErrorMessage = "Country is Required")]
        [DisplayName("COUNTRY")]
        [MaxLength(20, ErrorMessage = "Country must not exceed 20 Characters")]
        public string Country//#########################
        {
            get; set;
        } = string.Empty;

        [Required(ErrorMessage = "Phone Number is Required")]
        [DisplayName("PHONE NUMBER")]
        [DataType(DataType.PhoneNumber)]
        [MaxLength(13, ErrorMessage = "Phone Number must not exceed 11 Numbers")]
        public long Phone { get; set; }  //#########################

        [Required(ErrorMessage = "Postal Code  is Required")]
        [DisplayName("POSTAL CODE")]
        [DataType(DataType.PostalCode)]
        [MaxLength(10, ErrorMessage = "PostalCode Number must not exceed 11 Numbers")]
        public int PostalCode { get; set; }  //#########################

        [Required(ErrorMessage = "Password is Required")]
        [DisplayName("PASSWORD")]
        [DataType(DataType.Password)]
        public string Password//#########################
        {
            get; set;
        } = string.Empty;

     
        [Required(ErrorMessage = "Gender is Required")]
        public string Gender//#########################
        {
            get; set;
        }
        //######################################################################

        //public IEnumerable<RolesModel> Roles { get; set; }

        public string SingleRole { get; set; }



    }
}
