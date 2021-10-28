﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DataLogic.Entities
{
    public partial class Order
    {
        public Order()
        {
            ItemsInOrders = new HashSet<ItemsInOrder>();
        }

        public int OrdersId { get; set; }
        public int CustomerId { get; set; }
        public int StoreFrontId { get; set; }
        public decimal TotalPrice { get; set; }
        public string Address { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual StoreFront StoreFront { get; set; }
        public virtual ICollection<ItemsInOrder> ItemsInOrders { get; set; }
    }
}
