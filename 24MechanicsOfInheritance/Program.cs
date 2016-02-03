using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24MechanicsOfInheritance
{
    class Car
    {
        readonly int maxSpeed;
        int currSpeed;

        public int MaxSpeed { get { return maxSpeed; } }
        public int CurrentSpeed
        {
            get { return currSpeed; }
            set
            {
                if (value > maxSpeed)
                    currSpeed = maxSpeed;
                else
                    currSpeed = value;
            }
        }

        public Car()
        {
            Console.WriteLine("Car() ctor");
            this.maxSpeed = 120; //km/h
        }
        public Car(int maxSpeed)
        {
            Console.WriteLine("Car(Max) ctor");
            this.maxSpeed = maxSpeed;
        }
    }

    sealed class MiniVan : Car
    {
        //calling base contructor to set the max velocity in the child class
        public MiniVan(int maxSpeed)
            : base(maxSpeed)
        {

        }
    }

    class Program
    {
        
        /*
         * erro ... can not derive from sealed class
        class MiniMinivan : MiniVan
        {

        }
        */
        static void Main(string[] args)
        {
            Car car = new Car(150) { CurrentSpeed=120 };
            Console.WriteLine("This car {2} is moving with {0} km/h and its max is {1} km/h",car.CurrentSpeed, car.MaxSpeed, car.GetType().Name);

            MiniVan aVan = new MiniVan(140) { CurrentSpeed = 90 };
            Console.WriteLine("This car {2} is moving with {0} km/h and its max is {1} km/h", aVan.CurrentSpeed, aVan.MaxSpeed, aVan.GetType().Name);

            Console.ReadLine();
        }
    }
}