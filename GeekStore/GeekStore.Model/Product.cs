using GeekStore.Model.Infrastucture;
using System;
using System.Text;

namespace GeekStore.Model
{
    public class Product
    {
        private readonly int _id;
        private readonly IItem _item;
        private double _price;
        private int _quantity;

        public Product(IItem item, double price, int quantity)
        {
            _id = IDGenerator.NextID();
            _item = item;
            _price = price;
            _quantity = quantity;
        }

        public int ID { get { return _id; } }

        public IItem Item { get { return _item; } }

        public double Price { get { return _price; } }

        public int Quantity { get { return _quantity; } }

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

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Item.Description);
            sb.AppendLine($"\tPrice: {Price}");
            return sb.ToString();
        }
    }
}
