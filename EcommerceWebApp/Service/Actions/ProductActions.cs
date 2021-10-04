using System.Collections.Generic;

namespace EcommerceWebApp.Service.Actions
{
    public class Product : EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Sku { get; set; }
        public int Stock { get; set; }
        public bool Active { get; set; }
        public int TaxId { get; set; }
        public virtual Tax Tax { get; set; }
        public int AttributeSetId { get; set; }
        public virtual AttributeSet AttributeSet { get; set; }
        public int ProductGroupId { get; set; }
        public virtual ProductGroup ProductGroup { get; set; }
        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
        public virtual ICollection<CategoryProduct> CategoryProducts { get; set; }
        public virtual ICollection<AttributeProduct> AttributeProducts { get; set; }
        public virtual ICollection<CartRuleProduct> CartRuleProducts { get; set; }
        public virtual ICollection<CartRule> CartRules { get; set; }
        public virtual ICollection<ProductImage> ProductImages { get; set; }
        public virtual ICollection<SpecificPrice> SpecificPrices { get; set; }
    }
    public class ProductActions : CustomPersistentObjectActionsReference<EcommerceWebAppContext, Product>
    {
        public ProductActions(EcommerceWebAppContext context) : base(context) { }
    }
}
