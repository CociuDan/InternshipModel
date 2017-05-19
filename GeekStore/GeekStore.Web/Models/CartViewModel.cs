using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeekStore.UI.Models
{
    public class CartViewModel : EntityViewModel
    {
        public ProductViewModel Product { get; set; }
        public UserViewModel User { get; set; }
        public int? Quantity { get; set; }
    }
}