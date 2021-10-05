using System.Collections.Generic;

namespace EcommerceWebApp.Service.Actions
{
    public class Role : EntityBase
    {
        public string Name { get; set; }
        public virtual ICollection<RoleUser> RoleUser { get; set; }
        public virtual ICollection<PermissionRole> PermissionRoles { get; set; }
    }
    public class RoleActions : CustomPersistentObjectActionsReference<EcommerceWebAppContext, Role>
    {
        public RoleActions(EcommerceWebAppContext context) : base(context) { }
    }
}
