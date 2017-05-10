using GeekStore.Service.DTO;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekStore.Service.Interfaces
{
    public interface IUserService : IUserStore<UserDTO, int>, IUserPasswordStore<UserDTO, int>, IUserLockoutStore<UserDTO, int>, IUserTwoFactorStore<UserDTO, int> { }
}
