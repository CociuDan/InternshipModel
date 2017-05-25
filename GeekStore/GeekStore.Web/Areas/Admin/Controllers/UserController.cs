using AutoMapper;
using GeekStore.Infrastucture.Extensions;
using GeekStore.Service.DTO;
using GeekStore.Service.Interfaces;
using GeekStore.UI.Models.Common;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace GeekStore.UI.Areas.Admin.Controllers
{
    public class UserController : BaseController
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UserController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        public ActionResult Index()
        {
            IEnumerable<UserViewModel> users = null;
            return View(users);
        }

        [HttpPost]
        public JsonResult GetAll(PagedRequestDescription pageDescription)
        {
            int count = _userService.GetAllCount();
            var users = _mapper.Map<IEnumerable<UserDTO>, IEnumerable<UserViewModel>>(_userService.GetAllPaged(pageDescription));
            return Json(new { Result = "OK", Records = users, TotalRecordCount = count });
        }

        [HttpPost]
        public JsonResult Edit(UserViewModel userModel)
        {
            try
            {
                _userService.Update(_mapper.Map<UserViewModel, UserDTO>(userModel));
                return Json(new { Result = "OK", Record = userModel });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }

        //[HttpPost]
        //public JsonResult Create(UserViewModel caseModel)
        //{
        //    try
        //    {
        //        var id = _userService.Create(_mapper.Map<UserViewModel, UserDTO>(caseModel));
        //        var user = _userService.GetById(id);
        //        return Json(new { Result = "OK", Record = caseModel });
        //    }
        //    catch (Exception ex)
        //    {
        //        return Json(new { Result = "ERROR", Message = ex.Message });
        //    }
        //}

        [HttpPost]
        public JsonResult Delete(UserViewModel userModel)
        {
            try
            {
                _userService.Delete(userModel.Id);
                return Json(new { Result = "OK" });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }
    }
}