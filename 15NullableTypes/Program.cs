using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int? a = null; // defining a nullable type using int?
            Nullable<int> b = 10;

            string str=null; //string is a reference type and does not need to be defined as nullable
            Console.WriteLine("The value if \"a\" is: {0}", (a.HasValue ? a.ToString() : "undefined"));
            Console.WriteLine("The value if \"a\" is: {0}", a ?? -1);
            Console.WriteLine("The value if \"b\" is: {0}", (b.HasValue ? b.ToString() : "undefined"));

            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}