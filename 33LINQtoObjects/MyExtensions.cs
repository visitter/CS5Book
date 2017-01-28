using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33LINQtoObjectsExt
{
    static class MyExtensions
    {
        public static bool Contains(this string obj, string x)
        {
            return obj.Contains(x);
        }
    }
}
