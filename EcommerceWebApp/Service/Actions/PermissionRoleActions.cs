namespace EcommerceWebApp.Service.Actions
{
    public class PermissionRole : EntityBase
    {
        public int PermissionId { get; set; }
        public virtual Permission Permission { get; set; }
        public int RoleId { get; set; }
        public virtual Role Role { get; set; }
    }
    public class PermissionRoleActions : CustomPersistentObjectActionsReference<EcommerceWebAppContext, PermissionRole>
    {
        public PermissionRoleActions(EcommerceWebAppContext context) : base(context) { }
    }
}
