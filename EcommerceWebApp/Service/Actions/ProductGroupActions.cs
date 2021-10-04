using System.Collections.Generic;

namespace EcommerceWebApp.Service.Actions
{
    public class ProductGroup : EntityBase
    {
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<CartRuleProductGroup> CartRuleProductGroups { get; set; }
    }
    public class ProductGroupActions : CustomPersistentObjectActionsReference<EcommerceWebAppContext, ProductGroup>
    {
        public ProductGroupActions(EcommerceWebAppContext context) : base(context) { }
    }
}
