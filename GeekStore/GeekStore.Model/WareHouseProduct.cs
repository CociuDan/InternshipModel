﻿using GeekStore.Domain.Model.IDGenerator;
using System;
using System.Text;

namespace GeekStore.Domain
{
    public class WareHouseProduct : Item
    {
        WareHouseProduct() { }
        public WareHouseProduct(int itemID, ItemTypes itemType, double price, int quantity)
        {
            if (itemID <= 0) throw new ArgumentException($"Invalid ItemID. Entered value: {itemID}");
            if (price <= 0) throw new ArgumentException("Price cannot be less or equal to 0");
            if (quantity <= 0) throw new ArgumentException("Quantity cannot be less or equal to 0");

            ItemID = itemID;
            ItemType = itemType;
            Price = price;
            Quantity = quantity;
        }

        public int ItemID { get; private set; }

        public ItemTypes ItemType { get; private set; }

        public double Price { get; private set; }

        public int Quantity { get; private set; }

        public void AddToWarehouse(int incomingQuantity)
        {
            if (incomingQuantity <= 0) throw new ArgumentException("You cannot add less than one item to warehouse. Enterd value: " + incomingQuantity.ToString());
            Quantity += incomingQuantity;
        }

        public void SellQuantity(int sellingQuantity)
        {
            if (sellingQuantity <= 0) throw new ArgumentException("You cannot sell less than one item from warehouse. Enterd value: " + sellingQuantity.ToString());
            Quantity -= sellingQuantity;
        }

        public void ChangePrice(double newPrice)
        {
            if (newPrice <= 0) throw new ArgumentException("New Price cannot be less or equal to 0. Entered value: " + newPrice.ToString());
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