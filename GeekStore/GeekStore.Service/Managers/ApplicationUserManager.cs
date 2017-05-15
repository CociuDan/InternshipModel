using GeekStore.Domain.Model;
using GeekStore.Repository.Interfaces;
using Microsoft.AspNet.Identity;
using System;

namespace GeekStore.Service.Managers
{
    public class ApplicationUserManager : UserManager<User, int>
    {
        public ApplicationUserManager(IUserRepository userRepository) : base(userRepository)
        {
            UserValidator = new UserValidator<User, int>(this);
            PasswordValidator = new PasswordValidator();
            DefaultAccountLockoutTimeSpan = new TimeSpan(0, 5, 0);
            
        }
    }
}