using GeekStore.Domain.Model;
using GeekStore.Repository.Interfaces;
using NHibernate;
using System;
using System.Threading.Tasks;

namespace GeekStore.Repository.Implimentation
{
    public class UserRepository : IUserRepository
    {
        private ISession _session;
        //private ITransaction _transaction;

        public UserRepository(ISession session)
        {
            _session = session;
        }

        public Task CreateAsync(User user)
        {
            return Task.Run(() => _session.SaveOrUpdate(user));
        }

        public Task DeleteAsync(User user)
        {
            return Task.Run(() => _session.Delete(user));
        }

        public void Dispose()
        {
            //
        }

        public Task<User> FindByIdAsync(int userId)
        {
            return Task.Run(() => _session.Get<User>(userId));
        }

        public Task<User> FindByNameAsync(string email)
        {
            return Task.Run(() =>
            {
                return _session.QueryOver<User>()
                    .Where(u => u.UserName == email)
                    .SingleOrDefault();

            });
        }

        public Task<int> GetAccessFailedCountAsync(User user)
        {
            return Task.FromResult(0);
        }

        public Task<bool> GetLockoutEnabledAsync(User user)
        {
            return Task.FromResult(false);
        }

        public Task<DateTimeOffset> GetLockoutEndDateAsync(User user)
        {
            return Task.FromResult(DateTimeOffset.MaxValue);
        }

        public Task<string> GetPasswordHashAsync(User user)
        {
            return Task.FromResult(user.Password);
        }

        public Task<bool> GetTwoFactorEnabledAsync(User user)
        {
            return Task.FromResult(false);
        }

        public Task<bool> HasPasswordAsync(User user)
        {
            return Task.FromResult(true);
        }

        public Task<int> IncrementAccessFailedCountAsync(User user)
        {
            return Task.FromResult(0);
        }

        public Task ResetAccessFailedCountAsync(User user)
        {
            throw new NotImplementedException();
        }

        public Task SetLockoutEnabledAsync(User user, bool enabled)
        {
            throw new NotImplementedException();
        }

        public Task SetLockoutEndDateAsync(User user, DateTimeOffset lockoutEnd)
        {
            throw new NotImplementedException();
        }

        public Task SetPasswordHashAsync(User user, string passwordHash)
        {
            return Task.Run(() => user.Password = passwordHash);
        }

        public Task SetTwoFactorEnabledAsync(User user, bool enabled)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(User user)
        {
            return Task.Run(() => _session.SaveOrUpdate(user));
        }
    }
}