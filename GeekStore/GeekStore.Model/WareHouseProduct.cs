using GeekStore.Domain.Model.IDGenerator;
using System;
using System.Text;

namespace GeekStore.Domain
{
    public class WareHouseProduct : Entity
    {
        public WareHouseProduct() { }
        public WareHouseProduct(int itemID, ItemTypes itemType, decimal price, int quantity)
        {
            if (itemID <= 0) throw new ArgumentException($"Invalid ItemID. Entered value: {itemID}");
            if (price <= 0) throw new ArgumentException("Price cannot be less or equal to 0");
            if (quantity <= 0) throw new ArgumentException("Quantity cannot be less or equal to 0");

            ItemID = itemID;
            ItemType = itemType;
            Price = price;
            Quantity = quantity;
        }

        public virtual int ItemID { get; protected set; }

        public virtual ItemTypes ItemType { get; protected set; }

        public virtual decimal Price { get; protected set; }

        public virtual int Quantity { get; protected set; }

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