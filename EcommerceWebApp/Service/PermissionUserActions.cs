using EcommerceWebApp.Service.Actions;

namespace EcommerceWebApp.Service
{
    public class PermissionUser : EntityBase
    {
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public int PermissionId { get; set; }
        public virtual Permission Permission { get; set; }
    }
    public class PermissionUserActions : CustomPersistentObjectActionsReference<EcommerceWebAppContext, PermissionUser>
    {
        public PermissionUserActions(EcommerceWebAppContext context) : base(context) { }
    }
}
