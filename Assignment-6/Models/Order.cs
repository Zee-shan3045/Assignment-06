namespace Assignment06.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public List<Product> Products { get; set; }

        public decimal Total { get; set; }
    }
}
