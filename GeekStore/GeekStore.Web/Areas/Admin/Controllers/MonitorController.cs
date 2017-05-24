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
    [AdminRoleRequired]
    public class MonitorController : Controller
    {
        private readonly IGenericService<MonitorDTO> _genericService;
        private readonly IMapper _mapper;

        public MonitorController(IGenericService<MonitorDTO> genericService, IMapper mapper)
        {
            _genericService = genericService;
            _mapper = mapper;
        }

        public ActionResult Index()
        {
            IEnumerable<MonitorViewModel> monitors = null;
            return View(monitors);
        }

        [HttpPost]
        public JsonResult GetAll(PagedRequestDescription pageDescription)
        {
            int count = _genericService.GetAllCount();
            var monitors = _mapper.Map<IEnumerable<MonitorDTO>, IEnumerable<MonitorViewModel>>(_genericService.GetAllPaged(pageDescription));
            return Json(new { Result = "OK", Records = monitors, TotalRecordCount = count });
        }

        [HttpPost]
        public JsonResult Edit(MonitorViewModel monitorModel)
        {
            try
            {
                _genericService.Update(_mapper.Map<MonitorViewModel, MonitorDTO>(monitorModel));
                return Json(new { Result = "OK", Record = monitorModel });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }

        [HttpPost]
        public JsonResult Create(MonitorViewModel monitorModel)
        {
            try
            {
                var id = _genericService.Save(_mapper.Map<MonitorViewModel, MonitorDTO>(monitorModel));
                monitorModel.ID = id;
                return Json(new { Result = "OK", Record = monitorModel });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }

        [HttpPost]
        public JsonResult Delete(MonitorViewModel monitorModel)
        {
            try
            {
                _genericService.Delete(monitorModel.ID);
                return Json(new { Result = "OK" });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }
    }
}