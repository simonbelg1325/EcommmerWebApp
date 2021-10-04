namespace EcommerceWebApp.Service.Actions
{
    public class CartRuleProduct : EntityBase
    {
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int CartRuleId { get; set; }
        public virtual CartRule CartRule { get; set; }
    }
    public class CartRuleProductActions : CustomPersistentObjectActionsReference<EcommerceWebAppContext, CartRuleProduct>
    {
        public CartRuleProductActions(EcommerceWebAppContext context) : base(context) { }
    }
}
