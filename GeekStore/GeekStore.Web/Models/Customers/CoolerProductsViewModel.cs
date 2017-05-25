using GeekStore.UI.Models.Common;
using System.Collections.Generic;

namespace GeekStore.UI.Models.Customers
{
    public class CoolerProductsViewModel
    {
        public Pager Pager { get; set; }
        public IEnumerable<CoolerViewModel> Coolers { get; set; }
    }
}