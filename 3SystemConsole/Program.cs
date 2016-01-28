using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3SystemConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            //printConsoleSettings();
            //getUserData();
            //formatNumbers();
            formatMyInfo("Ivan", 1.7934);
            Console.ReadLine();
            
        }      

        static void printConsoleSettings()
        {  
            Console.WriteLine(" Console settings:");
            
            Console.WriteLine(" Title               : {0}", Console.Title);
            Console.WriteLine(" BackgroundColor     : {0}", Console.BackgroundColor);
            Console.WriteLine(" ForegroundColor     : {0}", Console.ForegroundColor);
            Console.WriteLine(" CursorSize          : {0}", Console.CursorSize);
            Console.WriteLine(" CursorVisible       : {0}", Console.CursorVisible);
            Console.WriteLine(" KeyAvailable        : {0}", Console.KeyAvailable);
            Console.WriteLine(" BufferHeight        : {0}", Console.BufferHeight);
            Console.WriteLine(" BufferWidth         : {0}", Console.BufferWidth);
            Console.WriteLine(" WindowHeight        : {0}", Console.WindowHeight);
            Console.WriteLine(" WindowWidth         : {0}", Console.WindowWidth);
            Console.WriteLine(" WindowLeft          : {0}", Console.WindowLeft);
            Console.WriteLine(" LargestWindowHeight : {0}", Console.LargestWindowHeight);
            Console.WriteLine(" LargestWindowWidth  : {0}", Console.LargestWindowWidth);
            Console.WriteLine(" OutputEncoding      : {0}", Console.OutputEncoding.EncodingName);
            Console.WriteLine(" InputEncoding       : {0}", Console.InputEncoding.EncodingName);
            Console.Beep();
            
            /*
            //Another way to get the properties (using reflection)
            foreach( System.Reflection.PropertyInfo prop in typeof(Console).GetProperties()){
                Console.WriteLine("{0} : {1}", prop.Name, prop.GetValue(prop.Name));
            }
             */
        }

        static void getUserData()
        {
            Console.Write("What's your name? ");
            String userName = Console.ReadLine();
            Console.Write("What's your age? ");
            String userAge = Console.ReadLine();

            Console.WriteLine("Thank you!");
            Console.WriteLine("Here is your input: \nName: {0}\nAge: {1}",userName,userAge);
        }

        //formatting numbers with Console.WriteLine
        static void formatNumbers()
        {
            Console.WriteLine("Number with \"c-currency\"       formatter {0:c}", 12345.6789); //currency
            Console.WriteLine("Number with \"d-decimal\"        formatter {0:d9}", 12345); //decimal
            Console.WriteLine("Number with \"f-floating point\" formatter {0:f3}", 12345.6789); //floating point
            Console.WriteLine("Number with \"e-exponential\"    formatter {0:e3}", 12345.6789); //exponential
            Console.WriteLine("Number with \"n-number\"         formatter {0:n}", 12345.6789); //number
            Console.WriteLine("Number with \"x-hex\"            formatter {0:x}", 12345); //hex
        }


        //formatting data using String.Format
        static void formatMyInfo(String myName, Double height)
        {
            Console.WriteLine(String.Format("My name is {0} \nMy height is {1:n3}", myName, height));            
        }
    }
}
