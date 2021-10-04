using System.Collections.Generic;

namespace EcommerceWebApp.Service.Actions
{
    public class Carrier : EntityBase
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string DeliveryText { get; set; }
        public string Logo { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
    public class CarrierActions : CustomPersistentObjectActionsReference<EcommerceWebAppContext, Carrier>
    {
        public CarrierActions(EcommerceWebAppContext context) : base(context) { }
    }
}
