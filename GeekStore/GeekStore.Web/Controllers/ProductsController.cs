using GeekStore.Service.DTO;
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
        public ActionResult Create()
        {
            var productViewModel = new WarehouseProductViewModel();

            List<System.Type> types = typeof(CaseDTO).Assembly.GetTypes().Where(t => t.BaseType == typeof(ProductDTO)).ToList();
            List<SelectListItem> productTypes = new List<SelectListItem>();
            foreach (var type in types)
            {
                productTypes.Add(new SelectListItem
                {
                    Text = type.ToString().Split('.').Last().TrimEnd(new char[] { 'D', 'T', 'O' }),
                    Value = type.ToString().Split('.').Last().TrimEnd(new char[] { 'D', 'T', 'O' })
                });
            }
            productViewModel.ProductTypes = productTypes;
            return View(productViewModel);
        }

        [HttpGet]
        public ActionResult GetPartialView(string partialViewName)
        {
            var partialViewModel = Activator.CreateInstance("GeekStore.UI.Models", $"{partialViewName}ViewModel");
            return PartialView($"_{partialViewName}Partial", partialViewModel);
        }
    }
}