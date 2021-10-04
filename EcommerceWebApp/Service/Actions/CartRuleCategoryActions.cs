namespace EcommerceWebApp.Service.Actions
{
    public class CartRuleCategory : EntityBase
    {
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public int CartRuleId { get; set; }
        public virtual CartRule CartRule { get; set; }
    }
    public class CartRuleCategoryActions : CustomPersistentObjectActionsReference<EcommerceWebAppContext, CartRuleCategory>
    {
        public CartRuleCategoryActions(EcommerceWebAppContext context) : base(context) { }
    }
}
