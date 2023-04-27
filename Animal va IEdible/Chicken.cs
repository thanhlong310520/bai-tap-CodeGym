using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_va_IEdible
{
    class Chicken : Animal,Edible
    {
        public string HowtoEat()
        {
            return "chicken could be fried";
        }

        public override string MakeSound()
        {
            return "Chicken: cluck-cluck";
        }
    }
}
