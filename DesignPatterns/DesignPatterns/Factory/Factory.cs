using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{    
    internal abstract class Factory
    {
        internal abstract IForme FactoryMethod();
    }

    internal class FactoryRond : Factory
    {                
        internal override IForme FactoryMethod()
        {
            return new Rond();
        }
    }

    internal class FactoryRectangle : Factory
    {
        internal override IForme FactoryMethod()
        {
            return new Rectangle();
        }
    }        
}
