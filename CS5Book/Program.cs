using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS5Book
{
    class Program
    {   
        /* Variations of the main method (There must be only one Main method)
        //A main method with no return value and accepting user parameters        
        static void Main(string[] args)
        {
            //this is used for writing unicode symbols such as ®
            Console.OutputEncoding = UnicodeEncoding.UTF8;

            Console.WriteLine("##########################");
            Console.WriteLine("       Hello World!");
            Console.WriteLine("##########################");
            
            Console.WriteLine("                by Ariel\u00AE"); 
            Console.ReadLine();
            //void is threated like 0 in this case and app result will be successful
        }        
        
        //A main method with return value of type(int) and accepting user parameters
        static int Main(String[] args)
        {
            Console.WriteLine("A Main method that returns value(error code)");
            Console.WriteLine("(0 - no error)");
            Console.WriteLine("(<0 - error)");
            Console.ReadLine();
            return 0;
        }
        
        //A main method with return value of type(int) and no user parameters
        static int Main()
        {
            Console.WriteLine("A Main method that returns value(error code)");
            Console.WriteLine("(0 - no error)");
            Console.WriteLine("(<0 - error)");
            Console.ReadLine();
            return 0;
        }

        //A main method with no return value and and no user parameters
        static void Main()
        {            
            Console.WriteLine("Some text");
            Console.ReadLine();
        }
         */

        /*passing/retrieving parameters to a C# program.
        static int Main(String[] args)
        {
            if (args.Length > 0) {
                Console.WriteLine("A list with passed params:");
                for (int i = 0; i < args.Length;i++ )
                {
                    Console.WriteLine("Param {0} = {1}", i, args[i]);
                }
            }
            else
            {
                Console.WriteLine("No params passed!");
            }
            Console.ReadLine();
            return 0;
        }
        
        //getting the parameters passed using "System.Environment.GetCommandLineArgs()" without "String[] args" in Main function
        static void Main()
        {
            String[] args = System.Environment.GetCommandLineArgs();
            foreach( String arg in args ){
                Console.WriteLine("Param = "+arg);
            }
            Console.ReadLine();
        }
        */
        static void Main()
        {
            Console.WriteLine("Test");
            Console.ReadLine();
        }    
    }
}