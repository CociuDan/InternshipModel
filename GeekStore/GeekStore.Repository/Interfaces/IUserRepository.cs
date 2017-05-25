using GeekStore.Domain.Model;
using GeekStore.Infrastucture.Extensions;
using Microsoft.AspNet.Identity;
using System.Collections.Generic;

namespace GeekStore.Repository.Interfaces
{
    public interface IUserRepository : IUserStore<User, int>, IUserPasswordStore<User, int>, IUserLockoutStore<User, int>, IUserTwoFactorStore<User, int>
    {
        int GetAllCount();
        IEnumerable<User> GetAllPaged(PagedRequestDescription pagedDescription);
    }
}