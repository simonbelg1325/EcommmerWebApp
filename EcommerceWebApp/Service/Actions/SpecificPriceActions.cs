using System;

namespace EcommerceWebApp.Service.Actions
{
    public class SpecificPrice : EntityBase
    {
        public decimal Reduction { get; set; }
        public enum DiscountType { FreeShipping, BuyOneGetOneFree, SeasonalDiscount }
        public DateTime StartDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
    public class SpecificPriceActions : CustomPersistentObjectActionsReference<EcommerceWebAppContext, SpecificPrice>
    {
        public SpecificPriceActions(EcommerceWebAppContext context) : base(context) { }
    }
}
