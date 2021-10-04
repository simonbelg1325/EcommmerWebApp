using System.Collections.Generic;

namespace EcommerceWebApp.Service.Actions
{
    public class Category : EntityBase
    {
        public string Name { get; set; }
        public string Slug { get; set; }
        public int Ift { get; set; }
        public int Rgt { get; set; }
        public int Depth { get; set; }
        public virtual ICollection<CategoryProduct> CategoryProducts { get; set; }
        public virtual ICollection<CartRuleCategory> CartRulesCategories { get; set; }
    }
    public class CategoryActions : CustomPersistentObjectActionsReference<EcommerceWebAppContext, Category>
    {
        public CategoryActions(EcommerceWebAppContext context) : base(context) { }
    }
}
