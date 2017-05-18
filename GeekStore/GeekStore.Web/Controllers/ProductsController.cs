using AutoMapper;
using GeekStore.Infrastructure;
using GeekStore.Service.DTO;
using GeekStore.Service.Interfaces;
using GeekStore.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GeekStore.UI.Controllers
{
    public class ProductsController : Controller
    {
        public Dictionary<string, Type> ProductTypeViewsMap = new Dictionary<string, Type>
        {
            { "Case", typeof(CaseViewModel) },
            { "Cooler", typeof(CoolerViewModel)},
            { "CPU", typeof(CPUViewModel) },
            { "Disk", typeof(DiskViewModel) },
            { "Display", typeof(DisplayViewModel) },
            { "GPU", typeof(GPUViewModel) },
            { "Headphones", typeof(HeadphonesViewModel) },
            { "Keyboard", typeof(KeyboardViewModel) },
            { "Laptop", typeof(LaptopViewModel) },
            { "Monitor", typeof(MonitorViewModel) },
            { "Motherboard", typeof(MotherboardViewModel) },
            { "Mouse", typeof(MouseViewModel) },
            { "PowerUnit", typeof(PowerUnitViewModel) },
            { "RAM", typeof(RAMViewModel) },
            { "Speakers", typeof(SpeakersViewModel) }
        };

        private readonly IMapper _mapper;
        public ProductsController(IMapper mapper)
        {
            _mapper = mapper;
        }

        //public ActionResult Cases()
        //{
        //    IGenericService<CaseDTO> service = 
        //}

        public ActionResult Create()
        {
            var productViewModel = new WarehouseProductViewModel();
            productViewModel.ProductTypes = GetProductTypes();
            return View(productViewModel);
        }

        public ActionResult Edit()
        {
            var productViewModel = new WarehouseProductViewModel();
            productViewModel.ProductTypes = GetProductTypes();
            return View(productViewModel);
        }

        [HttpGet]
        public PartialViewResult GetPartialView(string partialViewName)
        {
            if (!ProductTypeViewsMap.ContainsKey(partialViewName))
            {
                throw new NotSupportedException(partialViewName);
            }

            var partialViewModel = Activator.CreateInstance(ProductTypeViewsMap[partialViewName]);
            return PartialView("_ProductTypePartial", partialViewModel);
        }

        //public IEnumerable<ProductViewModel> GetProductsOfAType(string typeName)
        //{

        //}

        public List<SelectListItem> GetProductTypes()
        {
            List<Type> types = typeof(CaseDTO).Assembly.GetTypes().Where(t => t.BaseType == typeof(ProductDTO)).ToList();
            List<SelectListItem> productTypes = new List<SelectListItem>();
            foreach (var type in types)
            {
                var concreteType = type.ToString().Split('.').Last().TrimEnd(new char[] { 'D', 'T', 'O' });
                productTypes.Add(new SelectListItem
                {
                    Text = concreteType,
                    Value = concreteType
                });
            }
            return productTypes;
        }
    }
}