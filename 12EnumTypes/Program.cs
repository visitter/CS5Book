using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12EnumTypes
{
    //A custom enumeration.
    enum EmpType
    {
        Manager, // = 0
        Grunt, // = 1
        Contractor, // = 2
        VicePresident // = 3
    }

    enum Vehicles : byte
    {
        Bicycle,
        Motorcycle,
        Car,
        Truck,
        AirPlane
    }

    enum Vehicles_1
    {
        Bicycle = 10,
        Motorcycle = 8,
        Car = 20,
        Truck = 2,
        AirPlane = 0
    }

    class Program
    {   
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            
            Console.WriteLine("discrete value is {0} and base type is {1}", (int)Vehicles.Motorcycle, Enum.GetUnderlyingType(typeof(Vehicles)) );
                        
            Vehicles_1 veh = Vehicles_1.Bicycle;
            Console.WriteLine(veh);
            Console.WriteLine("discrete value is {0} and base type is {1}", (int)Vehicles_1.Motorcycle, Enum.GetUnderlyingType(veh.GetType()));

            Console.WriteLine("\nEnum.GetNames");                       
            
            foreach( string str in Enum.GetNames(typeof(Vehicles)))
            {
                Console.WriteLine("{0}, {0:D}", str, str);
            }

            Console.WriteLine("\nEnum.GetValues");

            foreach (var str in Enum.GetValues(typeof(Vehicles)))
            {
                Console.WriteLine("{0}, {0:D}",str,str);
            }

            compareEnumValues();
            Console.ReadLine();
        }

        static void compareEnumValues()
        {
            Console.WriteLine(" Vehicles.AirPlane >  Vehicles.Car         = {0}", Vehicles.AirPlane > Vehicles.Car);
            Console.WriteLine(" Vehicles.AirPlane == Vehicles.Bicycle     = {0}", Vehicles.AirPlane == Vehicles.Bicycle);
            Console.WriteLine(" Vehicles.Truck    <  Vehicles.Motorcycle  = {0}", Vehicles.Truck < Vehicles.Motorcycle);            
        }
    }
}
