namespace EcommerceWebApp.Service.Actions
{
    public class OrderStatusHistory : EntityBase
    {
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
        public int OrderStatusId { get; set; }
        public virtual OrderStatus OrderStatus { get; set; }
    }
    public class OrderStatusHistoryActions : CustomPersistentObjectActionsReference<EcommerceWebAppContext, OrderStatusHistory>
    {
        public OrderStatusHistoryActions(EcommerceWebAppContext context) : base(context) { }
    }
}
