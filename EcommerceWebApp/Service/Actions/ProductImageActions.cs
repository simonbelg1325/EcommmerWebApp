namespace EcommerceWebApp.Service.Actions
{
    public class ProductImage : EntityBase
    {
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }
    }
    public class ProductImageActions : CustomPersistentObjectActionsReference<EcommerceWebAppContext, ProductImage>
    {
        public ProductImageActions(EcommerceWebAppContext context) : base(context) { }
    }
}
