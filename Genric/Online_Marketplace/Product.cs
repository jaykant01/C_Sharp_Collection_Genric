namespace Online_Marketplace
{
    public class Product<T> where T : Category
    {
        public string Name {get;}
        public double Price { get; private set; }
        public T Category {get; }
        

        public Product(string name, double price, T category)
        {
            Name = name;
            Price = price;
            Category = category;
        }


        public void UpdatePrice(double newPrice)
        {
            Price = newPrice;
        }

    }
}


