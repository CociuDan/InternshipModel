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
    public class RAMController : Controller
    {
        private readonly IGenericService<RAMDTO> _genericService;
        private readonly IMapper _mapper;

        public RAMController(IGenericService<RAMDTO> genericService, IMapper mapper)
        {
            _genericService = genericService;
            _mapper = mapper;
        }

        public ActionResult Index()
        {
            IEnumerable<RAMViewModel> rams = null;
            return View(rams);
        }

        [HttpPost]
        public JsonResult GetAll(PagedRequestDescription pageDescription)
        {
            int count = _genericService.GetAllCount();
            var rams = _mapper.Map<IEnumerable<RAMDTO>, IEnumerable<RAMViewModel>>(_genericService.GetAllPaged(pageDescription));
            return Json(new { Result = "OK", Records = rams, TotalRecordCount = count });
        }

        [HttpPost]
        public JsonResult Edit(RAMViewModel ramModel)
        {
            try
            {
                _genericService.Update(_mapper.Map<RAMViewModel, RAMDTO>(ramModel));
                return Json(new { Result = "OK", Record = ramModel });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }

        [HttpPost]
        public JsonResult Create(RAMViewModel ramModel)
        {
            try
            {
                var id = _genericService.Save(_mapper.Map<RAMViewModel, RAMDTO>(ramModel));
                ramModel.ID = id;
                return Json(new { Result = "OK", Record = ramModel });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }

        [HttpPost]
        public JsonResult Delete(RAMViewModel ramModel)
        {
            try
            {
                _genericService.Delete(ramModel.ID);
                return Json(new { Result = "OK" });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }
    }
}