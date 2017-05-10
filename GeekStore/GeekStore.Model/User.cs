using Microsoft.AspNet.Identity;

namespace GeekStore.Domain.Model
{
    public class User : IUser<int>
    {
        public User() { }
        public virtual int Id { get; protected set; }
        public virtual string FullName { get; set; }
        public virtual bool IsAdmin { get; set; }
        public virtual string UserName { get; set; }
        public virtual string Password { get; set; }
    }
}