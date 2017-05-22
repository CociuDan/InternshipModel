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
    public class CasesController : Controller
    {
        private readonly IGenericService<CaseDTO> _genericService;
        private readonly IMapper _mapper;

        public CasesController(IGenericService<CaseDTO> genericService, IMapper mapper)
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

        public ActionResult Edit(int caseId)
        {
            return View(_mapper.Map<CaseDTO, CaseViewModel>(_genericService.GetById(caseId)));
        }

        [HttpPost]
        public ActionResult Edit(CaseViewModel caseModel)
        {
            _genericService.Update(_mapper.Map<CaseViewModel, CaseDTO>(caseModel));
            return RedirectToAction("AllCases");
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(CaseViewModel caseModel)
        {
            _genericService.Save(_mapper.Map<CaseViewModel, CaseDTO>(caseModel));
            return RedirectToAction("AllCases");
        }

        public ActionResult Delete(int id)
        {
            return View(_mapper.Map<CaseDTO, CaseViewModel>(_genericService.GetById(id)));
        }

        [HttpPost]
        public ActionResult Delete(CaseViewModel caseModel)
        {
            _genericService.Delete(caseModel.ID);
            return RedirectToAction("AllCases");
        }
    }
}