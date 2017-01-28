using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32AdvancedCSFeaturesExt
{    
    static class MyExtensions
    {
        public static void sayHello(this Object obj)
        {
            Console.WriteLine("Hello from {0}", obj);
        }        
    }
}
