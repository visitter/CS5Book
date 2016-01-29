using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            simpleArray();
            Console.ReadLine();
        }

        static void simpleArray()
        {
            Console.WriteLine("Array creation");
            int[] arrInts = new int[3];

            Console.WriteLine("Printing Default Integers");
            foreach (int i in arrInts)
            {
                Console.WriteLine(i);
            }
            //array assignment
            arrInts[0] = 200;
            arrInts[1] = 300;
            arrInts[2] = 100;

            Console.WriteLine("Printing assigned Integers");
            foreach (int i in arrInts)
            {
                Console.WriteLine(i);
            }

            String[] arrStr = new String[4];
            Console.WriteLine("Printing Default Strings");
            foreach (String str in arrStr)
            {
                Console.WriteLine(str);
            }
        }
    }
}