namespace EcommerceWebApp.Service.Actions
{
    public class CategoryProduct : EntityBase
    {
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
    public class CategoryProductActions : CustomPersistentObjectActionsReference<EcommerceWebAppContext, CategoryProduct>
    {
        public CategoryProductActions(EcommerceWebAppContext context) : base(context) { }
    }
}
