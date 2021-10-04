using System.Collections.Generic;

namespace EcommerceWebApp.Service.Actions
{
    public class Tax : EntityBase
    {
        public string Name { get; set; }
        public decimal Value { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
    public class TaxActions : CustomPersistentObjectActionsReference<EcommerceWebAppContext, Tax>
    {
        public TaxActions(EcommerceWebAppContext context) : base(context) { }
    }
}
