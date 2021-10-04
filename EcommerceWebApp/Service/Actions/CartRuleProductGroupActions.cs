namespace EcommerceWebApp.Service.Actions
{
    public class CartRuleProductGroup : EntityBase
    {
        public int ProductGroupId { get; set; }
        public virtual ProductGroup ProductGroup { get; set; }
        public int CartRuleId { get; set; }
        public virtual CartRule CartRule { get; set; }
    }
    public class CartRuleProductGroupActions : CustomPersistentObjectActionsReference<EcommerceWebAppContext, CartRuleProductGroup>
    {
        public CartRuleProductGroupActions(EcommerceWebAppContext context) : base(context) { }
    }
}
