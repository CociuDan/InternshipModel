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
    public class LaptopController : Controller
    {
        private readonly IGenericService<LaptopDTO> _genericService;
        private readonly IMapper _mapper;

        public LaptopController(IGenericService<LaptopDTO> genericService, IMapper mapper)
        {
            _genericService = genericService;
            _mapper = mapper;
        }

        public ActionResult Index()
        {
            IEnumerable<LaptopViewModel> laptops = null;
            return View(laptops);
        }

        [HttpPost]
        public JsonResult GetAll(PagedRequestDescription pageDescription)
        {
            int count = _genericService.GetAllCount();
            var laptops = _mapper.Map<IEnumerable<LaptopDTO>, IEnumerable<LaptopViewModel>>(_genericService.GetAllPaged(pageDescription));
            return Json(new { Result = "OK", Records = laptops, TotalRecordCount = count });
        }

        [HttpPost]
        public JsonResult Edit(LaptopViewModel laptopModel)
        {
            try
            {
                _genericService.Update(_mapper.Map<LaptopViewModel, LaptopDTO>(laptopModel));
                return Json(new { Result = "OK", Record = laptopModel });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }

        [HttpPost]
        public JsonResult Create(LaptopViewModel laptopModel)
        {
            try
            {
                var id = _genericService.Save(_mapper.Map<LaptopViewModel, LaptopDTO>(laptopModel));
                laptopModel.ID = id;
                return Json(new { Result = "OK", Record = laptopModel });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }

        [HttpPost]
        public JsonResult Delete(LaptopViewModel laptopModel)
        {
            try
            {
                _genericService.Delete(laptopModel.ID);
                return Json(new { Result = "OK" });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }
    }
}