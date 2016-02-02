using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19PillarsOfOPP
{
    class Radio
    {
        public void Power(bool turnOn)
        {
            Console.WriteLine("Radio on: {0}", turnOn);
        }
    }

    class Car
    {
        // Car 'has-a' Radio.
        private Radio myRadio = new Radio();
        public void TurnOnRadio(bool onOff)
        {
            // Delegate call to inner object.
            myRadio.Power(onOff);
        }
    }

    class Shape
    {
        public string name = "Shape";        
        public virtual void Draw()
        {
            Console.WriteLine("Draw shape");
        }
    }

    class Hexagon:Shape
    {
        public Hexagon()
        {
            name = " Hexagon";
        }
        public override void Draw()
        {
            Console.WriteLine("Draw hexagon");
        }
    }

    class Circle : Shape
    {
        public Circle()
        {
            name = " Circle";
        }
        public override void Draw()
        {
            Console.WriteLine("Draw circle");
        }
    }

   
    
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Car myCar = new Car();
            myCar.TurnOnRadio(true);
            */
            myShapes();
            Console.ReadLine();
        }

        static void myShapes()
        {
            Shape[] myShapes = new Shape[4];
            myShapes[0] = new Hexagon();
            myShapes[1] = new Circle();
            myShapes[2] = new Hexagon();
            myShapes[3] = new Shape();
            foreach (Shape s in myShapes)
            {
                // Use the polymorphic interface!
                s.Draw();
            }            
        }
    }
}
