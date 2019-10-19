using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleClass
{
    class Animal
    {
        protected bool isHungry = true;
        protected int fedTimes = 0;

        public virtual void Eat()
        {
            fedTimes++;
            isHungry = false;
        }
    }
}
