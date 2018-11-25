using System;
using System.Collections.Generic;

namespace StorePOS.Models
{
    public class Order
    {
        public int Id { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public DateTimeOffset OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
