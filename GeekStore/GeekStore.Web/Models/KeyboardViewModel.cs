﻿namespace GeekStore.UI.Models
{
    public class KeyboardViewModel : ProductViewModel
    {
        public bool BackLight { get; set; }
        public string Description
        {
            get
            {
                return $"{Manufacturer} {Model} {Type} {BackLight}";
            }
        }
        public string Type { get; set; }
    }
}