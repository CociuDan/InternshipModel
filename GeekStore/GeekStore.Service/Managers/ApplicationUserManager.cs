using GeekStore.Service.DTO;
using Microsoft.AspNet.Identity;

namespace GeekStore.Service.Managers
{
    public class ApplicationUserManager : UserManager<UserDTO, int>
    {
        public ApplicationUserManager(IUserStore<UserDTO, int> store) : base(store)
        {
            UserValidator = new UserValidator<UserDTO, int>(this);
            PasswordValidator = new PasswordValidator();
        }
    }
}