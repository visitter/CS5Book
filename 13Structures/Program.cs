using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13Structures
{
    struct MyPoint
    {
        public int X;
        public int Y;

        public void increment(int delta)
        {
            X += delta;
            Y += delta;
        }

        public void decrement(int delta)
        {
            X -= delta;
            Y -= delta;
        }

        public void displayXY()
        {
            Console.WriteLine("X = {0}, Y = {1}", X,Y);
        }

        public MyPoint(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            //basicStruct(); 
            //basicStructWithDefaultContructorInit();
            basicStructWithCustomContructorInit();
            Console.ReadLine();
        }

        static void basicStruct()
        {
            MyPoint point;
            point.X = 10;
            point.Y = 12;
            point.displayXY();
            point.increment(10);
            point.displayXY();
        }

        static void basicStructWithDefaultContructorInit()
        {
            MyPoint point = new MyPoint(); //constructor -> no need to init the X and Y. the contructor inits them to 0            
            point.displayXY();
            point.increment(5);
            point.displayXY();
        }

        static void basicStructWithCustomContructorInit()
        {
            MyPoint point = new MyPoint(20,15); //constructor -> no need to init the X and Y. the contructor inits them to 0            
            point.displayXY();
            point.increment(15);
            point.displayXY();
        }
    }
}