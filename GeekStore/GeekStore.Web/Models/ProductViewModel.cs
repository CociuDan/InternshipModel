﻿using GeekStore.Service.DTO;

namespace GeekStore.UI.Models
{
    public abstract class ProductViewModel : EntityViewModel
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public decimal? Price { get; set; }
        public int? AvailableQuantity { get; set; }
        public int? Quantity { get; set; }
    }
}