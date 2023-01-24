
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WeatherApi.Model;

namespace WeatherApi.Database
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }


        public DbSet<CustomerModel> Customers { get; set; }
        public DbSet<RolesModel> Roles { get; set; }

    }
}
