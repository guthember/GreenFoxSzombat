using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleClass
{
    class Fox : Animal
    {
        public Fox(bool isHungry, int fedTimes) 
        {
            this.isHungry = isHungry;
            this.fedTimes = fedTimes;
        }
        public override void Eat()
        {
            fedTimes++;
            if (fedTimes >= 2)
            {
                isHungry = false;
            }
        }
    }
}
