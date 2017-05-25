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
    public class CoolerController : BaseController
    {
        private readonly IGenericService<CoolerDTO> _genericService;
        private readonly IMapper _mapper;

        public CoolerController(IGenericService<CoolerDTO> genericService, IMapper mapper)
        {
            _genericService = genericService;
            _mapper = mapper;
        }

        public ActionResult Index()
        {
            IEnumerable<CoolerViewModel> coolers = null;
            return View(coolers);
        }

        [HttpPost]
        public JsonResult GetAll(PagedRequestDescription pageDescription)
        {
            int count = _genericService.GetAllCount();
            var coolers = _mapper.Map<IEnumerable<CoolerDTO>, IEnumerable<CoolerViewModel>>(_genericService.GetAllPaged(pageDescription));
            return Json(new { Result = "OK", Records = coolers, TotalRecordCount = count });
        }

        [HttpPost]
        public JsonResult Edit(CoolerViewModel coolerModel)
        {
            try
            {
                _genericService.Update(_mapper.Map<CoolerViewModel, CoolerDTO>(coolerModel));
                return Json(new { Result = "OK", Record = coolerModel });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }

        [HttpPost]
        public JsonResult Create(CoolerViewModel coolerModel)
        {
            try
            {
                var id = _genericService.Save(_mapper.Map<CoolerViewModel, CoolerDTO>(coolerModel));
                coolerModel.ID = id;
                return Json(new { Result = "OK", Record = coolerModel });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }

        [HttpPost]
        public JsonResult Delete(CoolerViewModel coolerModel)
        {
            try
            {
                _genericService.Delete(coolerModel.ID);
                return Json(new { Result = "OK" });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }
    }
}