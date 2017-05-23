using AutoMapper;
using GeekStore.Service.DTO;
using GeekStore.Service.Interfaces;
using GeekStore.UI.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace GeekStore.UI.Areas.Admin.Controllers
{
    public class GPUController : Controller
    {
        private readonly IGenericService<GPUDTO> _genericService;
        private readonly IMapper _mapper;

        public GPUController(IGenericService<GPUDTO> genericService, IMapper mapper)
        {
            _genericService = genericService;
            _mapper = mapper;
        }

        public ActionResult Index()
        {
            IEnumerable<GPUViewModel> cpus = null;
            return View(cpus);
        }

        [HttpPost]
        public JsonResult GetAll()
        {
            var cpus = _mapper.Map<IEnumerable<GPUDTO>, IEnumerable<GPUViewModel>>(_genericService.GetAll());
            return Json(new { Result = "OK", Records = cpus });
        }

        [HttpPost]
        public JsonResult Edit(GPUViewModel gpuModel)
        {
            try
            {
                _genericService.Update(_mapper.Map<GPUViewModel, GPUDTO>(gpuModel));
                return Json(new { Result = "OK", Record = gpuModel });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }

        [HttpPost]
        public JsonResult Create(GPUViewModel gpuModel)
        {
            try
            {
                var id = _genericService.Save(_mapper.Map<GPUViewModel, GPUDTO>(gpuModel));
                gpuModel.ID = id;
                return Json(new { Result = "OK", Record = gpuModel });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }

        [HttpPost]
        public JsonResult Delete(GPUViewModel cpuModel)
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