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
    public class MouseController : BaseController
    {
        private readonly IGenericService<MouseDTO> _genericService;
        private readonly IMapper _mapper;

        public MouseController(IGenericService<MouseDTO> genericService, IMapper mapper)
        {
            _genericService = genericService;
            _mapper = mapper;
        }

        public ActionResult Index()
        {
            IEnumerable<MouseViewModel> mouses = null;
            return View(mouses);
        }

        [HttpPost]
        public JsonResult GetAll(PagedRequestDescription pageDescription)
        {
            int count = _genericService.GetAllCount();
            var mouses = _mapper.Map<IEnumerable<MouseDTO>, IEnumerable<MouseViewModel>>(_genericService.GetAllPaged(pageDescription));
            return Json(new { Result = "OK", Records = mouses, TotalRecordCount = count });
        }

        [HttpPost]
        public JsonResult Edit(MouseViewModel mouseModel)
        {
            try
            {
                _genericService.Update(_mapper.Map<MouseViewModel, MouseDTO>(mouseModel));
                return Json(new { Result = "OK", Record = mouseModel });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }

        [HttpPost]
        public JsonResult Create(MouseViewModel mouseModel)
        {
            try
            {
                var id = _genericService.Save(_mapper.Map<MouseViewModel, MouseDTO>(mouseModel));
                mouseModel.ID = id;
                return Json(new { Result = "OK", Record = mouseModel });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }

        [HttpPost]
        public JsonResult Delete(MouseViewModel mouseModel)
        {
            try
            {
                _genericService.Delete(mouseModel.ID);
                return Json(new { Result = "OK" });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }
    }
}