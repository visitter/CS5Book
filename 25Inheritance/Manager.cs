using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25Inheritance
{
    public class Manager:Employee
    {
        public int StockOptions { get; set; }

        public Manager(string name, int id, float pay, int age, string ssn, int stocks):
            base(name,id,pay,age,ssn)
        {
            StockOptions = stocks;
        }

        public new void DisplayStats()
        {            
            base.DisplayStats();
            Console.WriteLine("Stocks = {0}",StockOptions);
        }
    }
}
