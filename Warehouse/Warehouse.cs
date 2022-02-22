namespace Warehouse
{
    public class Warehouse
    {
        public List<Item> Items { get; set; }

        public Warehouse(List<Item> items)
        {
            Items = items;
        }
    }
}