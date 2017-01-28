using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _32AdvancedCSFeaturesExt;

namespace _32AdvancedCSFeatures
{
    class Program
    {        
        static void Main(string[] args)
        {
            //workWithIndexer();
            //workWithOverloadingOperators();
            //workWithCustomCasts();
            //workWithExtensions();
            //workWithAnonimousClass();
            workWithPointers();
            Console.ReadLine();
        }

        static void workWithIndexer()
        {
            MyClassWithIndexer obj = new MyClassWithIndexer();
            obj[0] = new MyPerson("Ivan");
            obj[1] = new MyPerson("Petar");
            obj[2] = new MyPerson("George");

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(obj[i]);
            }

            foreach (MyPerson item in obj)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(obj["Petar"]); ;
        }
        static void workWithOverloadingOperators()
        {
            MyPoint pt = new MyPoint(10, 10);
            MyPoint pt1 = new MyPoint(20, 30);

            MyPoint pt2 = pt + pt1;

            pt += 10;

            Console.WriteLine(pt);
            Console.WriteLine(pt1);
            Console.WriteLine(pt2);            
        }
        static void workWithCustomCasts()
        {
            Rect rc = new Rect(10, 20);
            Console.WriteLine(rc);
            
            Square sq = (Square)rc; //explicit cast
            Console.WriteLine( sq );
            
            Rect rc1 = sq; //implicit cast
            Console.WriteLine(rc1);
        }
        static void workWithExtensions()
        {
             MyExtensions.sayHello(new Square(15));
             MyExtensions.sayHello(new Rect(10,12));
        }
        static void workWithAnonimousClass()
        {
            /*
            var bicycle = new { Make = "Raleigh", Year = 1992 };
            Console.WriteLine(bicycle.Make);
            Console.WriteLine(bicycle.Year);
            */
            // Make 2 anonymous classes with identical name/value pairs.
            var firstCar = new { Color = "Bright Pink", Make = "Saab", CurrentSpeed = 55 };
            var secondCar = new { Color = "Bright Pink", Make = "Saab", CurrentSpeed = 55 };
            // Are they considered equal when using Equals()?
            if (firstCar.Equals(secondCar))
                Console.WriteLine("Same anonymous object!");
            else
                Console.WriteLine("Not the same anonymous object!");
            // Are they considered equal when using ==?
            if (firstCar == secondCar)
                Console.WriteLine("Same anonymous object!");
            else
                Console.WriteLine("Not the same anonymous object!");
            // Are these objects the same underlying type?
            if (firstCar.GetType().Name == secondCar.GetType().Name)
                Console.WriteLine("We are both the same type!");
            else
                Console.WriteLine("We are different types!");
        }
        static void workWithPointers()
        {
            int a = 5, b = 6;
            Console.WriteLine("Before swap A = {0}, B = {1}", a, b);

            unsafe
            {
                Swap(&a, &b);
            }
            Console.WriteLine("After swap A = {0}, B = {1}", a, b);
        }
   
        static unsafe void Swap(int* val1, int* val2)
        {
            int temp = *val1;
            *val1 = *val2;
            *val2 = temp;
        }
    }
}