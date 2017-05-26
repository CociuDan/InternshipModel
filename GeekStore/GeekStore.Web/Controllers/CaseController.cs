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
    public class CaseController : Controller
    {
        private readonly IGenericService<CaseDTO> _genericService;
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public CaseController(IGenericService<CaseDTO> genericService, IUserService userService, IMapper mapper)
        {
            _genericService = genericService;
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

        public ActionResult ViewDetails(int caseId)
        {
            var caseModel = new CaseViewModel();
            caseModel = _mapper.Map<CaseDTO, CaseViewModel>(_genericService.GetById(caseId));
            return View(caseModel);
        }

        [HttpPost]
        public ActionResult ViewDetails(CaseViewModel caseModel)
        {
            var cartItems = new List<ProductViewModel>();
            if ((List<ProductViewModel>)Session["CartItemsList"] != null)
            {
                cartItems = (List<ProductViewModel>)Session["CartItemsList"];
            }
            var pcCase = _mapper.Map<CaseDTO, CaseViewModel>(_genericService.GetById(caseModel.ID));
            if (cartItems.Count > 0)
            {
                foreach (var item in cartItems)
                {
                    if (item.ID == pcCase.ID)
                    {
                        pcCase.Quantity = caseModel.Quantity;
                        item.Quantity += pcCase.Quantity;
                    }
                    else
                    {
                        pcCase.Quantity = caseModel.Quantity;
                        cartItems.Add(pcCase);
                    }
                }
            }
            else
            {
                pcCase.Quantity = caseModel.Quantity;
                cartItems.Add(pcCase);
            }
            Session["CartItemsList"] = cartItems;
            return RedirectToAction("Index");
        }
    }
}