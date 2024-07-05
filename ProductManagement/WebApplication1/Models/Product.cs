namespace BOL
{
    public class Product
    {
        public int Pid { get; set; }

        public string Pname { get; set; }

        public int Qty { get; set; }

        public double Price { get; set; }

        public Product() { }

        public Product(int id, string name, int qty, double price)
        {
            Pid = id;
            Pname = name;
            Qty = qty;
            Price = price;
        }
    }
}
