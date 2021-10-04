namespace EcommerceWebApp.Service.Actions
{
    public class RoleUser : EntityBase
    {
        public int RoleId { get; set; }
        public virtual Role Role { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
    public class RoleUserActions : CustomPersistentObjectActionsReference<EcommerceWebAppContext, RoleUser>
    {
        public RoleUserActions(EcommerceWebAppContext context) : base(context) { }
    }
}
