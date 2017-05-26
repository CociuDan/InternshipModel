using AutoMapper;
using GeekStore.Service.DTO;
using GeekStore.Service.Interfaces;
using GeekStore.UI.Models.Common;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace GeekStore.UI.Controllers
{
    public class CartController : Controller
    {
        private IMapper _mapper;

        public CartController(IMapper mapper)
        {
            _mapper = mapper;
        }

        public ActionResult Index()
        {
            var cartItems = new List<ProductViewModel>();
            if((List<ProductViewModel>)Session["CartItemsList"] != null)
                cartItems = (List<ProductViewModel>)Session["CartItemsList"];
            return View(cartItems);
        }
        
        [HttpPost]
        public ActionResult Index(IEnumerable<ProductViewModel> cartItems)
        {
            if(HttpContext.User.Identity == null)
            {
                return RedirectToAction("Login", "Users");
            }
            var order = new OrderViewModel();
            var orderItems = new List<OrderItemViewModel>();
            decimal totalPrice = 0m;
            foreach(var cartItem in cartItems)
            {
                var orderItem = new OrderItemViewModel();
                orderItem.ProductFullDescription = cartItem.Manufacturer + cartItem.Model;
                orderItem.ProductType = cartItem.GetType().ToString().Split('.').Last()
                    .Substring(0, cartItem.GetType().ToString().Split('.').Last().Length - 9);
                orderItem.Price = cartItem.Price;
                totalPrice += cartItem.Price;
                orderItem.Quantity = cartItem.Quantity;
                orderItems.Add(orderItem);
            }
            order.OrderItems = orderItems;
            order.TotalPrice = totalPrice;
            return View();
        }
    }
}