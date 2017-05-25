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
    public class DesktopController : BaseController
    {
        private readonly IGenericService<DesktopDTO> _genericService;
        private readonly IMapper _mapper;

        public DesktopController(IGenericService<DesktopDTO> genericService, IMapper mapper)
        {
            _genericService = genericService;
            _mapper = mapper;
        }

        public ActionResult Index()
        {
            IEnumerable<DesktopViewModel> desktops = null;
            return View(desktops);
        }

        [HttpPost]
        public JsonResult GetAll(PagedRequestDescription pageDescription)
        {
            int count = _genericService.GetAllCount();
            var desktops = _mapper.Map<IEnumerable<DesktopDTO>, IEnumerable<DesktopViewModel>>(_genericService.GetAllPaged(pageDescription));
            return Json(new { Result = "OK", Records = desktops, TotalRecordCount = count });
        }

        [HttpPost]
        public JsonResult Edit(DesktopViewModel desktopModel)
        {
            try
            {
                _genericService.Update(_mapper.Map<DesktopViewModel, DesktopDTO>(desktopModel));
                return Json(new { Result = "OK", Record = desktopModel });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }

        [HttpPost]
        public JsonResult Create(DesktopViewModel desktopModel)
        {
            try
            {
                var id = _genericService.Save(_mapper.Map<DesktopViewModel, DesktopDTO>(desktopModel));
                desktopModel.ID = id;
                return Json(new { Result = "OK", Record = desktopModel });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }

        [HttpPost]
        public JsonResult Delete(DesktopViewModel desktopModel)
        {
            try
            {
                _genericService.Delete(desktopModel.ID);
                return Json(new { Result = "OK" });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }
    }
}