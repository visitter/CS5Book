using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("Peter", 1, 1000, 21, "123-123-1231");
            emp.DisplayStats();

            Console.WriteLine();

            SalesPerson sp = new SalesPerson("George", 2, 1100, 27, "123-123-1232",6);
            sp.DisplayStats();

            Console.WriteLine();

            Manager mr = new Manager("John", 3, 2100, 35, "123-456-7890", 10 );
            mr.DisplayStats();

            Console.ReadLine();
        }
    }
}
