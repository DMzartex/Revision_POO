using ACT4_Bank;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class ACT4_Bank
    {
        static void Main(string[] args)
        {
            string name;
            double somme;
            double montant;
            string verser;

            Console.WriteLine("Bienvenue dans notre gestionnaire de porte monnaie !");
            Console.WriteLine("Quel est votre Nom ?");
            name = Console.ReadLine();
            Console.WriteLine("Tapez une somme d'argent en euros.");
            somme = double.Parse(Console.ReadLine());
            Bank compteUn = new Bank(name, somme);
            Console.WriteLine("Quel est votre Nom ?");
            name = Console.ReadLine();
            Console.WriteLine("Tapez une somme d'argent en euros.");
            somme = double.Parse(Console.ReadLine());
            Bank compteDeux = new Bank(name, somme);
            Console.WriteLine(compteUn.afficheSold());
            Console.WriteLine(compteDeux.afficheSold());

            Console.WriteLine(compteUn.Name + " combien voulez vous donner à " + compteDeux.Name);
            montant = double.Parse(Console.ReadLine());
            compteUn.retrait(montant);
            compteDeux.ajout(montant);
            Console.WriteLine(compteUn.afficheSold());
            Console.WriteLine(compteDeux.afficheSold());
           
            


            Console.WriteLine(compteDeux.Name + " combien voulez vous donner à " + compteUn.Name);
            montant = double.Parse(Console.ReadLine());
            compteDeux.retrait(montant);
            compteUn.ajout(montant);
            Console.WriteLine(compteUn.afficheSold());
            Console.WriteLine(compteDeux.afficheSold());


            Console.WriteLine("Voulez vous ajouter de l'argent au porte monnaie de Y/N " + compteUn.Name);
            verser = Console.ReadLine();

            if(verser == "Y")
            {
                Console.WriteLine("Combien voulez vous ajouter ?");
                Console.WriteLine("Tapez une somme d'argent.");
                montant = double.Parse(Console.ReadLine());
                compteDeux.retrait(montant);
                compteUn.ajout(montant);
                Console.WriteLine(compteUn.afficheSold());
                Console.WriteLine(compteDeux.afficheSold());
            }

            Console.ReadLine();




        }
    }
}