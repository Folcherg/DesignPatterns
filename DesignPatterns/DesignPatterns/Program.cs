using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Designs Patterns:");
            Console.WriteLine("\t- (F) Factory");
            Console.WriteLine("\t- (V) Visitor");

            var key = Console.ReadKey();

            switch (key.KeyChar)
            {
                case 'f':
                case 'F':
                    // Factory
                    Factory.ProcessFactory.Definition();
                    Factory.ProcessFactory.Structure();
                    Factory.ProcessFactory.DoProcess();
                    break;
                case 'v':
                case 'V':
                    Visitor.ProcessVisitor.Process();
                    break;
            }            
        }
    }
}
