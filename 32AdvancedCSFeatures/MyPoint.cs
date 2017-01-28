using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32AdvancedCSFeatures
{
    class MyPoint
    {
        public int X { get; set; }
        public int Y { get; set; }
        public MyPoint(int x, int y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return String.Format("X = {0}, Y = {1}", X, Y);
        }
        public static MyPoint operator +(MyPoint p1, int value)
        {
            return new MyPoint(p1.X + value, p1.Y + value);
        }        
        public static MyPoint operator +(MyPoint p1, MyPoint p2)
        {
            return new MyPoint(p1.X + p2.X, p1.Y + p2.Y);
        }
    }

    struct Rect
    {
        private int lenght;
        private int height;

        public int Length{ 
            get{ return lenght; }
            set{ if(value>0) lenght=value; }
        }
        public int Height
        {
            get { return height; }
            set { if (value > 0) height = value; }
        }
       
        public Rect( int l, int h):this()
        {
            Length = l;
            Height = h;
        }
        public static implicit operator Rect(Square sq)
        {
            return new Rect(sq.Side, sq.Side);
        }
        public override string ToString()
        {
            return String.Format("I am a rectangle with h = {0} and l = {1}", Height, Length);
        }
    }

    struct Square
    {
        private int side;
        public int Side
        {
            get { return side; }
            set
            {
                if (value > 0)
                    side = value;
            }
        }
        public Square(int side):this()
        {
            Side = side;
        }
        public static explicit operator Square(Rect rect)
        {
            return new Square(rect.Height);
        }
        public override string ToString()
        {
            return String.Format("I am a square with side = {0}", Side );
        }
    }    
}
