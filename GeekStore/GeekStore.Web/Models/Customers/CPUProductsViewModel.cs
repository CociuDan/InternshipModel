using GeekStore.UI.Models.Common;
using System.Collections.Generic;

namespace GeekStore.UI.Models.Customers
{
    public class CPUProductsViewModel
    {
        public Pager Pager { get; set; }
        public IEnumerable<CPUViewModel> CPUs { get; set; }
    }
}