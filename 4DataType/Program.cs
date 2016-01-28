using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4DataType
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            //localVarDeclarations();
            //localVarDeclarationsDetails();
            //objectFunctionality();
            //minAndMaxValues();
            //charFunctions();
            //parseDataFromString();
            dateTimeFunctions();
            Console.ReadLine();
        }

        static void localVarDeclarations()
        {
            byte myByte = 200;      
            sbyte mySByte = -123;
            short myShort = 32000;
            int myInt = 70000;
            long myLong = 500000000L;
            float myFloat = 5.5F;
            double myDouble = 3.14;
            decimal myDecimal = 3.14M;

            Console.WriteLine("myByte={0}(0..255)\nmySByte={1}(-128..127)\nmyShort={2}(-32768..32767)\nmyInt={3}(–2,147,483,648-2,147,483,647)\nmyLong={4}\nmyFloat={5}\nmyDouble={6}\nmyDecimal={7}\n",
                               myByte, mySByte, myShort, myInt, myLong, myFloat, myDouble, myDecimal);                        
        }

        static void localVarDeclarationsDetails()
        {
            int i = new int(); //sets to default = 0
            bool b = new bool(); //sets to default = false;
            
            Console.Write("{0}\n{1}\n", i, b );
        }

        static void objectFunctionality()
        {
            Console.WriteLine("System.Object functionality:");

            Console.WriteLine("12.GetHashCode {0}", 12.GetHashCode());
            Console.WriteLine("12.Equals(25)  {0}", 12.Equals(25));
            Console.WriteLine("12.GetType     {0}", 12.GetType());
            Console.WriteLine("12.ToString    {0}", 12.ToString());
        }

        static void minAndMaxValues()
        {
            Console.WriteLine("int.MaxValue = {0}",int.MaxValue);
            Console.WriteLine("int.MinValue = {0}",int.MinValue);
            Console.WriteLine("Positive infinity = {0}",double.PositiveInfinity);
            Console.WriteLine("Epsilon = {0}", double.Epsilon);
        }

        static void charFunctions()
        {
            char myChar = 'a';
            Console.WriteLine("char.IsDigit('a'): {0}", char.IsDigit(myChar));
            Console.WriteLine("char.IsLetter('a'): {0}", char.IsLetter(myChar));
            Console.WriteLine("char.IsWhiteSpace('Hello There', 5): {0}",
            char.IsWhiteSpace("Hello There", 5));
            Console.WriteLine("char.IsWhiteSpace('Hello There', 6): {0}",
            char.IsWhiteSpace("Hello There", 6));
            Console.WriteLine("char.IsPunctuation('?'): {0}",
            char.IsPunctuation('?'));
        }

        static void parseDataFromString()
        {            
            bool b = Boolean.Parse("True");
            int i = int.Parse("34");
            
            double d=0;
            
            Console.Write("Please enter a double value:");
            String dub = Console.ReadLine();

            Console.WriteLine("TryParse of {0} is {1}", dub,  Double.TryParse(dub, out d) ? "OK" : "NOT ok");
            Console.WriteLine("b={0}\ni={1}\nd={2}\n",b,i,d);
        }

        static void dateTimeFunctions()
        {
            DateTime dt = new DateTime();
            Console.WriteLine("Default date is {0}",dt);
            
            DateTime myBirthDay = new DateTime(1981,12,15,12,33,00);            
            Console.WriteLine("Initialized date is {0}", myBirthDay);

            Console.WriteLine("Current date is {0}", DateTime.Now);
            
            TimeSpan ts = DateTime.Now-myBirthDay;            
            
            Console.WriteLine("Time span between now and my birthday is {0}y and {1}d and {2}h and {3}m",
                               (int)(ts.Days/365.25),
                               (int)(ts.Days - ((int)(ts.Days/365))*365.25),
                               ts.Hours,
                               ts.Minutes
                             );
        }        
    }
}
