using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21ConstantDataFields
{
    class MyMath
    {
        //constant fields if a class a implicitly STATIC. Assigned once cannot be changed anymore.
        public const double PI = 3.14;

        //readonly field can is a like constant but can be assigned at runtime. Assigned once cannot be changed anymore. It is NOT STATIC
        public readonly double inch = 2.54;

        public MyMath()
        {
            //PI = 4; //Error
            inch = 2.55; //OK can be assigned only in the constructor
        }

        public void tryToAssign()
        {
            //inch = 4.5;//ERROR -> can be assigned only in the constructor
        }

        public static readonly double PI1 = 3.14;
                
        static MyMath()
        {
            PI1 = 3.15;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MyMath.PI = {0}", MyMath.PI);

            MyMath math = new MyMath();            
            Console.WriteLine("math.inch = {0}",math.inch);

            Console.WriteLine(MyMath.PI1);
                
            Console.ReadLine();
        }
    }
}
