using GeekStore.Model.Infrastucture;
using System;
using System.Text;

namespace GeekStore.Model.Components.Disks
{
    public class DesktopHDD : Disk, IItem
    {
        private readonly int _id;
        private readonly string _manufacturer;
        private readonly string _model;
        private double _price;
        private int _quantity;
        private readonly int _rpm;


        public DesktopHDD(int capacity, string manufacturer, string model, double price, int readSpeed, int rpm, int writeSpeed) : base(capacity, readSpeed, writeSpeed)
        {
            if (string.IsNullOrEmpty(manufacturer) || string.IsNullOrWhiteSpace(manufacturer))
                throw new ArgumentNullException(manufacturer);

            if (string.IsNullOrEmpty(model) || string.IsNullOrWhiteSpace(model))
                throw new ArgumentNullException(model);

            if (price <= 0)
                throw new ArgumentException("Price cannot be less or equal to 0. Entered value: " + price.ToString());

            if (rpm <= 0)
                throw new ArgumentException("HDD RPM cannot be less or equal to 0");

            _id = IDGenerator.NextID();
            _manufacturer = manufacturer;
            _model = model;
            _price = price;
            _rpm = rpm;

            AddToWarehouse(1);
        }

        public string Description
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"#{ID}");
                sb.AppendLine($"\tManufacturer: {Manufacturer}");
                sb.AppendLine($"\tModel: {Model}");
                sb.AppendLine($"\tCapacity: {Capacity}GB");
                sb.AppendLine($"\tRPM: {RPM}GB");
                sb.AppendLine($"\tRead Speed: {ReadSpeed}Mbs");
                sb.AppendLine($"\tWrite Speed: {WriteSpeed}Mbs");
                return sb.ToString();
            }
        }

        public int ID { get { return _id; } }

        public string Manufacturer { get { return _manufacturer; } }

        public string Model { get { return _model; } }

        public double Price { get { return _price; } }

        public int Quantity { get { return _quantity; } }

        public int RPM { get { return _quantity; } }

        public void AddToWarehouse(int incomingQuantity)
        {
            if (incomingQuantity <= 0)
                throw new ArgumentException("You cannot add less than one item to warehouse. Enterd value: " + incomingQuantity.ToString());
            _quantity += incomingQuantity;
        }

        public void SellQuantity(int sellingQuantity)
        {
            if (sellingQuantity <= 0)
                throw new ArgumentException("You cannot sell less than one item from warehouse. Enterd value: " + sellingQuantity.ToString());
            _quantity -= sellingQuantity;
        }

        public void ChangePrice(double newPrice)
        {
            if (newPrice <= 0)
                throw new ArgumentException("New Price cannot be less or equal to 0. Entered value: " + newPrice.ToString());
            _price = newPrice;
        }
    }
}
