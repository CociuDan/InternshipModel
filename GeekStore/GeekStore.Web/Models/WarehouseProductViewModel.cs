using GeekStore.Service.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;

namespace GeekStore.UI.Models
{
    public class WarehouseProductViewModel
    {
        public WarehouseProductViewModel() { }

        public Type Type { get; set; }

        public List<SelectListItem> ProductTypes { get; set; }

        public List<SelectListItem> ProductsOfAType { get; set; }

        [Required]
        [Display(Name = "Product Type")]
        public virtual Type ProductType { get; set; }

        [Required]
        [Display(Name = "Concrete Product")]
        public virtual ProductViewModel Product { get; set; }

        [Required]
        [Display(Name = "Price")]
        public virtual decimal Price { get; set; }

        [Required]
        [Display(Name = "Quantity")]
        public virtual int Quantity { get; set; }

        
    }
}