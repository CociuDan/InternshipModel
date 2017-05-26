﻿namespace GeekStore.UI.Models.Common
{
    public abstract class ProductViewModel : EntityViewModel
    {
        public int AvailableQuantity { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}