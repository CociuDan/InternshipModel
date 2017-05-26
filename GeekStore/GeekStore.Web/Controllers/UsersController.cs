using AutoMapper;
using GeekStore.Service.DTO;
using GeekStore.Service.Interfaces;
using GeekStore.UI.Models.Common;
using Microsoft.AspNet.Identity.Owin;
using System;
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
            if (ModelState.IsValid)
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
                        model.ErrorMessage = "Something went wrong.Try Again!";
                        return View(model);
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
            try
            {
                var result = _userService.SignIn(model.UserName, model.Password, model.RememberMe, shouldLockout: true);
                switch (result)
                {
                    case SignInStatus.Success:
                        return RedirectToAction("Index", "Home");
                    case SignInStatus.Failure:
                        ModelState.AddModelError("", "Invalid login User Name or Password.");
                        return View(model);
                    default:
                        ModelState.AddModelError("", "Invalid login attempt.");
                        return View(model);
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Invalid login Email or Password.");
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