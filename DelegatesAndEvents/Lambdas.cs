using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    class Lambdas
    {
        public static void testLambda()
        {
            TraditionalDelegateSyntax();
            LambdaExpressionSyntax();
        }

        public static void TraditionalDelegateSyntax()
        {
            Console.WriteLine("***** Fun with Lambdas *****\n");
            // Make a list of integers.
            List<int> list = new List<int>();
            list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });
            
            // Call FindAll() using traditional delegate syntax.
            Predicate<int> callback = new Predicate<int>(IsEvenNumber);
            List<int> evenNumbers = list.FindAll(callback);
            Console.WriteLine("Here are your even numbers:");
            foreach (int evenNumber in evenNumbers)
            {
                Console.Write("{0}\t", evenNumber);
            }
            Console.WriteLine();
        }

        // Target for the Predicate<> delegate.
        static bool IsEvenNumber(int i)
        {
            // Is it an even number?
            return (i % 2) == 0;
        }

        static void LambdaExpressionSyntax()
        {
            // Make a list of integers.
            List<int> list = new List<int>();
            list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });
            // Now, use a C# lambda expression.
            List<int> evenNumbers = list.FindAll((num) => ((num % 2) == 0));
         
            Console.WriteLine("Here are your even numbers:");
            foreach (int evenNumber in evenNumbers)
            {
                Console.Write("{0}\t", evenNumber);
            }
            Console.WriteLine();
        }

        delegate string IvanLambda(int age, string name);
        //static IvanLambda myDelegate = (age, name) => (age > 21 ? "greater" : "not greater");
        static IvanLambda myDelegate = (age, name) => 
        {
            return age > 21 ? "greater" : "not greater";
        };
        public static void testAgeCompareLambda(string name, int age)
        {            
            String isPersonBig = myDelegate(age,name);
            Console.WriteLine("The pesrson {1} is {0} than 21", isPersonBig, name );
        }
    }
}
