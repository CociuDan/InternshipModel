using AutoMapper;
using GeekStore.Service.DTO;
using GeekStore.Service.Interfaces;
using GeekStore.UI.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace GeekStore.UI.Controllers
{
    public class CasesController : Controller
    {
        private readonly IGenericService<CaseDTO> _genericService;
        private readonly IProductService<CaseDTO> _productService;
        private readonly IGenericService<CartDTO> _cartService;
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public CasesController(IGenericService<CaseDTO> genericService, IGenericService<CartDTO> cartService, IProductService<CaseDTO> productService, IUserService userService, IMapper mapper)
        {
            _genericService = genericService;
            _cartService = cartService;
            _productService = productService;
            _userService = userService;
            _mapper = mapper;
        }

        public ActionResult Index(int? page = 1)
        {
            var cases = _mapper.Map<IEnumerable<CaseDTO>, IEnumerable<CaseViewModel>>(_genericService.GetAll());
            var pager = new Pager(cases.Count(), page);

            var viewModel = new CaseProductsViewModel
            {
                Cases = cases.Skip((pager.CurrentPage - 1) * pager.PageSize).Take(pager.PageSize),
                Pager = pager
            };

            return View(viewModel);
        }

        public ActionResult AllCases()
        {
            var cases = _mapper.Map<IEnumerable<CaseDTO>, IEnumerable<CaseViewModel>>(_genericService.GetAll());
            return View(cases);
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

        public ActionResult ViewDetails(int caseId)
        {
            var caseModel = new CaseViewModel();
            caseModel = _mapper.Map<CaseDTO, CaseViewModel>(_genericService.GetById(caseId));
            return View(caseModel);
        }

        [HttpPost]
        public ActionResult ViewDetails(CaseViewModel caseModel)
        {
            var caseDTO = _genericService.GetById(caseModel.ID);
            var userDTO = _userService.GetById(1);
            var quantity = caseModel.Quantity;
            var cartDTO = new CartDTO();
            cartDTO.Product = caseDTO;
            cartDTO.User = userDTO;
            cartDTO.Quantity = quantity;            
            _cartService.Save(cartDTO);
            return RedirectToAction("Index");
        }








        //public ActionResult Cases()
        //{
        //    IEnumerable<CaseViewModel> cases = _mapper.Map<IEnumerable<CaseDTO>, IEnumerable<CaseViewModel>>(_casesService.GetAll());
        //    return View(cases);
        //}

        //public JsonResult GetAll()
        //{
        //    var cases =  (List<CaseViewModel>)_mapper.Map<IEnumerable<CaseDTO>, IEnumerable<CaseViewModel>>(_casesService.GetAll());
        //    return Json(cases, JsonRequestBehavior.AllowGet);
        //}

        //[HttpGet]
        //public PartialViewResult GetPartialView(int productId)
        //{
        //    var partialView = _mapper.Map<CaseDTO, CaseViewModel>(_casesService.GetById(productId));
        //    return PartialView("_ProductTypePartial", partialView);
        //}

        //public ActionResult CaseProducts()
        //{
        //    IEnumerable<CaseViewModel> cases = _mapper.Map<IEnumerable<CaseDTO>, IEnumerable<CaseViewModel>>(_casesService.GetAll());
        //    return View(cases);
        //}

        //[HttpGet]
        //public JsonResult GetCaseProducts()
        //{
        //    var caseProducts = new List<CaseProductsViewModel>();
        //    var cases = _casesService.GetAll();
        //    foreach (var pcCase in cases)
        //    {
        //        var product = _warehouseProductService.GetByProductId(pcCase.ID);
        //        caseProducts.Add(new CaseProductsViewModel
        //        {
        //            ID = pcCase.ID,
        //            FormFactor = pcCase.FormFactor,
        //            Manufacturer = pcCase.Manufacturer,
        //            Model = pcCase.Model,
        //            Price = product.Price,
        //            Quantity = product.Quantity
        //        });
        //    }
        //    return Json(caseProducts, JsonRequestBehavior.AllowGet);
        //}
    }
}