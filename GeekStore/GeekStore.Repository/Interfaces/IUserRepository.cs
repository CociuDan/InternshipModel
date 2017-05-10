using GeekStore.Domain.Model;
using Microsoft.AspNet.Identity;

namespace GeekStore.Repository.Interfaces
{
    public interface IUserRepository : IUserStore<User, int>, IUserPasswordStore<User, int>, IUserLockoutStore<User, int>, IUserTwoFactorStore<User, int> { }
}