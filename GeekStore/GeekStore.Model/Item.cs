﻿namespace GeekStore.Domain
{
    public enum ItemTypes { Case, Cooler, CPU, Display, GPU, HDD, Headphones, Laptop, Monitor, Motherboard, Mouse, PowerUnit, RAM, Speakers, SSD }
    public abstract class Item
    {
        public Item() { }
        public virtual int ID { get; protected set; }
    }
}