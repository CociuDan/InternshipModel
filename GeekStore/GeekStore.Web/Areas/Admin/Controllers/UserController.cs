using AutoMapper;
using GeekStore.Infrastucture.Extensions;
using GeekStore.Service.DTO;
using GeekStore.Service.Interfaces;
using GeekStore.UI.Extensions;
using GeekStore.UI.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace GeekStore.UI.Areas.Admin.Controllers
{
    public class UserController : Controller
    {
        //private readonly IUserService _userService;
        //private readonly IMapper _mapper;

        //public UserController(IUserService userService, IMapper mapper)
        //{
        //    _userService = userService;
        //    _mapper = mapper;
        //}

        //public ActionResult Index()
        //{
        //    IEnumerable<UserViewModel> cases = null;
        //    return View(cases);
        //}

        //[HttpPost]
        //public JsonResult GetAll(PagedRequestDescription pageDescription)
        //{
        //    int count = _userService.GetAllCount();
        //    var cases = _mapper.Map<IEnumerable<UserDTO>, IEnumerable<UserViewModel>>(_userService.GetAllPaged(pageDescription));
        //    return Json(new { Result = "OK", Records = cases, TotalRecordCount = count });
        //}

        //[HttpPost]
        //public JsonResult Edit(UserViewModel caseModel)
        //{
        //    try
        //    {
        //        _userService.Update(_mapper.Map<UserViewModel, UserDTO>(caseModel));
        //        return Json(new { Result = "OK", Record = caseModel });
        //    }
        //    catch (Exception ex)
        //    {
        //        return Json(new { Result = "ERROR", Message = ex.Message });
        //    }
        //}

        //[HttpPost]
        //public JsonResult Create(UserViewModel caseModel)
        //{
        //    try
        //    {
        //        var id = _userService.Save(_mapper.Map<UserViewModel, UserDTO>(caseModel));
        //        caseModel.ID = id;
        //        return Json(new { Result = "OK", Record = caseModel });
        //    }
        //    catch (Exception ex)
        //    {
        //        return Json(new { Result = "ERROR", Message = ex.Message });
        //    }
        //}

        //[HttpPost]
        //public JsonResult Delete(UserViewModel caseModel)
        //{
        //    try
        //    {
        //        _userService.Delete(caseModel.ID);
        //        return Json(new { Result = "OK" });
        //    }
        //    catch (Exception ex)
        //    {
        //        return Json(new { Result = "ERROR", Message = ex.Message });
        //    }
        //}
    }
}