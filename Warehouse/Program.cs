using System;

namespace Warehouse
{
    class Program
    {
        static void Main(string[] args)
        {
            Item apple = new Item("apple", 0.75, 100);
            Item banana = new Item("banana", 0.41, 200);
            var fruits = new List<Item>()
            {
                apple,
                banana,
            };
            Warehouse produceShop = new Warehouse(fruits);
            Console.WriteLine(fruits);
        }
    }
}
