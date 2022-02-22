namespace Warehouse
{
    public class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int InventoryAmount { get; set; }

        public Item(string name, double price, int inventoryAmount)
        {
            Name = name;
            Price = price;
            InventoryAmount = inventoryAmount;
        }

        public void decreaseInventory(Item name, int amount)
        {
            name.InventoryAmount -= amount;
        }
    }
}