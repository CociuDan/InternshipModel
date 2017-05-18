using System.Web.Mvc;
using GeekStore.Service.DTO;
using GeekStore.UI.Models;
using GeekStore.Service.Interfaces;
using AutoMapper;
using System;

namespace GeekStore.UI.Controllers
{
    public class CreateProductController : Controller
    {

        private readonly IGenericService<CaseDTO> _service;
        private readonly IMapper _mapper;
        public CreateProductController(IGenericService<CaseDTO> service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public ActionResult Case()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Case(CaseViewModel caseViewModel)
        {
            _service.Save(_mapper.Map<CaseViewModel, CaseDTO>(caseViewModel));            
            return View();
        }
    }
}