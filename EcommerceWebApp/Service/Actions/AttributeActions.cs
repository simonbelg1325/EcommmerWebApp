using System.Collections.Generic;

namespace EcommerceWebApp.Service.Actions
{
    public class Attribute : EntityBase
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public virtual ICollection<AttributeAttributeSet> AttributeAttributeSets { get; set; }
        public virtual ICollection<AttributeValue> AttributeValues { get; set; }
    }
    public class AttributeActions : CustomPersistentObjectActionsReference<EcommerceWebAppContext, Attribute>
    {
        public AttributeActions(EcommerceWebAppContext context) : base(context) { }
    }
}
