using GeekStore.Service.DTO;
using Microsoft.AspNet.Identity;
using GeekStore.Service.Interfaces;

namespace GeekStore.UI.Managers
{
    public class ApplicationUserManager : UserManager<UserDTO, int>
    {
        public ApplicationUserManager(IUserService store) : base(store)
        {
            UserValidator = new UserValidator<UserDTO, int>(this);
            PasswordValidator = new PasswordValidator();
        }
    }
}