using System;
using System.Collections.Generic;

namespace GeekStore.Domain.Model
{
    public class User : Entity
    {
        public User() { }
        public virtual DateTime DateCreated { get; protected set; }
        public virtual DateTime? DateDeactivated { get; protected set; }
        public virtual bool IsActive { get; protected set; }
        public virtual bool IsAdmin { get; protected set; }
        public virtual DateTime? LastLoginDate { get; protected set; }
        public virtual string Login { get; protected set; }
        public virtual IList<Order> Orders { get; protected set; }
    }
}