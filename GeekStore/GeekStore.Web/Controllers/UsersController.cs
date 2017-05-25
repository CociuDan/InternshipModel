using AutoMapper;
using GeekStore.Service.DTO;
using GeekStore.Service.Interfaces;
using GeekStore.UI.Models.Common;
using Microsoft.AspNet.Identity.Owin;
using System.Web.Mvc;

namespace GeekStore.UI.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        public UsersController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        public ActionResult Register()
        {
            return View();
        }



        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Register(UserViewModel model)
        {
            if(ModelState.IsValid)
            {
                var user = new UserDTO();
                user.UserName = model.UserName;
                user.FullName = model.FullName;
                user.Password = model.Password;
                user.IsAdmin = false;
                var result = _userService.Create(user);
                switch (result)
                {
                    case SignInStatus.Success:
                        return RedirectToAction("Index", "Home");
                    case SignInStatus.Failure:
                        return RedirectToAction("Login", "Users");
                    default:
                        return RedirectToAction("Login", "Users");
                }              
            }
            return View(model);
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var result = _userService.SignIn(model.UserName, model.Password, model.RememberMe, shouldLockout: true);
            switch (result)
            {
                case SignInStatus.Success:
                    return RedirectToAction("Index", "Home");
                case SignInStatus.Failure:
                    return View("An error ocurred. Try again");
                default:
                    ModelState.AddModelError("", "Invalid login attempt.");
                    return View(model);
            }
        }

        public ActionResult LogOff()
        {
            _userService.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}