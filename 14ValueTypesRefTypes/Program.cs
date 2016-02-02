using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14ValueTypesRefTypes
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
            Console.WriteLine("X = {0}, Y = {1}", X, Y);
        }

        public MyPoint(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
    }

    class MyPointRef
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
            Console.WriteLine("X = {0}, Y = {1}", X, Y);
        }

        public MyPointRef(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
    }

    class ShapeInfo
    {
        public string infoString;
        public ShapeInfo(string info)
        {
            infoString = info;
        }
    }

    struct Rectangle
    {
        // The Rectangle structure contains a reference type member.
        public ShapeInfo rectInfo;
        public int rectTop, rectLeft, rectBottom, rectRight;
        public Rectangle(string info, int top, int left, int bottom, int right)
        {
            rectInfo = new ShapeInfo(info);
            rectTop = top; rectBottom = bottom;
            rectLeft = left; rectRight = right;
        }
        public void Display()
        {
            Console.WriteLine("String = {0}, Top = {1}, Bottom = {2}, " +
            "Left = {3}, Right = {4}",
            rectInfo.infoString, rectTop, rectBottom, rectLeft, rectRight);
        }
    }


    class Person
    {
        public string personName;
        public int personAge;
        // Constructors.
        public Person(string name, int age)
        {
            personName = name;
            personAge = age;
        }
        public Person() { }
        public void Display()
        {
            Console.WriteLine("Name: {0}, Age: {1}", personName, personAge);
        }
    }

    class Program
    {
        //Structures are System.ValueType. Their behavier is like System.Int32 local vars. They are popped off the stack after their visibility block ends.
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            //valueTypeCopying();
            //refTypeCopying();
            //copyValueTypesContainingRefType();
            
            Person p = new Person("Ivan", 34);
            p.Display();
            SendAPersonByValue(p);
            p.Display();
            SendAPersonByReference(ref p);
            p.Display();

            Console.ReadLine();
        }

        //copy by values when using structures which are value type.
        static void valueTypeCopying()
        {
            Console.WriteLine("\nCopying by value");
            MyPoint p1 = new MyPoint(10, 10);
            MyPoint p2 = p1;
            p2.increment(5);
            p1.displayXY();
            p2.displayXY();
        }

        //copy by ref when using classes(ref types) which are ref types
        static void refTypeCopying()
        {
            Console.WriteLine("\nCopying by ref");
            MyPointRef p1 = new MyPointRef(10, 10);
            MyPointRef p2 = p1;
            p2.increment(5);
            p1.displayXY();
            p2.displayXY();
        }

        static void copyValueTypesContainingRefType()
        {
            Rectangle rect1 = new Rectangle("Rect1", 10, 10, 50, 50);
            Rectangle rect2 = rect1;
            rect1.Display();
            rect2.Display();

            rect2.rectInfo.infoString = "Rect12";// changing the value to both rects because of ref typed variable

            rect1.Display();
            rect2.Display();
        }

        static void SendAPersonByValue(Person p)
        {
            // Change the age of "p"?
            p.personAge = 99;
            
            // Will the caller see this reassignment?
            p = new Person("Nikki", 99);
        }

        static void SendAPersonByReference(ref Person p)
        {
            // Change some data of "p".
            p.personAge = 555;
            // "p" is now pointing to a new object on the heap!
            p = new Person("Nikki", 999);
        }
    }
}
