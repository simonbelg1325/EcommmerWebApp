using System;
using System.Collections.Generic;

namespace EcommerceWebApp.Service.Actions
{
    public class CartRule : EntityBase
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public bool Priority { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool Status { get; set; }
        public bool Highlight { get; set; }
        public int MinimumAmount { get; set; }
        public bool FreeDelivery { get; set; }
        public int TotalAvailable { get; set; }
        public int TotalAvailableEachUser { get; set; }
        public string PromoLabel { get; set; }
        public string PromoText { get; set; }
        public int MultiplyGift { get; set; }
        public int MinNrProducts { get; set; }
        public enum DiscountType { FreeShipping, BuyOneGetOneFree, SeasonalDiscount }
        public decimal ReductionAmount { get; set; }
        public int MainCartRuleId { get; set; }
        public virtual Currency MainCartRule { get; set; }
        public int SecondaryCartRuleId { get; set; }
        public virtual Currency SecondaryCartRule { get; set; }
        public virtual ICollection<CartRuleUser> CartRuleUsers { get; set; }
        public virtual ICollection<CartRuleCombination> CartRuleCombinations1 { get; set; }
        public virtual ICollection<CartRuleCombination> CartRuleCombinations2 { get; set; }


    }
    public class CartRuleAction : CustomPersistentObjectActionsReference<EcommerceWebAppContext, CartRule>
    {
        public CartRuleAction(EcommerceWebAppContext context) : base(context) { }
    }
}
