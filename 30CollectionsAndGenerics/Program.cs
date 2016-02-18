using System;
using System.Collections;
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
            showMyArrayList();
        }

        static void showMyArrayList()
        {
            ArrayList arrList = new ArrayList();
            arrList.AddRange(new String[] { "1", "2", "3" });
            Console.WriteLine("The count of the list is {0}", arrList.Count );

            ArrayList arrInts = new ArrayList();
            arrInts.AddRange(new int[] { 1, 2, 3, 4 });

            arrList.Add("4");
            Console.WriteLine("The count of the list is {0}", arrList.Count);

            Console.WriteLine("Listing the items in the list");
            foreach (var item in arrList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Listing the items in the Ints");
            foreach (var item in arrInts)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}