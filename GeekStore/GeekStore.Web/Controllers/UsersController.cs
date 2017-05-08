using AutoMapper;
using GeekStore.Service.DTO;
using GeekStore.Service.Interfaces;
using GeekStore.UI.Models;
using System.Threading.Tasks;
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
                var user = new UserViewModel();
                user.Email = model.Email;
                user.FullName = model.FullName;
                user.Password = model.Password;
                user.IsActive = true;
                user.IsAdmin = true;
                user.ConfirmPassword = model.ConfirmPassword;
                _userService.Create(_mapper.Map<UserViewModel, UserDTO>(user));
                //var result = await 
            }
            return View(model);
        }
    }
}