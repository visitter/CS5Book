using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25Inheritance
{
    partial class Employee
    {
        // Field data.
        private readonly string ssn;
        private string empName;
        private int empID;
        private float currPay;
        private int age;
        
        
        //props
        public string SSN { get{return ssn;} }
        public string Name
        {
            get { return empName; }
            set
            {
                if (value.Length > 15)
                    Console.WriteLine("Invalid name length(>15)");
                else
                    empName = value;
            }
        }
        public int ID 
        { 
            get{ return empID;}
            set
            {
                if (value < 1)
                    Console.WriteLine("Invalid ID (must be>1)");
                else
                    empID = value;
            }
        }
        public float Payment
        {
            get { return currPay; }
            set
            {
                if (value < 1000)                
                    Console.WriteLine("Please, pay the guy a bit more...");                
                else
                    currPay = value;
            }
        }
        public int Age
        {
            get{ return age; }
            set{
                if (value < 18)
                    Console.WriteLine("Employee is too young to work!");
                else if (value > 65)
                    Console.WriteLine("Employee is too old for this shit!");
                else age = value;
            }
        }


        // Constructors.
        public Employee() { }
        
        public Employee(string name, int id, float pay, int age, string ssn)
        {
            Name = name;
            ID = id;
            Payment = pay;
            Age = age;
            this.ssn = ssn;
        }
        // Methods.
        public void GiveBonus(float amount)
        {
            currPay += amount;            
        }
        public void DisplayStats()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("ID: {0}", ID);
            Console.WriteLine("Pay: {0}", Payment);
            Console.WriteLine("Age = {0}", Age);
            Console.WriteLine("SSN = {0}", SSN );
            Console.WriteLine("Position = {0}", GetType().Name);
        }
    }
}
