namespace EcommerceWebApp.Service.Actions
{
    public class AttributeProduct : EntityBase
    {
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int AttributeId { get; set; }
        public virtual Attribute Attribute { get; set; }
        public string Value { get; set; }
    }
    public class AttributeProductActions : CustomPersistentObjectActionsReference<EcommerceWebAppContext, AttributeValue>
    {
        public AttributeProductActions(EcommerceWebAppContext context) : base(context) { }
    }
}
