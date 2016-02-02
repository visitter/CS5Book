using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17Contructors
{
    class Car
    {
        // The 'state' of the Car.
        public string carName;
        public int currSpeed;
      
        // A custom default constructor.
        public Car()
        {
            carName = "Chuck";
            currSpeed = 10;
        }
        public void printState()
        {
            Console.WriteLine("The car \"{0}\" is moving with {1} km/h", carName, currSpeed);
        }

        //defining a custom constructor
        public Car( string cN )
        {
            carName = cN;
        }

        /*
        //defining a custom constructor using "this" keyword
        public Car( string carName)
        {
            this.carName = carName;
        }
        */
        public Car( int currSpeed)
        {
            this.currSpeed = currSpeed;
        }

        //define constructor with default parameters
        public Car( string carName = "Audi", int currSpeed=1 )
        {            
            this.carName = carName;
            this.currSpeed = currSpeed;
        }
    }


    class Motorcycle
    {
        public int driverIntensity;
        public string driverName;

        public void PopAWheely()
        {
            Console.WriteLine("Yeeeeeee Haaaaaeewww!");
        }
        
        public void SetDriverName(string name)
        {
            this.driverName = name;
        }

        // Constructor chaining.
        public Motorcycle()
        {
            Console.WriteLine("In default ctor");
        }
        public Motorcycle(int intensity)
            : this(intensity, "")
        {
            Console.WriteLine("In ctor taking an int");
        }

        public Motorcycle( string riderName) : this( 0, riderName )
        {
            Console.WriteLine("In ctor taking a string");
        }

        // This is the 'master' constructor that does all the real work.
        public Motorcycle(int intensity, string name)
        {
            Console.WriteLine("In master ctor ");
            if (intensity > 10)
            {
                intensity = 10;
            }
            driverIntensity = intensity;
            driverName = name;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /*
            Car myCar = new Car();
            myCar.printState();
             */
            /*
            Car myCar = new Car("VW",20);
            myCar.printState();
            */
            Console.WriteLine("***** Fun with class Types *****\n");
            // Make a Motorcycle.
            Motorcycle c = new Motorcycle(5);
            c.SetDriverName("Tiny");
            c.PopAWheely();
            Console.WriteLine("Rider name is {0}", c.driverName);

            Console.ReadLine();
        }
    }
}
