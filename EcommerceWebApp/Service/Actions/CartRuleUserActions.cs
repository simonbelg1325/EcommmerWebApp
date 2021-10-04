namespace EcommerceWebApp.Service.Actions
{
    public class CartRuleUser : EntityBase
    {
        public int CartRuleId { get; set; }
        public virtual CartRule CartRule { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
    public class CartRuleUserActions : CustomPersistentObjectActionsReference<EcommerceWebAppContext, CartRuleUser>
    {
        public CartRuleUserActions(EcommerceWebAppContext context) : base(context) { }
    }
}
