using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    internal static class ProcessFactory
    {
        internal static void Definition()
        {
            Console.WriteLine("Factory:\nElle permet d'instancier des objets dont le type est dérivé d'un type abstrait ou interface. La classe exacte de l'objet n'est donc pas connue par l'appelant.\n");
        }

        internal static void Structure()
        {
            Console.WriteLine("------------           ------------");
            Console.WriteLine("| Produit  |           | Fabrique |");
            Console.WriteLine("| Générique|           | Générique|");
            Console.WriteLine("------------           ------------");
            Console.WriteLine("     ^                       ^     ");
            Console.WriteLine("------------           ------------");
            Console.WriteLine("| Produit  | instancie | Fabrique |");
            Console.WriteLine("| X        |     <-    | X        |");
            Console.WriteLine("------------           ------------");
        }

        internal static void DoProcess()
        {                       
            // Iterate over creators  and create formes
            foreach (var factory in Fatories)
            {
                Console.WriteLine($"Forme: {factory.FactoryMethod().Nom}");
            }
            
            // Wait for user
            Console.ReadKey();
        }

        private static readonly List<Factory> Fatories = new List<Factory>
        {
            new FactoryRond(),
            new FactoryRectangle()
        };
    }
}
