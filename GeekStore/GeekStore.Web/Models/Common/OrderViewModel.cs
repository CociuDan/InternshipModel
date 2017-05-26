using System;
using System.Collections.Generic;

namespace GeekStore.UI.Models.Common
{
    public class OrderViewModel
    {
        public DateTime OrderDate { get; set; }
        public IList<OrderItemViewModel> OrderItems { get; set; }
        public decimal TotalPrice { get; set; }
        public UserViewModel User { get; set; }
    }
}