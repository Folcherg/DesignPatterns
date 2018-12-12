using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{    
    internal interface IForme
    { 
        string Nom { get; }       
    }    

    internal class Rond : IForme
    {
        public string Nom => "Rond";
    }

    internal class Rectangle : IForme
    {
        public string Nom => "Rectangle";
    }
}
