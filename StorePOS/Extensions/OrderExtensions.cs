using StorePOS.Models;
using System.Linq;

namespace StorePOS.Extensions
{
    public static class OrderExtensions
    {
        public static void CaculateTotalAmount(this Order order)
        {
            order.TotalAmount = order.Items.Sum(i => i.Product.Price * i.Quantity);
        }

        public static OrderItem AddItem(this Order order, OrderItem item)
        {
            var existedItem = order.Items.FirstOrDefault(i => i.Product.Id == item.Product.Id);

            if (existedItem != null)
            {
                existedItem.Quantity += item.Quantity;
                item.Quantity = existedItem.Quantity;
            }
            else
            {
                order.Items.Add(item);
            }

            order.CaculateTotalAmount();

            return item;
        }

        public static bool RemoveItem(this Order order, int productId)
        {
            var existedItem = order.Items.FirstOrDefault(i => i.Product.Id == productId);
            if (existedItem == null)
            {
                return false;
            }

            order.Items.Remove(existedItem);

            order.CaculateTotalAmount();

            return true;
        }

        public static decimal GetAmount(this OrderItem item)
        {
            return item.Product.Price * item.Quantity;
        }
    }
}
