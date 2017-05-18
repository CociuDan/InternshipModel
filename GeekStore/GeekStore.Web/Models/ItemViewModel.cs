using System.Collections.Generic;
using System.Web.Mvc;

namespace GeekStore.UI.Models
{
    public class ItemViewModel
    {
        public int Page { get; set; }
        public List<SelectListItem> PageSize { get; set; }
        public IEnumerable<ProductViewModel> Products { get; set; }
        public int TotalPages { get; set; }
    }
}