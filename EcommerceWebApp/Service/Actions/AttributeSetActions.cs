using System.Collections.Generic;

namespace EcommerceWebApp.Service.Actions
{
    public class AttributeSet : EntityBase
    {
        public string Name { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<AttributeAttributeSet> AttributeAttributeSets { get; set; }
    }
    public class AttributeSetActions : CustomPersistentObjectActionsReference<EcommerceWebAppContext, AttributeSet>
    {
        public AttributeSetActions(EcommerceWebAppContext context) : base(context) { }
    }
}
