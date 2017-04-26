using System;
using System.Collections.Generic;

namespace GeekStore.Domain.Model
{
    public class Order : Entity
    {
        public Order() { }
        public virtual DateTime OrderDate { get; protected set; }
        public virtual IList<OrderItem> OrderItems { get; protected set; }
        public virtual decimal TotalPrice { get; protected set; }
        public virtual User User { get; protected set; }
    }
}