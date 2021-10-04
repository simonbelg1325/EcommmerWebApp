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
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Carrier> Carriers { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<SpecificPrice> SpecificPrices { get; set; }
        public DbSet<Tax> Taxes { get; set; }
        public DbSet<CategoryProduct> CategoryProducts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<AttributeSet> AttributeSets { get; set; }
        public DbSet<AttributeAttributeSet> AttributeAttributeSets { get; set; }
        public DbSet<Attribute> Attributes { get; set; }
        public DbSet<AttributeValue> AttributeValues { get; set; }
    }
}
