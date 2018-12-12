using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor
{
    static class ProcessVisitor
    {
        internal static void Process()
        {
            // Setup structure
            Employees o = new Employees();
            o.Attach(new Clerk());
            o.Attach(new Director());
            o.Attach(new President());

            // Create visitor objects
            var v1 = new IncomeVisitor();
            var v2 = new VacationVisitor();

            // Structure accepting visitors
            o.Accept(v1);
            o.Accept(v2);

            // Wait for user
            Console.ReadKey();
        }
    }

    // Three employee types    
    class Clerk : Employee    
    {
        // Constructor
        public Clerk()
          : base("Hank", 25000.0, 14)
        {
        }
    }

    class Director : Employee
    {
        // Constructor
        public Director()
          : base("Elly", 35000.0, 16)
        {
        }
    }

    class President : Employee
    {
        // Constructor
        public President()
          : base("Dick", 45000.0, 21)
        {
        }
    }
}
