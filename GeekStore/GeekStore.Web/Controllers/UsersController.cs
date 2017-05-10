using AutoMapper;
using GeekStore.Service.DTO;
using GeekStore.Service.Interfaces;
using GeekStore.UI.Managers;
using GeekStore.UI.Models;
using Microsoft.AspNet.Identity.Owin;
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

        public ApplicationSingInManager SignInManager

        {

            get { return HttpContext.GetOwinContext().Get<ApplicationSingInManager>(); }

        }

        public ApplicationUserManager UserManager

        {

            get { return HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>(); }

        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Register(RegisterViewModel model)
        {
            if(ModelState.IsValid)
            {
                var user = new UserDTO();
                user.UserName = model.UserName;
                user.FullName = model.FullName;
                user.Password = model.Password;
                user.IsAdmin = true;
                var createResult = _userService.CreateAsync(user);
                if(createResult.Exception)
                {

                }
                var createResult = UserManager.CreateAsync(user);
                if(createResult.Status == TaskStatus.Created)
                {
                    var signInResult = SignInManager.SignInAsync(user, true, true);
                    if (signInResult.Status == TaskStatus.Created)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ModelState.AddModelError("", "The user name or password provided is incorrect.");
                    }
                    return RedirectToAction("Index", "Home");                    
                }                
            }
            return View(model);
        }
    }
}