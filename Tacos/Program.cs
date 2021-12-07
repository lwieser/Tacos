using System;
using System.Collections.Generic;
using System.Linq;

namespace Tacos
{
    class Program
    {
        static void Main(string[] args)
        {
            var ts = new TacosService();
            var items = new List<MenuItem>()
            {
                new MenuItem("1", "Liste", ts.List),
                new MenuItem("2", "Ajouter", ts.Add),
                new MenuItem("3", "Modifier", ts.Update),
                new MenuItem("4", "Supprimer", ts.Remove),
            };
            Console.WriteLine("Que souhaitez-vous faire ? ");

            foreach (var menuItem in items)
            {
                Console.WriteLine($"{menuItem.Key}/ {menuItem.Description}");
            }

            string key = null;
            do
            {
                key = Console.ReadLine();
                var item = items.FirstOrDefault(x => x.Key == key);
                if (item != null)
                {
                    item.Function();
                }
            } while (key != "q");
        }

    }
}
