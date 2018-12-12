using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor
{
    /// <summary>
    /// A 'ConcreteVisitor' class
    /// </summary>
    class IncomeVisitor : IVisitor
    {
        public void Visit(Element element)
        {
            Employee employee = element as Employee;

            // Provide 10% pay raise
            if (employee == null)
                return;
            
            employee.Income *= 1.10;
            Console.WriteLine($"{employee.GetType().Name} {employee.Name}'s new income: {employee.Income.ToString("C2", new CultureInfo("en-US"))}");           
        }
    }
}
