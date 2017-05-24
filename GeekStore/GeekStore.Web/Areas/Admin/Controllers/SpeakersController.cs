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
    public class SpeakersController : Controller
    {
        private readonly IGenericService<SpeakersDTO> _genericService;
        private readonly IMapper _mapper;

        public SpeakersController(IGenericService<SpeakersDTO> genericService, IMapper mapper)
        {
            _genericService = genericService;
            _mapper = mapper;
        }

        public ActionResult Index()
        {
            IEnumerable<SpeakersViewModel> speakers = null;
            return View(speakers);
        }

        [HttpPost]
        public JsonResult GetAll(PagedRequestDescription pageDescription)
        {
            int count = _genericService.GetAllCount();
            var speakers = _mapper.Map<IEnumerable<SpeakersDTO>, IEnumerable<SpeakersViewModel>>(_genericService.GetAllPaged(pageDescription));
            return Json(new { Result = "OK", Records = speakers, TotalRecordCount = count });
        }

        [HttpPost]
        public JsonResult Edit(SpeakersViewModel speakersModel)
        {
            try
            {
                _genericService.Update(_mapper.Map<SpeakersViewModel, SpeakersDTO>(speakersModel));
                return Json(new { Result = "OK", Record = speakersModel });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }

        [HttpPost]
        public JsonResult Create(SpeakersViewModel speakersModel)
        {
            try
            {
                var id = _genericService.Save(_mapper.Map<SpeakersViewModel, SpeakersDTO>(speakersModel));
                speakersModel.ID = id;
                return Json(new { Result = "OK", Record = speakersModel });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }

        [HttpPost]
        public JsonResult Delete(SpeakersViewModel speakersModel)
        {
            try
            {
                _genericService.Delete(speakersModel.ID);
                return Json(new { Result = "OK" });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }
    }
}