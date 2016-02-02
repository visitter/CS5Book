using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            testMyCar();
            Console.ReadLine();
        }

        static void testMyCar()
        {
            Car myCar = new Car();
            myCar.carName = "Volvo";
            myCar.currSpeed = 10;

            for (int i = 0; i < 10; i++ )
            {
                myCar.speedUp(10);
                myCar.printState();
            }
            
        }
    }
}