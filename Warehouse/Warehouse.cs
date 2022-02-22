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
                    Console.WriteLine($"{item.Name}: {item.InventoryAmount}");
                }
        }

        public void decreaseInventory(Item name, int amount)
        {
            name.InventoryAmount -= amount;
        }

        public void addInventory(Item name, int amount)
        {
            name.InventoryAmount += amount;
        }
    }
}