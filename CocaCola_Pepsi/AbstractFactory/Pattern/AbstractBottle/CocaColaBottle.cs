using System;

namespace AbstractFactory
{
    class CocaColaBottle : AbstractBottle
    {
        public override void Interact(AbstractWater water, AbstractCover cover)
        {
            Console.WriteLine(this + " interacts with " + water + cover);
        }
    }
}
