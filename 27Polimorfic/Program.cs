using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _25Inheritance;

namespace _27Polimorfic
{
    class EmployeeTest:Employee
    {
        public override void GiveBonus(float amount)
        {
            base.GiveBonus(amount*2);
        }
    }

    //you can NOT create instance of an abstact class
    abstract class Person
    {
        public enum Gender{ Male, Female };

        protected Gender gender;
        protected String name;

        public virtual void displayMyProps()
        {
            Console.WriteLine("I am {0} and I am {1}", name, gender);
        }

        public abstract void doSomething();

        public Person()
        {
            name = "Adam";
            gender = Gender.Male;
        }
    }

    class Worker:Person
    {
        public Gender WorkerGender { get { return gender; } set { gender = value; } }
        public String WorkerName 
        { 
            get { return name; } 
            set 
            { 
                if (value.Length < 15)
                    name = value;
                else
                    Console.WriteLine("Name length can't be greater than 15 symbols!");
            } 
        }

        public Worker(string name, Gender gender)
        {
            WorkerGender = gender;
            WorkerName = name;
        }
        public override void displayMyProps()
        {            
            base.displayMyProps();
        }
        public override void doSomething()
        {
            Console.WriteLine("I am working...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Worker pers = new Worker("Ivan", Person.Gender.Male);
            pers.displayMyProps();
            pers.doSomething();
            Console.ReadLine();
        }
    }
}
