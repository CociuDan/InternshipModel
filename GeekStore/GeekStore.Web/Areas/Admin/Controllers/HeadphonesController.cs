using AutoMapper;
using GeekStore.Service.DTO;
using GeekStore.Service.Interfaces;
using GeekStore.UI.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace GeekStore.UI.Areas.Admin.Controllers
{
    public class HeadphonesController : Controller
    {
        private readonly IGenericService<HeadphonesDTO> _genericService;
        private readonly IMapper _mapper;

        public HeadphonesController(IGenericService<HeadphonesDTO> genericService, IMapper mapper)
        {
            _genericService = genericService;
            _mapper = mapper;
        }

        public ActionResult Index()
        {
            IEnumerable<HeadphonesViewModel> rams = null;
            return View(rams);
        }

        [HttpPost]
        public JsonResult GetAll()
        {
            var rams = _mapper.Map<IEnumerable<HeadphonesDTO>, IEnumerable<HeadphonesViewModel>>(_genericService.GetAll());
            return Json(new { Result = "OK", Records = rams });
        }

        [HttpPost]
        public JsonResult Edit(HeadphonesViewModel ramModel)
        {
            try
            {
                _genericService.Update(_mapper.Map<HeadphonesViewModel, HeadphonesDTO>(ramModel));
                return Json(new { Result = "OK", Record = ramModel });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }

        [HttpPost]
        public JsonResult Create(HeadphonesViewModel ramModel)
        {
            try
            {
                var id = _genericService.Save(_mapper.Map<HeadphonesViewModel, HeadphonesDTO>(ramModel));
                ramModel.ID = id;
                return Json(new { Result = "OK", Record = ramModel });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }

        [HttpPost]
        public JsonResult Delete(HeadphonesViewModel ramModel)
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