using System;
using System.Collections.Generic;

namespace EcommerceWebApp.Service.Actions
{
    public class Order : EntityBase
    {
        public int ShippingAddressId { get; set; }
        public int BillingAddressId { get; set; }
        public int BillingCompanyId { get; set; }
        public string Comment { get; set; }
        public string ShippingNo { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public decimal TotalDiscount { get; set; }
        public decimal TotalDiscountTax { get; set; }
        public decimal TotalShipping { get; set; }
        public decimal TotalShippingTax { get; set; }
        public decimal Total { get; set; }
        public decimal TotalTax { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public int OrderStatusId { get; set; }
        public virtual OrderStatus OrderStatus { get; set; }
        public int CarrierId { get; set; }
        public virtual Carrier Carrier { get; set; }
        public int CurrencyId { get; set; }
        public virtual Currency Currency { get; set; }
        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
        public virtual ICollection<OrderStatusHistory> OrderStatusHistories { get; set; }
    }
    public class OrderActions : CustomPersistentObjectActionsReference<EcommerceWebAppContext, Order>
    {
        public OrderActions(EcommerceWebAppContext context) : base(context) { }
    }
}
