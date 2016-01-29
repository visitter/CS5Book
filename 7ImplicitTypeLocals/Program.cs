using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7ImplicitTypeLocals
{
    class Program
    {
        static void Main(string[] args)
        {
            //implicitTypedLocalVars();
            LinqQueryOverInts();
            Console.ReadLine();
        }

        static void implicitTypedLocalVars()
        {
            var i = 0;
            var b = true;
            var s = "string";
            //var a = 0, c = "string1"; //error no multiple declarators

            Console.WriteLine(i.GetType());
            Console.WriteLine(b.GetType());
            Console.WriteLine(s.GetType());            
        }

        static void LinqQueryOverInts()
        {
            int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };
            // LINQ query!
            var subset = from i in numbers where i < 10 select i;
            Console.Write("Values in subset: ");
            foreach (var i in subset)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
            // Hmm...what type is subset?
            Console.WriteLine("subset is a: {0}", subset.GetType().Name);
            Console.WriteLine("subset is defined in: {0}", subset.GetType().Namespace);
        }
    }
}
