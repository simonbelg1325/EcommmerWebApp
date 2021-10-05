using EcommerceWebApp.Service.Actions;
using Microsoft.EntityFrameworkCore;
using System.Linq;
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
        public DbSet<AttributeProduct> AttributeProducts { get; set; }
        public DbSet<CartRuleProduct> CartRuleProducts { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ProductGroup> ProductGroups { get; set; }
        public DbSet<CartRuleProductGroup> CartRuleProductGroups { get; set; }
        public DbSet<CartRuleCategory> CartRuleCategories { get; set; }
        public DbSet<CartRule> CartRules { get; set; }
        public DbSet<CartRuleCombination> CartRuleCombinations { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RoleUser> RoleUsers { get; set; }
        public DbSet<PermissionRole> PermissionRoles { get; set; }
        public DbSet<Permission> Permissions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<CartRuleCombination>()
                .HasOne(r => r.CartRuleCombinations1)
                .WithMany(p => p.CartRuleCombinations2)
                .HasForeignKey(r => r.CartRuleCombinations1Id)
                .OnDelete(DeleteBehavior.ClientNoAction)
                .IsRequired();

            modelBuilder.Entity<CartRuleCombination>()
                .HasOne(r => r.CartRuleCombinations2)
                .WithMany(p => p.CartRuleCombinations1)
                .HasForeignKey(r => r.CartRuleCombinations2Id)
                .OnDelete(DeleteBehavior.ClientNoAction)
                .IsRequired();

            foreach (var foreignKey in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
                foreignKey.DeleteBehavior = DeleteBehavior.ClientNoAction;

            base.OnModelCreating(modelBuilder);
        }
    }
}
