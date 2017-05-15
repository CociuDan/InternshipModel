using GeekStore.Service.DTO;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekStore.Service.Interfaces
{
    public interface IUserService
    {
        Task<SignInStatus> CreateAsync(UserDTO user);
        Task<SignInStatus> SignIn(string userName, string password, bool rememberMe, bool shouldLockout);
    }
}
