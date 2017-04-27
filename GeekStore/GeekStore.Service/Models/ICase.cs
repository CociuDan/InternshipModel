using System;

namespace GeekStore.Service.Models
{
    public abstract class ICase : IProduct
    {
        public int ID { get; set; }

        public string Manufacturer { get; set; }

        public string Model { get; set; }

        public string Description { get; }
        public string FormFactor { get; }
    }
}
