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
    public class PowerUnitController : Controller
    {
        private readonly IGenericService<PowerUnitDTO> _genericService;
        private readonly IMapper _mapper;

        public PowerUnitController(IGenericService<PowerUnitDTO> genericService, IMapper mapper)
        {
            _genericService = genericService;
            _mapper = mapper;
        }

        public ActionResult Index()
        {
            IEnumerable<PowerUnitViewModel> powerUnits = null;
            return View(powerUnits);
        }

        [HttpPost]
        public JsonResult GetAll(PagedRequestDescription pageDescription)
        {
            int count = _genericService.GetAllCount();
            var powerUnits = _mapper.Map<IEnumerable<PowerUnitDTO>, IEnumerable<PowerUnitViewModel>>(_genericService.GetAllPaged(pageDescription));
            return Json(new { Result = "OK", Records = powerUnits, TotalRecordCount = count });
        }

        [HttpPost]
        public JsonResult Edit(PowerUnitViewModel powerUnitModel)
        {
            try
            {
                _genericService.Update(_mapper.Map<PowerUnitViewModel, PowerUnitDTO>(powerUnitModel));
                return Json(new { Result = "OK", Record = powerUnitModel });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }

        [HttpPost]
        public JsonResult Create(PowerUnitViewModel powerUnitModel)
        {
            try
            {
                var id = _genericService.Save(_mapper.Map<PowerUnitViewModel, PowerUnitDTO>(powerUnitModel));
                powerUnitModel.ID = id;
                return Json(new { Result = "OK", Record = powerUnitModel });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }

        [HttpPost]
        public JsonResult Delete(PowerUnitViewModel powerUnitModel)
        {
            try
            {
                _genericService.Delete(powerUnitModel.ID);
                return Json(new { Result = "OK" });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }
    }
}