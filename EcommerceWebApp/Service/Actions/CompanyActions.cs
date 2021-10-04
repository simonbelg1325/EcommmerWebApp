namespace EcommerceWebApp.Service.Actions
{
    public class Company : EntityBase
    {
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string County { get; set; }
        public string City { get; set; }
        public string Tin { get; set; }
        public string Trn { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
    public class CompanyActions : CustomPersistentObjectActionsReference<EcommerceWebAppContext, Company>
    {
        public CompanyActions(EcommerceWebAppContext context) : base(context) { }
    }
}
