using WeatherApi.Model;

namespace WeatherApi.Utils
{
    public static class UserConst
    {
        public static List<CustomerModel> Cust = new List<CustomerModel>() {
                new CustomerModel { Firstname= "Admin",Address ="no 233 weiwejifoejfio dkowfjiwef",City="Lagos",Country="Nigeria",Email="Admin@gmail.com",Gender="Male",Id = 1,Lastname= "Admin",Othername = "Admin",Password="12345",Phone=12345678909,PostalCode=112113,SingleRole="Admin",State="Lagos"},
                    new CustomerModel { Firstname= "Manager", Address ="no 233 weiwejifoejfio dkowfjiwef",City="Lagos", Country="Nigeria",Email="Manager@gmail.com",Gender="Male",Id = 2,Lastname= "Manager",Othername = "Manager",Password="12345",Phone=12345678909,PostalCode=112113, SingleRole="Manager",State="Lagos"},
                        new CustomerModel {Firstname = "Ceo", Address = "no 233 weiwejifoejfio dkowfjiwef", City = "Lagos", Country = "Nigeria", Email = "Ceo@gmail.com", Gender = "Male", Id = 3, Lastname = "Ceo", Othername = "Ceo", Password = "12345", Phone = 12345678909, PostalCode = 112113, SingleRole = "Ceo", State = "Lagos"},
        };
    }
}
