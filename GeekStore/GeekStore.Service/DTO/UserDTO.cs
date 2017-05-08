using System;

namespace GeekStore.Service.DTO
{
    public class UserDTO
    {
        public virtual string FullName { get; set; }
        public virtual bool IsActive { get; set; }
        public virtual bool IsAdmin { get; set; }
        public virtual string Email { get; set; }
        public virtual string Password { get; set; }
    }
}