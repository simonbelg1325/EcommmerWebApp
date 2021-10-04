namespace EcommerceWebApp.Service.Actions
{
    public class AttributeAttributeSet : EntityBase
    {
        public int AttributeSetId { get; set; }
        public virtual AttributeSet AttributeSet { get; set; }
        public int AttributeId { get; set; }
        public virtual Attribute Attribute { get; set; }
    }
    public class AttributeAttributeSetActions : CustomPersistentObjectActionsReference<EcommerceWebAppContext, AttributeAttributeSet>
    {
        public AttributeAttributeSetActions(EcommerceWebAppContext context) : base(context) { }
    }
}
