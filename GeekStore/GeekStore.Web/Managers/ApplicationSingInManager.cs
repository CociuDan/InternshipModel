using GeekStore.Service.DTO;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;

namespace GeekStore.UI.Managers
{
    public class ApplicationSingInManager : SignInManager<UserDTO, int>
    {
        public ApplicationSingInManager(UserManager<UserDTO, int> userManager, IAuthenticationManager authenticationManager) : base(userManager, authenticationManager) { }

        public void SignOut()
        {
            AuthenticationManager.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
        }
    }
}