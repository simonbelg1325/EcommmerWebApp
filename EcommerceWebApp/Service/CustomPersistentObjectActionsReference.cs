using System;
using Vidyano.Service;
using Vidyano.Service.Repository;

namespace EcommerceWebApp.Service
{
    public class CustomPersistentObjectActionsReference<TContext, TEntity> : PersistentObjectActionsReference<TContext, TEntity>
    where TContext : ITargetContext
    where TEntity : class
    {
        private static readonly string CREATED_BY = "CreatedBy";
        private static readonly string CREATED_ON = "CreatedOn";
        private static readonly string CHANGED_BY = "ChangedBy";
        private static readonly string CHANGED_ON = "ChangedOn";

        public CustomPersistentObjectActionsReference(TContext context) : base(context)
        {

        }

        public override void OnSave(PersistentObject obj)
        {
            if (obj.IsNew)
            {
                if (obj.TryGetAttribute(CREATED_BY, out var createdByProperty))
                {
                    createdByProperty.SetValue(Manager.Current.UserName);
                }
                if (obj.TryGetAttribute(CREATED_ON, out var createdOnProperty))
                {
                    createdOnProperty.SetValue(DateTime.Now);
                }
            }
            else
            {
                if (obj.TryGetAttribute(CHANGED_BY, out var changedByProperty))
                {
                    changedByProperty.SetValue(Manager.Current.UserName);
                }
                if (obj.TryGetAttribute(CHANGED_ON, out var changedOnProperty))
                {
                    changedOnProperty.SetValue(DateTime.Now);
                }
            }
            base.OnSave(obj);
        }

        public override void OnConstruct(PersistentObject obj)
        {

            if (obj.TryGetAttribute(CREATED_ON, out var createdOnProperty))
            {
                createdOnProperty.Visibility = AttributeVisibility.Never;
            }

            if (obj.TryGetAttribute(CREATED_BY, out var createdByProperty))
            {
                createdByProperty.Visibility = AttributeVisibility.Never;
            }

            if (obj.TryGetAttribute(CHANGED_BY, out var changedByProperty))
            {
                changedByProperty.Visibility = AttributeVisibility.Never;
            }

            if (obj.TryGetAttribute(CHANGED_ON, out var changedOnProperty))
            {
                changedOnProperty.Visibility = AttributeVisibility.Never;
            }
            base.OnConstruct(obj);
        }

        public override void OnConstruct(Query query, PersistentObject? parent)
        {

            if (query.PersistentObject.TryGetAttribute(CREATED_ON, out var createdOnProperty))
            {
                createdOnProperty.Visibility = AttributeVisibility.Never;
            }

            if (query.PersistentObject.TryGetAttribute(CREATED_BY, out var createdByProperty))
            {
                createdByProperty.Visibility = AttributeVisibility.Never;
            }

            if (query.PersistentObject.TryGetAttribute(CHANGED_BY, out var changedByProperty))
            {
                changedByProperty.Visibility = AttributeVisibility.Never;
            }

            if (query.PersistentObject.TryGetAttribute(CHANGED_ON, out var changedOnProperty))
            {
                changedOnProperty.Visibility = AttributeVisibility.Never;
            }

            base.OnConstruct(query, parent);
        }
    }
}
