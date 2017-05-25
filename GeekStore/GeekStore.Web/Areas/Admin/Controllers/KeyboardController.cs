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
    public class KeyboardController : BaseController
    {
        private readonly IGenericService<KeyboardDTO> _genericService;
        private readonly IMapper _mapper;

        public KeyboardController(IGenericService<KeyboardDTO> genericService, IMapper mapper)
        {
            _genericService = genericService;
            _mapper = mapper;
        }

        public ActionResult Index()
        {
            IEnumerable<KeyboardViewModel> keyboards = null;
            return View(keyboards);
        }

        [HttpPost]
        public JsonResult GetAll(PagedRequestDescription pageDescription)
        {
            int count = _genericService.GetAllCount();
            var keyboards = _mapper.Map<IEnumerable<KeyboardDTO>, IEnumerable<KeyboardViewModel>>(_genericService.GetAllPaged(pageDescription));
            return Json(new { Result = "OK", Records = keyboards, TotalRecordCount = count });
        }

        [HttpPost]
        public JsonResult Edit(KeyboardViewModel keyboardModel)
        {
            try
            {
                _genericService.Update(_mapper.Map<KeyboardViewModel, KeyboardDTO>(keyboardModel));
                return Json(new { Result = "OK", Record = keyboardModel });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }

        [HttpPost]
        public JsonResult Create(KeyboardViewModel keyboardModel)
        {
            try
            {
                var id = _genericService.Save(_mapper.Map<KeyboardViewModel, KeyboardDTO>(keyboardModel));
                keyboardModel.ID = id;
                return Json(new { Result = "OK", Record = keyboardModel });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }

        [HttpPost]
        public JsonResult Delete(KeyboardViewModel keyboardModel)
        {
            try
            {
                _genericService.Delete(keyboardModel.ID);
                return Json(new { Result = "OK" });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }
    }
}