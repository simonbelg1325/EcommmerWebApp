using EcommerceWebApp.Service.Actions;
using System.Collections.Generic;

namespace EcommerceWebApp.Service
{
    public class Permission : EntityBase
    {
        public string Name { get; set; }
        public virtual ICollection<PermissionRole> PermissionRoles { get; set; }
        public virtual ICollection<PermissionUser> PermissionUsers { get; set; }
    }
    public class PermissionActions : CustomPersistentObjectActionsReference<EcommerceWebAppContext, Permission>
    {
        public PermissionActions(EcommerceWebAppContext context) : base(context) { }
    }
}
