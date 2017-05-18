using System.Collections.Generic;

namespace GeekStore.UI.Models
{
    public class CaseProductsViewModel
    {
        public Pager Pager { get; set; }
        public IEnumerable<CaseViewModel> Cases { get; set; }
    }
}