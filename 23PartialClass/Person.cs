using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23PartialClass
{
   public partial class Person
    {
       //datafields
       string name;
       int id;

       public string Name
       {
           get { return name; }
           set
           {
               if (value.Length <= 10)
               {
                   name = value;
               }
               else
               {
                   Console.WriteLine("Name lenght more than 10 symbols!");
               }
           }
       }

       public int ID
       {
           get { return id; }
           set
           {
               if ((value > Int32.MinValue) && (value < Int32.MaxValue))
               {
                   id = value;
               }
               else
               {
                   Console.WriteLine("ID out of bounds {0}-{1}", Int32.MinValue, Int32.MaxValue);
               }
           }
       }
    }
}
