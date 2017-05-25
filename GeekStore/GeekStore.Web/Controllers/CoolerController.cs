using AutoMapper;
using GeekStore.Service.DTO;
using GeekStore.Service.Interfaces;
using GeekStore.UI.Models.Common;
using GeekStore.UI.Models.Customers;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace GeekStore.UI.Controllers
{
    public class CoolerController : Controller
    {
        private readonly IGenericService<CoolerDTO> _genericService;
        private readonly IGenericService<CoolerDTO> _cartService;
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public CoolerController(IGenericService<CoolerDTO> genericService, IGenericService<CoolerDTO> cartService, IUserService userService, IMapper mapper)
        {
            _genericService = genericService;
            _cartService = cartService;
            _userService = userService;
            _mapper = mapper;
        }

        public ActionResult Index(int? page = 1)
        {
            var coolers = _mapper.Map<IEnumerable<CoolerDTO>, IEnumerable<CoolerViewModel>>(_genericService.GetAll());
            var pager = new Pager(coolers.Count(), page);

            var viewModel = new CoolerProductsViewModel
            {
                Coolers = coolers.Skip((pager.CurrentPage - 1) * pager.PageSize).Take(pager.PageSize),
                Pager = pager
            };

            return View(viewModel);
        }

        public ActionResult ViewDetails(int coolerId)
        {
            var caseModel = new CaseViewModel();
            caseModel = _mapper.Map<CoolerDTO, CaseViewModel>(_genericService.GetById(coolerId));
            return View(caseModel);
        }

        [HttpPost]
        public ActionResult ViewDetails(CoolerViewModel coolerModel)
        {
            var caseDTO = _genericService.GetById(coolerModel.ID);
            var userDTO = _userService.GetByName(HttpContext.User.Identity.Name);
            var quantity = coolerModel.Quantity;
            var cartDTO = new CartDTO();
            cartDTO.Product = caseDTO;
            cartDTO.User = userDTO;
            cartDTO.Quantity = quantity;
            //_cartService.Save(cartDTO);
            return RedirectToAction("Index");
        }
    }
}