using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26ContainmentDelegation
{
    partial class Employee
    {
        public class BenefitPackage
        {
            // Assume we have other members that represent
            // dental/health benefits, and so on.
            public double ComputePayDeduction()
            {
                return 125.0;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
