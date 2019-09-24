using System;

namespace NombreComplexe
{
    class Program
    {
        static void Main()
        {
            NombreComplexe nombreComplexe = new NombreComplexe(2, 3);
            
            nombreComplexe = nombreComplexe.Conjugue();
            Console.Write("Conjugue : ");
            nombreComplexe.Afficher();
            
            nombreComplexe += nombreComplexe;
            Console.Write("Somme complexe : ");
            nombreComplexe.Afficher();
            
            nombreComplexe -= 2;
            Console.Write("Différence nombre : ");
            nombreComplexe.Afficher();
            
            nombreComplexe += 2;
            Console.Write("Somme nombre : ");
            nombreComplexe.Afficher();
            
            nombreComplexe = new NombreComplexe(2, 3);
            NombreComplexe nombreComplexe2 = new NombreComplexe(4, 5);
            
            nombreComplexe2 *= nombreComplexe;
            Console.Write("Multiplication complexe : ");
            nombreComplexe2.Afficher();
            
            nombreComplexe.AuCarre();
            Console.Write("Carré : ");
            nombreComplexe.Afficher();
            
            nombreComplexe = new NombreComplexe(2, 3);
            Console.Write("Produit conjugués : ");
            Console.WriteLine(nombreComplexe.ProduitConjugues());
            
            Console.Write("Module : ");
            Console.WriteLine(nombreComplexe.Module());
            
            Console.Write("Inverse : ");
            nombreComplexe = nombreComplexe.Inverse();
            nombreComplexe.Afficher();
        }
    }
}