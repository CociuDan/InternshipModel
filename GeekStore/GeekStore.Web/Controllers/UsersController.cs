using AutoMapper;
using GeekStore.Service.DTO;
using GeekStore.Service.Interfaces;
using GeekStore.UI.Managers;
using GeekStore.UI.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System.Net;
using System.Threading.Tasks;
using System.Web;
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

        //public ApplicationSingInManager SignInManager

        //{

        //    get { return HttpContext.GetOwinContext().Get<ApplicationSingInManager>(); }

        //}

        //public ApplicationUserManager UserManager

        //{

        //    get { return HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>(); }

        //}

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
                _userService.Create(user);
                var result = _userService.SignIn(model.UserName, model.Password, true, shouldLockout: true);
                switch (result)
                {
                    case SignInStatus.Success:
                        return RedirectToAction("Index", "Home");
                    case SignInStatus.Failure:
                        return RedirectToAction("Login", "Users");
                    default:
                        return RedirectToAction("Login", "Users");
                }
                //if(createResult.Exception)
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