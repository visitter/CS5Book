using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20AccessModifiers
{
    class Person
    {
        public string name = "Some Person";
    }

    class Person1
    {
        string name = "Default Person"; //default private
        public string getName() { return name; }
        public void setName(string value)
        {
            if ((value.Length > 0) && (value.Length < 20))
            {
                name = value;
            }
            else Console.WriteLine("The given parameter {0} exceeds the validation boundaries 0-20 symbols", value);
        }
    }

    class Person2
    {
        string name = "Default Person"; //default private
        double weight = 90;
        int age = 0;

        public string PersonName 
        {
            get { return name; }
            set {
                if ((value.Length > 0) && (value.Length < 20))
                {
                    name = value;                    
                }
                else Console.WriteLine("The given parameter {0} exceeds the validation boundaries 0-20 symbols", value);
            } 
        }

        //read only property;
        public double Weight { get { return weight; } }
        
        //automatic property
        public int Age { get; set; }
        public bool IsDude { get; set; }
        
    }


    class Program
    {
        static void Main(string[] args)
        {
            
            //A sample with public var
            /*
            Person person = new Person();
            person.name = "Ivan";
            Console.WriteLine(person.name);*/

            Person1 pers = new Person1();
            System.Console.WriteLine(pers.getName());
            
            Person2 pers2 = new Person2();
            
            pers2.PersonName = "qweqweqweqweqweqweqweqweqweqweqwe";
            pers2.IsDude = true;
            Console.WriteLine("Weight = {0}",pers2.Weight);
            Console.WriteLine("Is Dude: {0}", pers2.IsDude?"yes":"no");

            
            System.Console.WriteLine(pers2.PersonName);

            Console.ReadLine();
        }
    }
}