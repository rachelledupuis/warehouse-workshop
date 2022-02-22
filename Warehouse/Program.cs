using System;

namespace Warehouse
{
    class Program
    {
        static void Main(string[] args)
        {
            Item apple = new Item("apples", 0.75, 100);
            Item banana = new Item("bananas", 0.41, 200);
            var fruits = new List<Item>()
            {
                apple,
                banana,
            };
            Warehouse produceShop = new Warehouse(fruits);
            produceShop.getInventory();
        }
    }
}
