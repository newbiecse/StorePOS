namespace StorePOS.Models
{
    public class OrderItem
    {
        public OrderItem(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }

        public int Quantity { get; set; }
        public Product Product { get; set; }
        public Order Order { get; set; }
    }
}
