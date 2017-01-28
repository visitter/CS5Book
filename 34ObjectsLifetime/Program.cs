using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34ObjectsLifetime
{
    class Program
    {
        class MyWrapper
        {
            public String Name { get; set; }
            public MyWrapper(String name)
            {
                Name = name;
            }
            ~MyWrapper()
            {
                Console.WriteLine("In finallize "+this.Name);
            }
        }

        class MyWrapperDispose:IDisposable
        {
            public String Name { get; set; }
            public MyWrapperDispose(String name)
            {
                Name = name;
            }
            ~MyWrapperDispose()
            {
                Console.WriteLine("In finallize " + this.Name);
            }
        
            public void Dispose()
            {
                Console.WriteLine("In Dispose "+this.Name);
                GC.SuppressFinalize(this);
            }
        }


        struct MyWrapperStruct:IDisposable
        {
            public String Name;
            public MyWrapperStruct( String Name )
            {
                this.Name = Name;
            }
            public void Dispose()
            {
                Console.WriteLine("In Dispose "+this.Name);
            }
        }
        
        static void Main(string[] args)
        {
            TestMyWrapper();
            TestMyWrapperDispose();
            TestMyWrapperStruct();
            TestUsingWrappers();

            GC.Collect();
            
            Console.ReadLine();
        }
        
        static void TestMyWrapper()
        {
            MyWrapper obj = new MyWrapper("Ivan");
            Console.WriteLine(obj.Name);        
        }
        static void TestMyWrapperDispose()
        {
            MyWrapperDispose obj = new MyWrapperDispose("Goro");
            Console.WriteLine(obj.Name);
            obj.Dispose();
        }
        static void TestMyWrapperStruct()
        {
            MyWrapperStruct obj = new MyWrapperStruct("Pesho");
            Console.WriteLine(obj.Name);
            obj.Dispose();
        }
        static void TestUsingWrappers()
        {
            /* must implement IDisposable
            using (MyWrapper mw = new MyWrapper("using Ivan"))
            {

            }
            */
            using (MyWrapperDispose mw = new MyWrapperDispose("using Ivan"))
            {
                Console.WriteLine(mw.Name);
            }
            using (MyWrapperStruct mw = new MyWrapperStruct("using Pesho"))
            {
                Console.WriteLine(mw.Name);
            }
        }
    }
}
