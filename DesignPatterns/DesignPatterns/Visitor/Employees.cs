using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor
{
    /// <summary>
    /// The 'ObjectStructure' class
    /// </summary>

    class Employees

    {
        private readonly List<Employee> _elements = new List<Employee>();

        public void Attach(Employee element)
        {
            _elements.Add(element);
        }

        public void Detach(Employee element)
        {
            _elements.Remove(element);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (Employee element in _elements)
            {
                element.Accept(visitor);
            }
        }
    }
}
