using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            //simpleArray();
            //arrayInit();
            //implicitlyTypedLocalArrays();
            //ArrayOfObjects();
            arrayMethods();
            Console.ReadLine();
        }

        static void simpleArray()
        {
            Console.WriteLine("Array creation");
            int[] arrInts = new int[3];

            Console.WriteLine("Printing Default Integers");
            foreach (int i in arrInts)
            {
                Console.WriteLine(i);
            }
            //array assignment
            arrInts[0] = 200;
            arrInts[1] = 300;
            arrInts[2] = 100;

            Console.WriteLine("Printing assigned Integers");
            foreach (int i in arrInts)
            {
                Console.WriteLine(i);
            }

            String[] arrStr = new String[4];
            Console.WriteLine("Printing Default Strings");
            foreach (String str in arrStr)
            {
                Console.WriteLine(str);
            }
        }

        static void iterateThroughArray<T>( T[] arr)
        {
            Console.WriteLine("Printing array...");
            foreach( T t in arr){
                Console.Write(t.ToString());
            }
            Console.WriteLine();
        }

        static void arrayInit()
        {
            int[] arr1 = new int[3] { 1, 2, 3 };//with all optionals "new" and "{}"
            iterateThroughArray(arr1);

            int[] arr2 = new int[]{ 4, 5, 6 };//witout size spec
            iterateThroughArray(arr2);

            int[] arr3 = { 7, 8, 9 }; //without new and size spec
            iterateThroughArray(arr3);            
        }

        static void implicitlyTypedLocalArrays()
        {
            var arr1 = new[] { 1, 2, 3 };
            iterateThroughArray(arr1);
            Console.WriteLine(arr1.GetType());

            var arr2 = new[] { true, false, true };
            iterateThroughArray(arr2);
            Console.WriteLine(arr2.GetType());

            var arr3 = new[] { "el1", "el2", "el3" };
            iterateThroughArray(arr3);
            Console.WriteLine(arr3.GetType());
        }

        static void ArrayOfObjects()
        {
            Console.WriteLine("=> Array of Objects.");
            // An array of objects can be anything at all.
            object[] myObjects = new object[4];
            myObjects[0] = 10;
            myObjects[1] = false;
            myObjects[2] = new DateTime(1969, 3, 24);
            myObjects[3] = "Form & Void";
            foreach (object obj in myObjects)
            {
                // Print the type and value for each item in array.
                Console.WriteLine("Type: {0}, Value: {1}", obj.GetType(), obj);
            }
            Console.WriteLine();
        }

        static void RectMultidimensionalArray()
        {
            Console.WriteLine("=> Rectangular multidimensional array.");
            // A rectangular MD array.
            int[,] myMatrix;
            myMatrix = new int[6, 6];
            // Populate (6 * 6) array.
            for (int i = 0; i < 6; i++)
                for (int j = 0; j < 6; j++)
                    myMatrix[i, j] = i * j;
            // Print (6 * 6) array.
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                    Console.Write(myMatrix[i, j] + "\t");
                Console.WriteLine();
            }
            Console.WriteLine();

            
        }

        static void arrayMethods()
        {
            int[] arr = { 1, 2, 3, 4 };
            iterateThroughArray(arr);

            Array.Reverse(arr);
            iterateThroughArray(arr);

            int[] arrDest = new int[4];
            arr.CopyTo(arrDest,0);
            iterateThroughArray(arrDest);

            Array.Clear(arrDest,0,4);
            iterateThroughArray(arrDest);
        }

        static void jaggerArrays()
        {
            int[][] arrJagged = new int[2][];
            for (int i = 0; i < arrJagged.Length; i++)
            {
                arrJagged[i] = new int[(i + 1) * 2];
                for (int k = 0; k < arrJagged[i].Length; k++)
                {
                    arrJagged[i][k] = k;
                }
            }

            for (int i = 0; i < arrJagged.Length; i++)
            {
                for (int j = 0; j < arrJagged[i].Length; j++)
                {
                    Console.WriteLine(arrJagged[i][j]);
                }
            }

        }

        static void rectangularArray()
        {            
           int[,] arrRect = new int[2,3]{ {1,2,3}, {4,5,6} };
            
           for (int i = 0; i < arrRect.Rank; i++)
           {                
               for (int j = 0; j < 3 ;j++)
               {
                   Console.WriteLine(arrRect[i, j]);
               }
           }           
        }
    }
}