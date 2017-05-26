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
    public class CPUController : Controller
    {
        private readonly IGenericService<CPUDTO> _genericService;
        private readonly IGenericService<CPUDTO> _cartService;
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public CPUController(IGenericService<CPUDTO> genericService, IGenericService<CPUDTO> cartService, IUserService userService, IMapper mapper)
        {
            _genericService = genericService;
            _cartService = cartService;
            _userService = userService;
            _mapper = mapper;
        }

        public ActionResult Index(int? page = 1)
        {
            var cpus = _mapper.Map<IEnumerable<CPUDTO>, IEnumerable<CPUViewModel>>(_genericService.GetAll());
            var pager = new Pager(cpus.Count(), page);

            var viewModel = new CPUProductsViewModel
            {
                CPUs = cpus.Skip((pager.CurrentPage - 1) * pager.PageSize).Take(pager.PageSize),
                Pager = pager
            };

            return View(viewModel);
        }

        public ActionResult ViewDetails(int cpuId)
        {
            var cpu = new CPUViewModel();
            cpu = _mapper.Map<CPUDTO, CPUViewModel>(_genericService.GetById(cpuId));
            return View(cpu);
        }

        [HttpPost]
        public ActionResult ViewDetails(CPUViewModel cpuModel)
        {
            var cartItems = new List<ProductViewModel>();
            if ((List<ProductViewModel>)Session["CartItemsList"] != null)
            {
                cartItems = (List<ProductViewModel>)Session["CartItemsList"];
            }
            var cpuDTO = _mapper.Map<CPUDTO, CPUViewModel>(_genericService.GetById(cpuModel.ID));
            cpuDTO.Quantity = cpuModel.Quantity;
            cartItems.Add(cpuDTO);
            Session["CartItemsList"] = cartItems;
            return RedirectToAction("Index");
        }
    }
}