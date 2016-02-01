using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8Interations
{
    class Program
    {
        static void Main(string[] args)
        {
            ForLoopExample();
            ForEachLoopExample();
            WhileLoopExample();
            DoWhileLoopExample();
            Console.ReadLine();
        }

        static void ForLoopExample()
        {
            // Note! "i" is only visible within the scope of the for loop.
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Number is: {0} ", i);
            }
            // "i" is not visible here.
        }

        // Iterate array items using foreach.
        static void ForEachLoopExample()
        {
            string[] carTypes = { "Ford", "BMW", "Yugo", "Honda" };
            foreach (string c in carTypes)
                Console.WriteLine(c);
            int[] myInts = { 10, 20, 30, 40 };
            foreach (int i in myInts)
                Console.WriteLine(i);
        }

        static void WhileLoopExample()
        {
            string userIsDone = "";
            // Test on a lower-class copy of the string.
            while (userIsDone.ToLower() != "yes")
            {
                Console.WriteLine("In while loop");
                Console.Write("Are you done? [yes] [no]: ");
                userIsDone = Console.ReadLine();
            }
        }

        static void DoWhileLoopExample()
        {
            string userIsDone = "";
            do
            {
                Console.WriteLine("In do/while loop");
                Console.Write("Are you done? [yes] [no]: ");
                userIsDone = Console.ReadLine();
            } while (userIsDone.ToLower() != "yes"); // Note the semicolon!
        }
    }
}
