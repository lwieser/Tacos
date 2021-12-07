using System;
using System.Linq;

namespace Tacos
{
    class Program
    {
        static void Main(string[] args)
        {
            var items = MenuItemFactory.GetItems();
            foreach (var menuItem in items)
            {
                Console.WriteLine($"{menuItem.Key}/ {menuItem.Description}");
            }

            string key;
            do
            {
                Console.WriteLine("Que souhaitez-vous faire ? ");
                key = Console.ReadLine();
                items.FirstOrDefault(x => x.Key == key)?.Function();
            } while (key != "q");
        }

    }
}
