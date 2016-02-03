using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25Inheritance
{
    class SalesPerson : Employee
    {
        public int Sales { get; set; }

        public SalesPerson(string name, int id, float pay, int age, string ssn, int sales):
            base(name,id,pay,age,ssn)
        {
            this.Sales = sales;
        }

        public new void DisplayStats()
        {
            base.DisplayStats();
            Console.WriteLine("Sales = {0}", Sales);
        }
    }
}
