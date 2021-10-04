﻿using System;
using System.Collections.Generic;

namespace EcommerceWebApp.Service.Actions
{
    public class User : EntityBase
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Salutation { get; set; }
        public DateTime Birthday { get; set; }
        public string Gender { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<Company> Companies { get; set; }
    }
    public class UserActions : CustomPersistentObjectActionsReference<EcommerceWebAppContext, User>
    {
        public UserActions(EcommerceWebAppContext context) : base(context) { }
    }
}
