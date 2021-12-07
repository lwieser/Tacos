using System;
using System.Collections.Generic;

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
            Console.WriteLine("Liste");
        }
    }
}
