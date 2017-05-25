using AutoMapper;
using GeekStore.Infrastucture.Extensions;
using GeekStore.Service.DTO;
using GeekStore.Service.Interfaces;
using GeekStore.UI.Extensions;
using GeekStore.UI.Models.Common;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace GeekStore.UI.Areas.Admin.Controllers
{
    [AdminRoleRequired]
    public class CPUController : Controller
    {
        private readonly IGenericService<CPUDTO> _genericService;
        private readonly IMapper _mapper;

        public CPUController(IGenericService<CPUDTO> genericService, IMapper mapper)
        {
            _genericService = genericService;
            _mapper = mapper;
        }

        public ActionResult Index()
        {
            IEnumerable<CPUViewModel> cpus = null;
            return View(cpus);
        }

        [HttpPost]
        public JsonResult GetAll(PagedRequestDescription pageDescription)
        {
            int count = _genericService.GetAllCount();
            var cpus = _mapper.Map<IEnumerable<CPUDTO>, IEnumerable<CPUViewModel>>(_genericService.GetAllPaged(pageDescription));
            return Json(new { Result = "OK", Records = cpus, TotalRecordCount = count });
        }

        [HttpPost]
        public JsonResult Edit(CPUViewModel cpuModel)
        {
            try
            {
                _genericService.Update(_mapper.Map<CPUViewModel, CPUDTO>(cpuModel));
                return Json(new { Result = "OK", Record = cpuModel });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }

        [HttpPost]
        public JsonResult Create(CPUViewModel cpuModel)
        {
            try
            {
                var id = _genericService.Save(_mapper.Map<CPUViewModel, CPUDTO>(cpuModel));
                cpuModel.ID = id;
                return Json(new { Result = "OK", Record = cpuModel });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }

        [HttpPost]
        public JsonResult Delete(CPUViewModel cpuModel)
        {
            try
            {
                _genericService.Delete(cpuModel.ID);
                return Json(new { Result = "OK" });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }
    }
}