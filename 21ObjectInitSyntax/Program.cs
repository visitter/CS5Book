using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21ObjectInitSyntax
{
    public enum PointColor
    { LightBlue, BloodRed, Gold }
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public PointColor Color { get; set; }
        
        public Point(int xVal, int yVal)
        {
            X = xVal;
            Y = yVal;
        }
        public Point() { }
        public void DisplayStats()
        {
            Console.WriteLine("[{0}, {1}, {2}]", X, Y, Color);
        }

        public override string ToString()
        {
            return X.ToString() + ", " + Y.ToString();
        }
    }

    class Rectangle
    {
        /*
        Point topLeft = new Point();
        Point bottomRight = new Point();
        public Point TopLeft { get { return topLeft; } set { topLeft = value; } }
        public Point BottomRight { get { return bottomRight; } set { bottomRight = value; } }
        */
        public Point TopLeft { get; set; }
        public Point BottomRight { get; set; }

        public void DiaplyStats()
        {
            Console.WriteLine("TopLeft = {0}, BottomRight = {1}", TopLeft, BottomRight);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //objectsInit();
            initRectangle();
            Console.ReadLine();
        }


        static void initRectangle()
        {
            Rectangle rect = new Rectangle() { TopLeft = new Point(1,1), BottomRight=new Point(20,20) };
            //rect.TopLeft.X = 10;
            //rect.TopLeft.Y = 10;
            //rect.BottomRight.X = 100;
            //rect.BottomRight.Y = 100;
            rect.DiaplyStats();
        }
        static void objectsInit()
        {
            Console.WriteLine("***** Fun with Object Init Syntax *****\n");
            // Make a Point by setting each property manually.
            Point firstPoint = new Point();
            firstPoint.X = 10;
            firstPoint.Y = 10;
            firstPoint.DisplayStats();

            // Or make a Point via a custom constructor.
            Point anotherPoint = new Point(20, 20);
            anotherPoint.DisplayStats();

            // Or make a Point using object init syntax.
            Point finalPoint = new Point { Y = 20, X = 10 }; //default contructor is called implicitly
            finalPoint.DisplayStats();

            Point finalPoint1 = new Point() { X = 10, Y = 11 };//default contructor is called explicitly
            finalPoint1.DisplayStats();

            // Calling a custom constructor.
            Point pt = new Point(10, 16) { Color = PointColor.BloodRed};
            pt.DisplayStats();
        }
    }
}