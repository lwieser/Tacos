using System;
using System.Collections.Generic;
using System.Linq;

namespace Tacos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Que souhaitez-vous faire ? ");
            Console.WriteLine("1/ Liste");
            Console.WriteLine("q/ quitter");

            string key = null;

            do
            {
                key = Console.ReadLine();
                switch (key)
                {
                    case "1":
                        List();
                        break;
                }
            } while (key != "q");

        }


        public static void List()
        {
            var context = new TacosContext();
            var liste = context.Tacos.ToList();
            foreach (var l in liste)
            {
                Console.WriteLine($"{l.Id} : {l.Name}");
            }
        }
    }
}
