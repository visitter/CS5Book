using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16Encapsulation
{
    class Car
    {
        public string carName;
        public int currSpeed;

        public void printState()
        {
            Console.WriteLine("The car \"{0}\" is moving with {1} km/h",carName,currSpeed);
        }

        public void speedUp( byte delta)
        {
            currSpeed += delta;
        }
    }
}
