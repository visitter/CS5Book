using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Environmentals
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowEnvironmentDetails();
        }

        static void ShowEnvironmentDetails()
        {
            foreach( DictionaryEntry de in Environment.GetEnvironmentVariables())            
            {                
                Console.WriteLine(de.Key + " = " + de.Value);
            }
            
            /*second way(using enumerator) of iterating through collection
            IDictionary id = Environment.GetEnvironmentVariables();
            IDictionaryEnumerator idn = id.GetEnumerator();

            while (idn.MoveNext())
            {
                Console.WriteLine(idn.Key+ " = "+idn.Value);            
            }
            */
            Console.ReadLine();
        }
    }
}
