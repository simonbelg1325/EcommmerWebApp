using System.Collections.Generic;

namespace EcommerceWebApp.Service.Actions
{
    public class Currency : EntityBase
    {
        public string Name { get; set; }
        public string Iso { get; set; }
        public string Value { get; set; }
        public bool Default { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<CartRules> MainCartRuleses { get; set; }
        public virtual ICollection<CartRules> SecondaryCartRuleses { get; set; }
    }
    public class CurrencyActions : CustomPersistentObjectActionsReference<EcommerceWebAppContext, Currency>
    {
        public CompanyActions(EcommerceWebAppContext context) : base(context) { }
    }
}
