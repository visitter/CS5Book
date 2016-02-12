using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29Interfaces
{
    class Program
    {
        public interface IPointy
        {
            int Points { get; }
            void sayMyName();
        }

        public abstract class Shape
        {
            public const String introMessage = "I am a {0} and I have {1} points.";
            public abstract void Draw();
        }

        public class Ellipse : Shape, IPointy
        {
            public int Points
            {
                get;
                set;
            }

            public void sayMyName()
            {
                Console.WriteLine(introMessage, GetType().Name, Points);
            }

            public override void Draw()
            {
                Console.WriteLine("   *");
                Console.WriteLine("  * *");
                Console.WriteLine(" *   *");
                Console.WriteLine("*     *");
                Console.WriteLine("*     *");
                Console.WriteLine("*     *");
                Console.WriteLine(" *   *");
                Console.WriteLine("  * *");
                Console.WriteLine("   *");
            }

            public Ellipse()
            {
                Points = Int32.MaxValue;
            }

        }

        public class Rect : Shape, IPointy
        {
            public Rect()
            {
                Points = 4;
            }
            public int Points { get; set; }
            public override void Draw()
            {                
                Console.WriteLine("************");
                Console.WriteLine("*          *");
                Console.WriteLine("*          *");
                Console.WriteLine("************");
            }
            public void sayMyName()
            {
                Console.WriteLine(introMessage, GetType().Name, 4);
            }
        }

        public class Square : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("*******");
                Console.WriteLine("*     *");
                Console.WriteLine("*     *");
                Console.WriteLine("*******");
            }
        }

        public class Hexagon : Shape, IPointy
        {
            public Hexagon()
            {
                Points = 6;
            }
            public int Points { get; set; }
            public override void Draw()
            {
                Console.WriteLine("  ***");
                Console.WriteLine(" *   *");
                Console.WriteLine("*     *");
                Console.WriteLine("*     *");
                Console.WriteLine("*     *");
                Console.WriteLine(" *   *");
                Console.WriteLine("  ***");
            }

            public void sayMyName()
            {
                Console.WriteLine(introMessage, GetType().Name, 6);
            }
        }

        public class Circle : Shape, IPointy
        {
            int myPoints;
            int IPointy.Points
            {
                get { return myPoints; }
            }
            
            public Circle()
            {
                myPoints = 100000;
            }

            void IPointy.sayMyName()
            {
                Console.WriteLine(introMessage, GetType().Name, myPoints);
            }

            public override void Draw()
            {
                Console.WriteLine("Circle");
            }
        }
        
        public interface IMyInterface
        {            
            byte MyValue { get; set; }
            void showMyValue();
        }        
        
        public class MyClass : ICloneable, IMyInterface 
        {
            public MyClass() { }
            public object Clone()
            {                
                return new MyClass();
            }
            
            public byte MyValue { get; set; }            
            public void showMyValue()
            {
               Console.WriteLine(MyValue);
            }
        }


        public class GarrageForNumbers:IEnumerable
        {
            int[] arr = new int[3]{1,2,3};
            
            public IEnumerator GetEnumerator()
            {
                return arr.GetEnumerator();
            }
            IEnumerator IEnumerable.GetEnumerator()
            {
                foreach(int number in arr)
                {
                    yield return number;
                }
            }
            public IEnumerable getMyNamedEnumerator()
            {
                foreach (int number in arr)
                {
                    yield return number;
                }
            }            
        }
        
        static void Main(string[] args)
        {
            /*
            String cStr = "Hello";
            OperatingSystem os = new OperatingSystem(PlatformID.Unix, new Version());
            MyClass myClass = new MyClass();

            CloneThis(cStr);
            CloneThis(os);
            CloneThis(myClass);
            myClass.MyValue = 9;
            myClass.showMyValue();
             * 
             */
            /*
            Shape[] arrOfShapes = { new Rect(), new Square(), new Hexagon(), new Ellipse() , new Circle()};
            foreach (Shape item in arrOfShapes)
            {
                if (item is IPointy)
                {
                    //(item as IPointy).sayMyName();
                    Console.WriteLine((item as IPointy).Points);
                    
                }else
                    Console.WriteLine("I am not IPointy ({0})",item.GetType().Name);

                //item.Draw();
            }           
            */
            GarrageForNumbers obj = new GarrageForNumbers();
            foreach (var aNumber in obj)
            {
                Console.WriteLine(aNumber);
            }            
            foreach (var aNumber in obj.getMyNamedEnumerator())
            {
                Console.WriteLine(aNumber);
            }
            
            Console.ReadLine();
        }

        static void CloneThis( ICloneable ic )
        {
            Object obj = ic.Clone();
            Console.WriteLine("Your cloning is {0} and typename is {1} ", obj, obj.GetType().Name);
        }
    }
}