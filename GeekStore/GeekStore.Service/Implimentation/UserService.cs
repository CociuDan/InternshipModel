using System;
using System.Threading.Tasks;
using AutoMapper;
using GeekStore.Domain.Model;
using GeekStore.Repository.Interfaces;
using GeekStore.Service.DTO;
using GeekStore.Service.Interfaces;
using GeekStore.Service.Managers;
using NHibernate;

namespace GeekStore.Service.Implimentation
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepository;
        private IMapper _mapper;
        private ITransaction _transaction;
        public UserService(IUserRepository userRepository, IMapper mapper, ITransaction transaction, ApplicationUserManager userManager)
        {
            _mapper = mapper;
            _userRepository = userRepository;
            _transaction = transaction;
        }

        public async Task CreateAsync(UserDTO user)
        {
            await _userRepository.CreateAsync(_mapper.Map<UserDTO, User>(user));
        }

        public Task UpdateAsync(UserDTO user)
        {
            return _userRepository.UpdateAsync(_mapper.Map<UserDTO, User>(user));
        }

        public Task DeleteAsync(UserDTO user)
        {
            Task task = _userRepository.DeleteAsync(_mapper.Map<UserDTO, User>(user));
            _transaction.Commit();
            return task;
        }

        public Task<UserDTO> FindByIdAsync(int userId)
        {
            return _mapper.Map<Task<User>, Task<UserDTO>>(_userRepository.FindByIdAsync(userId));
        }

        public Task<UserDTO> FindByNameAsync(string userName)
        {
            return _mapper.Map<Task<User>, Task<UserDTO>>(_userRepository.FindByNameAsync(userName));
        }

        public void Dispose()
        {
            _userRepository.Dispose();
        }

        public Task SetPasswordHashAsync(UserDTO user, string passwordHash)
        {
            return _userRepository.SetPasswordHashAsync(_mapper.Map<UserDTO, User>(user), passwordHash);
        }

        public Task<string> GetPasswordHashAsync(UserDTO user)
        {
            return _userRepository.GetPasswordHashAsync(_mapper.Map<UserDTO, User>(user));
        }

        public Task<bool> HasPasswordAsync(UserDTO user)
        {
            return _userRepository.HasPasswordAsync(_mapper.Map<UserDTO, User>(user));
        }

        public Task<DateTimeOffset> GetLockoutEndDateAsync(UserDTO user)
        {
            return _userRepository.GetLockoutEndDateAsync(_mapper.Map<UserDTO, User>(user));
        }

        public Task SetLockoutEndDateAsync(UserDTO user, DateTimeOffset lockoutEnd)
        {
            return _userRepository.SetLockoutEndDateAsync(_mapper.Map<UserDTO, User>(user), lockoutEnd);
        }

        public Task<int> IncrementAccessFailedCountAsync(UserDTO user)
        {
            return _userRepository.IncrementAccessFailedCountAsync(_mapper.Map<UserDTO, User>(user));
        }

        public Task ResetAccessFailedCountAsync(UserDTO user)
        {
            return _userRepository.ResetAccessFailedCountAsync(_mapper.Map<UserDTO, User>(user));
        }

        public Task<int> GetAccessFailedCountAsync(UserDTO user)
        {
            return _userRepository.GetAccessFailedCountAsync(_mapper.Map<UserDTO, User>(user));
        }

        public Task<bool> GetLockoutEnabledAsync(UserDTO user)
        {
            return _userRepository.GetLockoutEnabledAsync(_mapper.Map<UserDTO, User>(user));
        }

        public Task SetLockoutEnabledAsync(UserDTO user, bool enabled)
        {
            return _userRepository.SetLockoutEnabledAsync(_mapper.Map<UserDTO, User>(user), enabled);
        }

        public Task SetTwoFactorEnabledAsync(UserDTO user, bool enabled)
        {
            return _userRepository.SetTwoFactorEnabledAsync(_mapper.Map<UserDTO, User>(user), enabled);
        }

        public Task<bool> GetTwoFactorEnabledAsync(UserDTO user)
        {
            return _userRepository.GetTwoFactorEnabledAsync(_mapper.Map<UserDTO, User>(user));
        }
    }
}
