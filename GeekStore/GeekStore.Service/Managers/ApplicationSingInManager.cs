using GeekStore.Service.DTO;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;

namespace GeekStore.Service.Managers
{
    public class AplicationSingInManager : SignInManager<UserDTO, int>
    {
        public AplicationSingInManager(UserManager<UserDTO, int> userManager, IAuthenticationManager authenticationManager) : base(userManager, authenticationManager) { }

        public void SignOut()
        {
            AuthenticationManager.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
        }
    }
}