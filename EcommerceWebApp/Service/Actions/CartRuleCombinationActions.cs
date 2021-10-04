namespace EcommerceWebApp.Service.Actions
{
    public class CartRuleCombination : EntityBase
    {
        public int CartRuleCombinations1Id { get; set; }
        public virtual CartRule CartRuleCombinations1 { get; set; }
        public int CartRuleCombinations2Id { get; set; }
        public virtual CartRule CartRuleCombinations2 { get; set; }
    }
    public class CartRuleCombinationActions : CustomPersistentObjectActionsReference<EcommerceWebAppContext, CartRuleCombination>
    {
        public CartRuleCombinationActions(EcommerceWebAppContext context) : base(context) { }
    }
}
