using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
     class AbstractCover
    {
        public  void Interact(AbstractCover cover)
        {
            Console.WriteLine(this + " interacts with " + cover);
        }
    }
}
