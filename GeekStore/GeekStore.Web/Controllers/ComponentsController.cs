using GeekStore.Service.DTO;
using GeekStore.Service.Interfaces;
using GeekStore.UI.Models;
using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;

namespace GeekStore.UI.Controllers
{
    public class ComponentsController : Controller
    {
        private readonly IGenericService<CaseDTO> _genericService;
        private readonly IMapper _mapper = null;

        public ComponentsController(IGenericService<CaseDTO> genericService, IMapper mapper)
        {
            _genericService = genericService;
            _mapper = mapper;
        }

        public ActionResult Cases()
        {
            IEnumerable<CaseViewModel> cases = _mapper.Map<IEnumerable<CaseDTO>, IEnumerable<CaseViewModel>>(_genericService.GetAll());
            return View(cases);
        }
    }
}