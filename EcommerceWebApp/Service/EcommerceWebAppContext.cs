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
        public DbSet<Company> Companies { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderStatus> OrderStatuses { get; set; }
        public DbSet<OrderStatusHistory> OrderStatusHistories { get; set; }
    }
}
