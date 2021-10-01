using Adoptiepunt.Service;

namespace EcommerceWebApp.Service.Actions
{
    public class Address : EntityBase
    {
        public int CountryId { get; set; }
        public virtual Country Country { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string County { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string MobilePhone { get; set; }
        public string Comment { get; set; }
    }
    public class AddressActions : CustomPersistentObjectActionsReference<EcommerceWebAppContext, Address>
    {
        public AddressActions(EcommerceWebAppContext context) : base(context) { }
    }
}
