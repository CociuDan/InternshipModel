using Microsoft.AspNet.Identity;

namespace GeekStore.Service.DTO
{
    public class UserDTO : IUser<int>
    {
        public virtual int Id { get; set; }
        public virtual string FullName { get; set; }
        public virtual bool IsAdmin { get; set; }
        public virtual string UserName { get; set; }
        public virtual string Password { get; set; }
    }
}