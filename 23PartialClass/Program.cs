using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23PartialClass
{
    public partial class Person 
    {   
        public void displayMyName()
        {
            Console.WriteLine("My name is {0}.",Name);
        }

        public void sayHello()
        {
            Console.WriteLine("{0} says hello!",Name);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person() { Name = "Ivan", ID = 1 };
            person.sayHello();
            person.displayMyName();

            Console.ReadLine();
        }
    }
}