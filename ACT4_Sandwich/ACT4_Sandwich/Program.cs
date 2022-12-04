using ACT4_Sandwich;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class ACT4_Sandwich
    {
        static void Main(string[] args)
        {
            string continu = "";
            Sandwich monSandwic= new Sandwich();

            Console.WriteLine("Bienvenu dans notre concepteur de sandwichs !");

            Console.WriteLine("Voulez vous composer un sandwich ? oui : Y et non: n'importe quelle autre touche");
            continu = Console.ReadLine();

            while(continu == "Y")
            {
               Console.WriteLine(monSandwic.composeSandwich());
               Console.WriteLine("Voulez vous composer un sandwich ? oui : Y et non: n'importe quelle autre touche");
               continu = Console.ReadLine();
            }

            Console.ReadLine();
        }
    }
}