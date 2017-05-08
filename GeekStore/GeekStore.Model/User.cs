﻿using System;

namespace GeekStore.Domain.Model
{
    public class User : Entity
    {
        public User() { }
        public virtual string FullName { get; set; }
        public virtual bool IsActive { get; set; }
        public virtual bool IsAdmin { get; set; }
        public virtual string Email { get; set; }
        public virtual string Password { get; set; }
    }
}