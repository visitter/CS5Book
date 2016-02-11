using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29Interfaces
{
    class Program
    {
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
        
        static void Main(string[] args)
        {
            String cStr = "Hello";
            OperatingSystem os = new OperatingSystem(PlatformID.Unix, new Version());
            MyClass myClass = new MyClass();

            CloneThis(cStr);
            CloneThis(os);
            CloneThis(myClass);
            myClass.MyValue = 9;
            myClass.showMyValue();
            
            Console.ReadLine();
        }

        static void CloneThis( ICloneable ic )
        {
            Object obj = ic.Clone();
            Console.WriteLine("Your cloning is {0} and typename is {1} ", obj, obj.GetType().Name);
        }
    }
}