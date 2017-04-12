using GeekStore.Domain.Infrastucture;
using System;
using System.Text;
using System.Xml.Serialization;
using System.Xml;
using System.Xml.Schema;
using System.Collections.Generic;

namespace GeekStore.Domain
{
    public class Product
    {
        Product() { }
        public Product(int itemID, ItemTypes itemType, double price, int quantity)
        {
            if (itemID <= 0)
                throw new ArgumentException($"Invalid ItemID. Entered value: {itemID}");

            if (price <= 0)
                throw new ArgumentException("Price cannot be less or equal to 0");

            if (quantity <= 0)
                throw new ArgumentException("Quantity cannot be less or equal to 0");

            ID = IDGenerator<Product>.NextID();
            ItemID = itemID;
            ItemType = itemType;
            Price = price;
            Quantity = quantity;
        }

        public int ID { get; private set; }

        public int ItemID { get; private set; }

        public ItemTypes ItemType { get; private set; }

        public double Price { get; private set; }

        public int Quantity { get; private set; }

        public void AddToWarehouse(int incomingQuantity)
        {
            if (incomingQuantity <= 0)
                throw new ArgumentException("You cannot add less than one item to warehouse. Enterd value: " + incomingQuantity.ToString());
            Quantity += incomingQuantity;
        }

        public void SellQuantity(int sellingQuantity)
        {
            if (sellingQuantity <= 0)
                throw new ArgumentException("You cannot sell less than one item from warehouse. Enterd value: " + sellingQuantity.ToString());
            Quantity -= sellingQuantity;
        }

        public void ChangePrice(double newPrice)
        {
            if (newPrice <= 0)
                throw new ArgumentException("New Price cannot be less or equal to 0. Entered value: " + newPrice.ToString());
            Price = newPrice;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"\tID: {ID}");
            sb.AppendLine($"\tItemID {ItemID}");
            sb.AppendLine($"\tItemType: {ItemType}");
            sb.AppendLine($"\tPrice: {Price}");
            sb.AppendLine($"\tQuantity: {Quantity}");
            return sb.ToString();
        }
    }
}
