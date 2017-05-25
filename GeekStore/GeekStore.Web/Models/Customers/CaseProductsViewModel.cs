using GeekStore.UI.Models.Common;
using System.Collections.Generic;

namespace GeekStore.UI.Models.Customers
{
    public class CaseProductsViewModel
    {
        public Pager Pager { get; set; }
        public IEnumerable<CaseViewModel> Cases { get; set; }

    }
}