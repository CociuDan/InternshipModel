﻿using GeekStore.Service.DTO;
using GeekStore.Service.Interfaces;
using GeekStore.UI.Models;
using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;

namespace GeekStore.UI.Controllers
{
    public class CaseController : Controller
    {
        private readonly IGenericService<CaseDTO> _genericService;
        private readonly IMapper _mapper = null;

        public CaseController(IGenericService<CaseDTO> genericService, IMapper mapper)
        {
            _genericService = genericService;
            _mapper = mapper;
        }

        public ActionResult Case()
        {
            IEnumerable<CaseViewModel> cases = _mapper.Map<IEnumerable<CaseDTO>, IEnumerable<CaseViewModel>>(_genericService.GetAll());
            return View(cases);
        }
    }
}