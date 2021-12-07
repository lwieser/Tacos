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
            Console.WriteLine("3/ Modifier");
            Console.WriteLine("4/ Supprimer");
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
                    case "3":
                        ts.Update();
                        break;
                    case "4":
                        ts.Remove();
                        break;
                }
            } while (key != "q");

        }

    }
}
