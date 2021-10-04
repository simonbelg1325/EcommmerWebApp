namespace EcommerceWebApp.Service.Actions
{
    public class AttributeValue : EntityBase
    {
        public int AttributeId { get; set; }
        public virtual Attribute Attribute { get; set; }
    }
    public class AttributeValueActions : CustomPersistentObjectActionsReference<EcommerceWebAppContext, AttributeAttributeSet>
    {
        public AttributeValueActions(EcommerceWebAppContext context) : base(context) { }
    }
}
