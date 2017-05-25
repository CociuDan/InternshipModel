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
    public class HeadphonesController : BaseController
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
            IEnumerable<HeadphonesViewModel> headphones = null;
            return View(headphones);
        }

        [HttpPost]
        public JsonResult GetAll(PagedRequestDescription pageDescription)
        {
            int count = _genericService.GetAllCount();
            var headphones = _mapper.Map<IEnumerable<HeadphonesDTO>, IEnumerable<HeadphonesViewModel>>(_genericService.GetAllPaged(pageDescription));
            return Json(new { Result = "OK", Records = headphones, TotalRecordCount = count });
        }

        [HttpPost]
        public JsonResult Edit(HeadphonesViewModel headphoneModel)
        {
            try
            {
                _genericService.Update(_mapper.Map<HeadphonesViewModel, HeadphonesDTO>(headphoneModel));
                return Json(new { Result = "OK", Record = headphoneModel });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }

        [HttpPost]
        public JsonResult Create(HeadphonesViewModel headphoneModel)
        {
            try
            {
                var id = _genericService.Save(_mapper.Map<HeadphonesViewModel, HeadphonesDTO>(headphoneModel));
                headphoneModel.ID = id;
                return Json(new { Result = "OK", Record = headphoneModel });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }

        [HttpPost]
        public JsonResult Delete(HeadphonesViewModel headphoneModel)
        {
            try
            {
                _genericService.Delete(headphoneModel.ID);
                return Json(new { Result = "OK" });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }
    }
}