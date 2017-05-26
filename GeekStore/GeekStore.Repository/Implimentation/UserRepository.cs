using GeekStore.Domain.Model;
using GeekStore.Repository.Interfaces;
using NHibernate;
using System;
using System.Threading.Tasks;
using GeekStore.Infrastucture.Extensions;
using System.Collections.Generic;
using GeekStore.Repository.Extensions;

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

        public int GetAllCount()
        {
            return _session.QueryOver<User>().RowCount();
        }

        public IEnumerable<User> GetAllPaged(PagedRequestDescription pagedDescription)
        {
            return _session.QueryOver<User>().GetPagedResult(pagedDescription);
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
            if (user == null)
            {
                throw new ArgumentNullException("user");
            }
            return Task.FromResult<int>(0);
        }

        public Task SetLockoutEnabledAsync(User user, bool enabled)
        {
            throw new NotImplementedException();
        }

        public Task SetLockoutEndDateAsync(User user, DateTimeOffset lockoutEnd)
        {
            DateTime? nullable;
            if (user == null)
            {
                throw new ArgumentNullException("user");
            }
            if (lockoutEnd == DateTimeOffset.MinValue)
            {
                nullable = null;
            }
            else
            {
                nullable = new DateTime?(lockoutEnd.UtcDateTime);
            }
            return Task.FromResult<int>(0);
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