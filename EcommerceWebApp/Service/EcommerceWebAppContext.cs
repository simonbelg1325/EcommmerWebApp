using EcommerceWebApp.Service.Actions;
using Microsoft.EntityFrameworkCore;
using Vidyano.Service;

namespace EcommerceWebApp.Service
{
    public partial class EcommerceWebAppContext : TargetDbContext
    {
        public EcommerceWebAppContext(DbContextOptions<EcommerceWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}
