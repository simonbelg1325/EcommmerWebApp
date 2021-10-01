using Adoptiepunt.Service;

namespace EcommerceWebApp.Service.Actions
{
    public class Company : EntityBase
    {

    }
    public class CompanyActions : CustomPersistentObjectActionsReference<EcommerceWebAppContext, Company>
    {
        public CompanyActions(EcommerceWebAppContext context) : base(context) { }
    }
}
