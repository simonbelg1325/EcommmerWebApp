using System.Collections.Generic;

namespace EcommerceWebApp.Service.Actions
{
    public class OrderStatus : EntityBase
    {
        public string Name { get; set; }
        public int Notification { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<OrderStatusHistory> OrderStatusHistories { get; set; }
    }
    public class OrderStatusActions : CustomPersistentObjectActionsReference<EcommerceWebAppContext, OrderStatus>
    {
        public OrderStatusActions(EcommerceWebAppContext context) : base(context) { }
    }
}
