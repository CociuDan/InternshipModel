using GeekStore.Infrastucture.Extensions;
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
        SignInStatus Create(UserDTO user);
        SignInStatus SignIn(string userName, string password, bool rememberMe, bool shouldLockout);
        UserDTO GetById(int userId);
        void SignOut();
        UserDTO GetByName(string userName);
        int GetAllCount();
        IEnumerable<UserDTO> GetAllPaged(PagedRequestDescription pageDescription);
        void Update(UserDTO user);
        void Delete(int userId);
    }
}
