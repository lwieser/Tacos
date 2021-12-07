using System;
using System.Collections.Generic;
using System.Linq;

namespace Tacos
{
    public class MenuItem
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Que souhaitez-vous faire ? ");
            Console.WriteLine("1/ Liste");
            Console.WriteLine("2/ Ajouter");
            Console.WriteLine("q/ quitter");

            string key = null;
            var ts = new TacosService();
            do
            {
                key = Console.ReadLine();
                switch (key)
                {
                    case "1":
                        ts.List();
                        break;
                    case "2":
                        ts.Add();
                        break;
                }
            } while (key != "q");

        }

    }
}
