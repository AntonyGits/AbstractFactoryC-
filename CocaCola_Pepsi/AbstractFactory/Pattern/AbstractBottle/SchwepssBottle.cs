using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class SchwepssBottle: AbstractBottle

    {
        public override void Interact(AbstractWater water, AbstractCover cover)
        {
            Console.WriteLine(this + " interacts with " + water + cover);
        }
    }
}
