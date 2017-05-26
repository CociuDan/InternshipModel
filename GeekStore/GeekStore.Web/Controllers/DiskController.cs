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
    public class DiskController : Controller
    {
        private readonly IGenericService<DiskDTO> _genericService;
        private readonly IGenericService<DiskDTO> _cartService;
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public DiskController(IGenericService<DiskDTO> genericService, IGenericService<DiskDTO> cartService, IUserService userService, IMapper mapper)
        {
            _genericService = genericService;
            _cartService = cartService;
            _userService = userService;
            _mapper = mapper;
        }

        public ActionResult Index(int? page = 1)
        {
            var cpus = _mapper.Map<IEnumerable<DiskDTO>, IEnumerable<DiskViewModel>>(_genericService.GetAll());
            var pager = new Pager(cpus.Count(), page);

            var viewModel = new DiskProductsViewModel
            {
                Disks = cpus.Skip((pager.CurrentPage - 1) * pager.PageSize).Take(pager.PageSize),
                Pager = pager
            };

            return View(viewModel);
        }

        public ActionResult ViewDetails(int coolerId)
        {
            var cpus = new DiskViewModel();
            cpus = _mapper.Map<DiskDTO, DiskViewModel>(_genericService.GetById(coolerId));
            return View(cpus);
        }

        //[HttpPost]
        //public ActionResult ViewDetails(DiskViewModel cpuModel)
        //{
        //    var caseDTO = _genericService.GetById(cpuModel.ID);
        //    var userDTO = _userService.GetByName(HttpContext.User.Identity.Name);
        //    var quantity = cpuModel.Quantity;
        //    var cartDTO = new CartDTO();
        //    cartDTO.Product = caseDTO;
        //    cartDTO.User = userDTO;
        //    cartDTO.Quantity = quantity;
        //    //_cartService.Save(cartDTO);
        //    return RedirectToAction("Index");
        //}
    }
}