using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class SchwepssFactory : AbstractFactory
    {
        
        public override AbstractWater CreateWater()
        {
            return new SchwepssWater();
        }

        
        public override AbstractBottle CreateBottle()
        {
           return new SchwepssBottle();
        }

     public override AbstractCover CreateCover()
        {
           return new SchwepssCover();
        }
    }
}
