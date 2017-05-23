using AutoMapper;
using GeekStore.Service.DTO;
using GeekStore.Service.Interfaces;
using GeekStore.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace GeekStore.UI.Areas.Admin.Controllers
{
    public class CaseController : Controller
    {
        private readonly IGenericService<CaseDTO> _genericService;
        private readonly IMapper _mapper;

        public CaseController(IGenericService<CaseDTO> genericService, IMapper mapper)
        {
            _genericService = genericService;
            _mapper = mapper;
        }

        public ActionResult Index()
        {
            IEnumerable<CaseViewModel> cases = null;
            return View(cases);
        }

        [HttpPost]
        public JsonResult GetAll()
        {
            var cases = _mapper.Map<IEnumerable<CaseDTO>, IEnumerable<CaseViewModel>>(_genericService.GetAll());
            return Json(new { Result = "OK", Records = cases });
        }

        [HttpPost]
        public JsonResult Edit(CaseViewModel caseModel)
        {            
            try
            {
                _genericService.Update(_mapper.Map<CaseViewModel, CaseDTO>(caseModel));
                return Json(new { Result = "OK", Record = caseModel });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }

        [HttpPost]
        public JsonResult Create(CaseViewModel caseModel)
        {
            try
            {
                var id = _genericService.Save(_mapper.Map<CaseViewModel, CaseDTO>(caseModel));
                caseModel.ID = id;                
                return Json(new { Result = "OK", Record = caseModel  });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }

        [HttpPost]
        public JsonResult Delete(CaseViewModel caseModel)
        {
            try
            {
                _genericService.Delete(caseModel.ID);
                return Json(new { Result = "OK" });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }
    }
}