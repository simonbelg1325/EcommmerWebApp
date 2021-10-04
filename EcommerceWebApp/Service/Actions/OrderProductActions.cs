namespace EcommerceWebApp.Service.Actions
{
    public class OrderProduct : EntityBase
    {
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
    public class OrderProductActions : CustomPersistentObjectActionsReference<EcommerceWebAppContext, OrderProduct>
    {
        public OrderProductActions(EcommerceWebAppContext context) : base(context) { }
    }
}
