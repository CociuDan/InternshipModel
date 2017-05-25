using AutoMapper;
using GeekStore.Service.DTO;
using GeekStore.Service.Interfaces;
using GeekStore.UI.Models.Common;
using System.Collections.Generic;
using System.Web.Mvc;

namespace GeekStore.UI.Controllers
{
    public class CartController : Controller
    {
        private IGenericService<CartDTO> _genericService;
        private IMapper _mapper;

        public CartController(IGenericService<CartDTO> genericService, IMapper mapper)
        {
            _genericService = genericService;
            _mapper = mapper;
        }

        public ActionResult Index()
        {
            var cartObjects = _mapper.Map<IEnumerable<CartDTO>, IEnumerable<CartViewModel>>(_genericService.GetAll());
            return View(cartObjects);
        }
    }
}