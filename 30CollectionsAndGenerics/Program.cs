using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30CollectionsAndGenerics
{
    class Program
    {
        static void Main(string[] args)
        {

            Int32 a = 5;
            Int32 b = 6;
            Console.WriteLine("a = {0}, b ={1}", a, b);
            swap( ref a, ref b);
            Console.WriteLine("a = {0}, b ={1}",a,b);
            Console.WriteLine("Уба! Уба!");
            Console.ReadLine();
            
        }

        static void swap<T>(ref T a, ref T b){
            T temp = a;
            a = b;
            b = temp;
        }
    }
}