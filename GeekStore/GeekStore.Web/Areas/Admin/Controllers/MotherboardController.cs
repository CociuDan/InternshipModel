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
    public class MotherboardController : Controller
    {
        private readonly IGenericService<MotherboardDTO> _genericService;
        private readonly IMapper _mapper;

        public MotherboardController(IGenericService<MotherboardDTO> genericService, IMapper mapper)
        {
            _genericService = genericService;
            _mapper = mapper;
        }

        public ActionResult Index()
        {
            IEnumerable<MotherboardViewModel> motherboards = null;
            return View(motherboards);
        }

        [HttpPost]
        public JsonResult GetAll(PagedRequestDescription pageDescription)
        {
            int count = _genericService.GetAllCount();
            var motherboards = _mapper.Map<IEnumerable<MotherboardDTO>, IEnumerable<MotherboardViewModel>>(_genericService.GetAllPaged(pageDescription));
            return Json(new { Result = "OK", Records = motherboards, TotalRecordCount = count });
        }

        [HttpPost]
        public JsonResult Edit(MotherboardViewModel motherboardModel)
        {
            try
            {
                _genericService.Update(_mapper.Map<MotherboardViewModel, MotherboardDTO>(motherboardModel));
                return Json(new { Result = "OK", Record = motherboardModel });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }

        [HttpPost]
        public JsonResult Create(MotherboardViewModel motherboardModel)
        {
            try
            {
                var id = _genericService.Save(_mapper.Map<MotherboardViewModel, MotherboardDTO>(motherboardModel));
                motherboardModel.ID = id;
                return Json(new { Result = "OK", Record = motherboardModel });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }

        [HttpPost]
        public JsonResult Delete(MotherboardViewModel motherboardModel)
        {
            try
            {
                _genericService.Delete(motherboardModel.ID);
                return Json(new { Result = "OK" });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }
    }
}