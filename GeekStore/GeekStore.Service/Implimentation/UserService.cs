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
using Microsoft.AspNet.Identity;
using GeekStore.Infrastucture.Extensions;
using System.Collections.Generic;

namespace GeekStore.Service.Implimentation
{
    public class UserService : IUserService
    {
        private IMapper _mapper;
        private ITransaction _transaction;
        private ApplicationUserManager _userManager;
        private ApplicationSignInManager _signInManager;
        private IUserRepository _userRepository;

        public UserService(IUserRepository userRepository, IMapper mapper, ITransaction transaction, ApplicationUserManager userManager, ApplicationSignInManager signInManager)
       {
            _userRepository = userRepository;
            _mapper = mapper;
            _transaction = transaction;
            _userManager = userManager;
            _signInManager = signInManager;            
        }

        public SignInStatus Create(UserDTO user)
        {
            _userManager.Create(_mapper.Map<UserDTO, User>(user), user.Password);
            _transaction.Commit();
            return _signInManager.PasswordSignIn(user.UserName, user.Password, true, false);
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

        public void UpdateAsync(UserDTO user)
        {
            _userManager.Update(_mapper.Map<UserDTO, User>(user));
        }

        public void DeleteAsync(UserDTO user)
        {
            Task task = _userManager.DeleteAsync(_mapper.Map<UserDTO, User>(user));
            _transaction.Commit();
        }

        public UserDTO FindByIdAsync(int userId)
        {
            return _mapper.Map<User, UserDTO>(_userManager.FindById(userId));
        }

        public UserDTO FindByName(string userName)
        {
            return _mapper.Map<User, UserDTO>(_userManager.FindByName(userName));
        }

        public void Dispose()
        {
            _userManager.Dispose();
        }

        public SignInStatus SignIn(string userName, string password, bool rememberMe, bool shouldLockout)
        {
            return _signInManager.PasswordSignIn(userName, password, rememberMe, shouldLockout);
        }

        public UserDTO GetById(int userId)
        {
            return _mapper.Map<User, UserDTO>(_userManager.FindById(userId));
        }

        public void SignOut()
        {
            _signInManager.SignOut();
        }

        public UserDTO GetByName(string userName)
        {
            return _mapper.Map<User, UserDTO>(_userManager.FindByName(userName));
        }

        public int GetAllCount()
        {
            return _userRepository.GetAllCount();
        }

        public IEnumerable<UserDTO> GetAllPaged(PagedRequestDescription pagedDescription)
        {
            return _mapper.Map<IEnumerable<User>, IEnumerable<UserDTO>>(_userRepository.GetAllPaged(pagedDescription));
        }

        public void Update(UserDTO user)
        {
            _userManager.Update(_mapper.Map<UserDTO, User>(user));
        }

        public void Delete(int userId)
        {
            var user = _userManager.FindById(userId);
            _userManager.Delete(user);
        }
    }
}
