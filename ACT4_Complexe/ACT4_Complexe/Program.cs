using System;

namespace ACT4_Complexe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float p1Complexe;
            float p2Complexe;
            float p1AjtComplexe;
            float p2AjtComplexe;
            string continu = "Y";
            
            Console.WriteLine("Bienvenue dans ce programme sur les complexes !");
            while(continu == "Y")
            {
                Console.WriteLine("Que vaut la partie réelle du complexe de départ ?");
                p1Complexe = float.Parse(Console.ReadLine());
                Console.WriteLine("Que vaut la partie imaginaire du complexe de départ ?");
                p2Complexe = float.Parse(Console.ReadLine());

                Complexe complexe1 = new Complexe(p1Complexe, p2Complexe);

                Console.WriteLine("Le premier complexe : " + complexe1.AfficheComplexe() + " a pour module : " + complexe1.CalculeModule().ToString("f2"));

                Console.WriteLine("Encoder un second nombre complexe : ");
                Console.WriteLine("Que vaut la partie réelle du second complexe ?");
                p1AjtComplexe = float.Parse(Console.ReadLine());
                Console.WriteLine("Que vaut la partie imaginaire du second complexe ?");
                p2AjtComplexe = float.Parse(Console.ReadLine());
                Console.WriteLine("Le second complexe est : " + $"({p1AjtComplexe.ToString("f2")}, {p2AjtComplexe.ToString("f2")})");
                complexe1.Ajout(p1AjtComplexe, p2AjtComplexe);
                Console.WriteLine("Le premier complexe devient : " + complexe1.AfficheComplexe());
                Console.WriteLine("Un autre test ? (entrer Y)");
                continu = Console.ReadLine();
            }

            Console.WriteLine("Merci et aurevoir !");
            
            Console.ReadLine();
        }
    }
}
