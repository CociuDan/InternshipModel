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
            IEnumerable<GPUViewModel> gpus = null;
            return View(gpus);
        }

        [HttpPost]
        public JsonResult GetAll(PagedRequestDescription pageDescription)
        {
            int count = _genericService.GetAllCount();
            var gpus = _mapper.Map<IEnumerable<GPUDTO>, IEnumerable<GPUViewModel>>(_genericService.GetAllPaged(pageDescription));
            return Json(new { Result = "OK", Records = gpus, TotalRecordCount = count });
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
        public JsonResult Delete(GPUViewModel gpuModel)
        {
            try
            {
                _genericService.Delete(gpuModel.ID);
                return Json(new { Result = "OK" });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }
    }
}