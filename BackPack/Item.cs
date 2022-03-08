namespace BackPack
{
    public class Item
    {
        public Item(int weight, int price)
        {
            Weight = weight;
            Price = price;
        }

        public int Price { get; set; }
        public int Weight { get; set; }
    }
}