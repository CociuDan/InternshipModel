using System;
using System.Threading.Tasks;
using AutoMapper;
using GeekStore.Domain.Model;
using GeekStore.Repository.Interfaces;
using GeekStore.Service.DTO;
using GeekStore.Service.Interfaces;
using GeekStore.Service.Managers;
using Microsoft.AspNet.Identity.Owin;
using NHibernate;

namespace GeekStore.Service.Implimentation
{
    public class UserService : IUserService
    {
        private IMapper _mapper;
        private ITransaction _transaction;
        private ApplicationUserManager _userManager;
        private ApplicationSignInManager _signInManager;

        public UserService(IUserRepository userRepository, IMapper mapper, ITransaction transaction, ApplicationUserManager userManager, ApplicationSignInManager signInManager)
       {
            _mapper = mapper;
            _transaction = transaction;
            _userManager = userManager;
            //_userManager.DefaultAccountLockoutTimeSpan = TimeSpan.FromMinutes(5);
            _signInManager = signInManager;            
        }

        public async Task<SignInStatus> CreateAsync(UserDTO user)
        {
            await _userManager.CreateAsync(_mapper.Map<UserDTO, User>(user), user.Password);
            _transaction.Commit();
            return await _signInManager.PasswordSignInAsync(user.UserName, user.Password, true, false);
            //if (createResult.Exception)
            //{

            //}
            //var createResult = UserManager.CreateAsync(user);
            //if(createResult.Status == TaskStatus.Created)
            //{
            //    var signInResult = SignInManager.SignInAsync(user, true, true);
            //    if (signInResult.Status == TaskStatus.Created)
            //    {
            //        return RedirectToAction("Index", "Home");
            //    }
            //    else
            //    {
            //        ModelState.AddModelError("", "The user name or password provided is incorrect.");
            //    }
            //    return RedirectToAction("Index", "Home");                    
            //}   















        }

        public Task UpdateAsync(UserDTO user)
        {
            return _userManager.UpdateAsync(_mapper.Map<UserDTO, User>(user));
        }

        public Task DeleteAsync(UserDTO user)
        {
            Task task = _userManager.DeleteAsync(_mapper.Map<UserDTO, User>(user));
            _transaction.Commit();
            return task;
        }

        public Task<UserDTO> FindByIdAsync(int userId)
        {
            return _mapper.Map<Task<User>, Task<UserDTO>>(_userManager.FindByIdAsync(userId));
        }

        public Task<UserDTO> FindByNameAsync(string userName)
        {
            return _mapper.Map<Task<User>, Task<UserDTO>>(_userManager.FindByNameAsync(userName));
        }

        public void Dispose()
        {
            _userManager.Dispose();
        }

        public Task<SignInStatus> SignIn(string userName, string password, bool rememberMe, bool shouldLockout)
        {
            return _signInManager.PasswordSignInAsync(userName, password, rememberMe, shouldLockout);
        }
    }
}
