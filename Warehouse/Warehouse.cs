namespace Warehouse
{
    public class Warehouse
    {
        public List<Item> Items { get; set; }

        public Warehouse(List<Item> items)
        {
            Items = items;
        }

        public void getInventory()
        {
            foreach (Item item in Items)
                {
                    Console.WriteLine(item.InventoryAmount);
                }
        }
    }
}