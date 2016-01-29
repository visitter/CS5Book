using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10MethodAndParameterModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine( Add(6, 7) );

            /*
            int result = 0;
            Add( 5, 6, out result);
            Console.WriteLine(result);
            */
            /*
            int a = 5, b=10;
            Console.WriteLine("Before swap -> a = {0}, b = {1}", a, b);
            swapMyInts(ref a, ref b);
            Console.WriteLine("After swap  -> a = {0}, b = {1}", a, b);
            */

            //Console.WriteLine(CalculateAverage(5.5, 6.5, 8.88));

            //optional parameters
            //EnterLogData("Ops my mistake");
            //EnterLogData("Ops... someone else's fault", "Boss");

            DisplayFancyMessage(backgroundColor: ConsoleColor.Green, textColor:ConsoleColor.DarkYellow, message:"Hello dude");

            Console.ReadLine();
        }

        // Arguments are passed by value by default.
        static int Add(int x, int y)
        {
            int ans = x + y;
            // Caller will not see these changes
            // as you are modifying a copy of the
            // original data.
            x = 10000;
            y = 88888;
            return ans;
        }

        static void Add(int x, int y, out int ans)
        {
            ans = x + y;
        }

        // Returning multiple output parameters.
        static void FillTheseValues(out int a, out string b, out bool c)
        {
            a = 9;
            b = "Enjoy your string.";
            c = true;
        }

        static void swapMyInts( ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        // Return average of "some number" of doubles.
        static double CalculateAverage(params double[] values)
        {
            Console.WriteLine("You sent me {0} doubles.", values.Length);
            double sum = 0;
            if (values.Length == 0)
                return sum;
            for (int i = 0; i < values.Length; i++)
                sum += values[i];
            return (sum / values.Length);
        }

        //optional parameters
        static void EnterLogData(string message, string owner = "Programmer")
        {
            Console.Beep();
            Console.WriteLine("Error: {0}", message);
            Console.WriteLine("Owner of Error: {0}", owner);
        }

        //named parameters
        static void DisplayFancyMessage(ConsoleColor textColor, ConsoleColor backgroundColor, string message)
        {
            // Store old colors to restore after message is printed.
            ConsoleColor oldTextColor = Console.ForegroundColor;
            ConsoleColor oldbackgroundColor = Console.BackgroundColor;
            // Set new colors and print message.
            Console.ForegroundColor = textColor;
            Console.BackgroundColor = backgroundColor;
            Console.WriteLine(message);
            // Restore previous colors.
            Console.ForegroundColor = oldTextColor;
            Console.BackgroundColor = oldbackgroundColor;
        }
    }
}
