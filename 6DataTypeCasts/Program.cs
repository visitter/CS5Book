using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6DataTypeCasts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            //testImplicitCast();
            //testImplicitCastOverflow(); //error overflow the short - without (cast)
            //testImplicitCastOverflow();
            //checkedKeyWord();
            uncheckedKeyWord();
            Console.ReadLine();
        }

        static void testImplicitCast()
        {
            int a = 5, b = 6;
            Console.WriteLine("The sum of {0} and {1} equals {2}", a, b, add(a, b));
        }

        static void testImplicitCastOverflow()
        {
            int a = 5, b = 33006;
            short sum = (short)add(a, b);
            Console.WriteLine("The sum of {0} and {1} equals {2}", a, b, sum);
        }

        static void checkedKeyWord()
        {
            byte a = 100;
            byte b = 30;

            try
            {
                // check the result;
                //byte c = checked((byte)(a + b));
                //Console.WriteLine(c);

                //check block with multiple operations
                checked
                {
                    byte c = (byte)(a + b);
                    byte k = (byte)(a + b + c);
                    Console.WriteLine("c = {0}, k = {1},", c, k);
                }
            }
            catch( ArithmeticException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }

        static void uncheckedKeyWord()
        {
            //stop checking for overflowing exception;
            byte a = 5;
            byte b = 255;
            unchecked
            { 
                byte c = (byte)(a + b);
                Console.WriteLine(c);
            }
        }

        static int add( int x, int y)
        {
            return x+y;
        }
    }
}