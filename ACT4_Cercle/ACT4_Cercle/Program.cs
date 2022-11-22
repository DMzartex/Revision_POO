using System;

namespace ACT4_Cercle 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float rayon;
            float moitieRayon;
            Cercle moncercle;
            bool continuer = true;

            while (continuer)
            {
                Console.WriteLine("Bienvenue dans ce programme sur le cercle !");
                Console.WriteLine("Taper un rayon pour votre cercle");
                rayon = float.Parse(Console.ReadLine());
                moncercle = new Cercle(rayon);
                Console.WriteLine("Le perimetre du cercle est : " + " " + moncercle.CalculePerimetre().ToString("f2"));
                Console.WriteLine("L'air du cercle est : " + " " + moncercle.CalculeAire().ToString("f2"));
                Console.WriteLine("-------------------------------------------------------------------");
                Console.WriteLine("Rayon divisé par 2 : ");
                moncercle.Rayon /= 2;
                Console.WriteLine("Le perimetre du cercle est : " + " " + moncercle.CalculePerimetre().ToString("f2"));
                Console.WriteLine("L'air du cercle est : " + " " + moncercle.CalculeAire().ToString("f2"));

                
                    Console.WriteLine("Voulez vous calculer un autre cercle ? Y/N");
                
                
                if(Console.ReadLine() == "Y")
                {
                    continuer = true;
                }
                else
                {
                   continuer = false;
                }

            }
            Console.ReadLine();
        }
    }
}