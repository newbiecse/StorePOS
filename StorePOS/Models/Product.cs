namespace StorePOS.Models
{
    public class Product
    {
        public Product(int id, string name, decimal price, string unit)
        {
            Id = id;
            Name = name;
            Price = price;
            Unit = unit;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Unit { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
