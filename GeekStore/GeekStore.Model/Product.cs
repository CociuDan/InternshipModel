using GeekStore.Model.Infrastucture;
using System;
using System.Text;
using System.Xml.Serialization;
using System.Xml;
using System.Xml.Schema;

namespace GeekStore.Model
{
    public class Product : IXmlSerializable
    {
        public Product()
        {

        }
        public Product(IItem item, double price, int quantity)
        {
            ID = IDGenerator.NextID();
            Item = item;
            Price = price;
            Quantity = quantity;
        }

        public Product(int id, IItem item, double price, int quantity)
        {
            ID = id;
            Item = item;
            Price = price;
            Quantity = quantity;
        }

        public int ID { get; private set; }

        public IItem Item { get; private set; }

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
            sb.Append(Item.Description);
            sb.AppendLine($"\tPrice: {Price}");
            return sb.ToString();
        }

        public XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            ID = int.Parse(reader["ID"]);
            Price = double.Parse(reader["Price"]);
            Quantity = int.Parse(reader["Quantity"]);
            Item = 
            reader.Read();
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteAttributeString("ID", ID.ToString());
            writer.WriteAttributeString("Price", Price.ToString());
            writer.WriteAttributeString("Quantity", Quantity.ToString());
            Item.WriteXml(writer);            
        }
    }
}
