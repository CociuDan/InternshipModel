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
    public class DisplayController : BaseController
    {
        private readonly IGenericService<DisplayDTO> _genericService;
        private readonly IMapper _mapper;

        public DisplayController(IGenericService<DisplayDTO> genericService, IMapper mapper)
        {
            _genericService = genericService;
            _mapper = mapper;
        }

        public ActionResult Index()
        {
            IEnumerable<DisplayViewModel> displays = null;
            return View(displays);
        }

        [HttpPost]
        public JsonResult GetAll(PagedRequestDescription pageDescription)
        {
            int count = _genericService.GetAllCount();
            var displays = _mapper.Map<IEnumerable<DisplayDTO>, IEnumerable<DisplayViewModel>>(_genericService.GetAllPaged(pageDescription));
            return Json(new { Result = "OK", Records = displays, TotalRecordCount = count });
        }

        [HttpPost]
        public JsonResult Edit(DisplayViewModel displayModel)
        {
            try
            {
                _genericService.Update(_mapper.Map<DisplayViewModel, DisplayDTO>(displayModel));
                return Json(new { Result = "OK", Record = displayModel });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }

        [HttpPost]
        public JsonResult Create(DisplayViewModel displayModel)
        {
            try
            {
                var id = _genericService.Save(_mapper.Map<DisplayViewModel, DisplayDTO>(displayModel));
                displayModel.ID = id;
                return Json(new { Result = "OK", Record = displayModel });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }

        [HttpPost]
        public JsonResult Delete(DisplayViewModel displayModel)
        {
            try
            {
                _genericService.Delete(displayModel.ID);
                return Json(new { Result = "OK" });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }
    }
}