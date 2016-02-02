using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18StaticKeyword
{
    class NonStaticData
    {
        public string name = "A name";
        public void printData()
        {
            Console.WriteLine(name);
        }
    }

    class StaticData
    {
        public static string name = "A name";
        
        public void printData()
        {
            Console.WriteLine(name);
        }

        public static void printStaticData()
        {
            Console.WriteLine(name);
        }

        static StaticData()
        {
            name = "A name in static constructor";
        }
    }

    // Static classes can only
    // contain static members!
    static class TimeUtilClass
    {
        public static void PrintTime()
        { Console.WriteLine(DateTime.Now.ToShortTimeString()); }
        public static void PrintDate()
        { Console.WriteLine(DateTime.Today.ToShortDateString()); }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //statNonStatData();
            TimeUtilClass.PrintTime();
            Console.ReadLine();
        }

        static void statNonStatData()
        {
            NonStaticData nsd = new NonStaticData();
            nsd.name = "Ivan";

            NonStaticData nsd1 = new NonStaticData();
            nsd1.name = "Smith";

            nsd.printData();
            nsd1.printData();

            System.Console.WriteLine(StaticData.name);
            StaticData sd = new StaticData();
            StaticData sd1 = new StaticData();
            StaticData.name = "A new Name";
            sd.printData();
            sd1.printData();
            StaticData.printStaticData();
        }
    }
}
