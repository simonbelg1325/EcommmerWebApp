using System.Collections.Generic;

namespace EcommerceWebApp.Service.Actions
{
    public class Country : EntityBase
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
    }
    public class CountryActions : CustomPersistentObjectActionsReference<EcommerceWebAppContext, Country>
    {
        public CountryActions(EcommerceWebAppContext context) : base(context) { }
    }
}
