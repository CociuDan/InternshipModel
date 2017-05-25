using GeekStore.UI.Models.Common;
using System.Collections.Generic;

namespace GeekStore.UI.Models.Customers
{
    public class DiskProductsViewModel
    {
        public Pager Pager { get; set; }
        public IEnumerable<DiskViewModel> Disks { get; set; }
    }
}