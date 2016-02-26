using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{   
    class Program
    {
        static void registeringDelegates(MyCar car)
        {
            if (car != null)
            {
                //property stlyle destroying encapsulation.
                /*
                car.EngineHandlerField = new MyCar.EngineHandler(HandleTheEngine);
                car.EngineHandlerField += HandleTheNoise; //add another function(listener)
                car.EngineHandlerField.Invoke("alabala");
                car.EngineHandlerField = new MyCar.EngineHandler(HandleThis);
                */

                //two receivers from the delegate -> multicasting delegate
                car.RegisterForEngineEvents(new MyCar.EngineHandler(HandleTheEngine));           //add delegate              
                car.RegisterForEngineEvents(HandleTheNoise);                                     //add delegate using method group conversion (no new operation)                                                         
            }
        }

        //calling methods with same singnature with a single GenericDelegate
        static void workWithGenericDelegate()
        {
            MyCar.GenericDelegate<int> genericDelegateInt = new MyCar.GenericDelegate<int>(CallHereInts);
            genericDelegateInt(1, 2, 3, 4, 5);

            MyCar.GenericDelegate<String> genericDelegateStr = new MyCar.GenericDelegate<String>(CallHereStrings);
            genericDelegateStr("test1", "test2");

            MyCar.GenericDelegate<double> genericDelegateT = new MyCar.GenericDelegate<double>(CallHereMyGeneric);
            genericDelegateT(1.2, 1.6);
        }

        static void HitTheGas(MyCar car)
        {
            if (car != null)
            {
                for (int i = 0; i < 10; i++)
                {
                    car.Accelerate(10);
                    //if (car.CurrentSpeed > 70)                    
                    //    car.RemoveEngineEvent(HandleTheNoise); //remove a receiver method from a delegate
                    
                }
            }

        }

        static void workWithAction()
        {
            //Action with NO parameters and NO(void) return value
            Action act = new Action(ActionAndFunc.DisplayPreparedMessage);
            act.Invoke();

            //Action with parameters and NO(void) return value
            Action<String, ConsoleColor, int> actParametrized = new Action<string, ConsoleColor, int>(ActionAndFunc.DisplayMessage);
            actParametrized.Invoke("Params action", ConsoleColor.Green, 3);
        }

        static void workWithFunc()
        {
            Func<String, String, int, String> func = new Func<String, String, int, String>(ActionAndFunc.hello);
            Console.WriteLine(func.Invoke("Ivan", "Zhotev", 34 ));
        }

        static void workWithEvents()
        {
            MyEventCarClass myCar = new MyEventCarClass(){ CurrentSpeed = 10, MaxSpeed = 80 };
            myCar.AboutToBlow += new MyEventCarClass.CarEngineHandler(HandleTheEngine);            
            myCar.Exploded += new MyEventCarClass.CarEngineHandler(HandleTheNoise);
            myCar.OnStart += myCar_OnStart;

            if (myCar != null)
            {
                for (int i = 0; i < 10; i++)
                {
                    myCar.Accelerate(10);
                    System.Threading.Thread.Sleep(1000);
                }
            }            
        }

        static void myCar_OnStart(object sender, CarEventArgs args)
        {
            Console.WriteLine("This car {0} engine is {1} at {2}", sender.GetType().Name, args.message, args.timeStamp.ToString());
        }
        
        //helper methods for the delegates -> these methods have been assinged to the delegates
        static void HandleTheEngine(string msg)
        {
            Console.WriteLine("Handle says: " + msg);
        }
        static void HandleThis(string msg)
        {
            Console.WriteLine("This says: " + msg);
        }
        static void HandleTheNoise(string msg)
        {
            Console.WriteLine("Noise says: " + msg);
        }

        static void CallHereStrings(params String[] ar)
        {
            Console.WriteLine("String callback received");
            foreach (String item in ar)
            {
                Console.WriteLine(item);
            }
        }
        static void CallHereInts(params int[] ar)
        {
            Console.WriteLine("Integer callback received");
            foreach (int item in ar)
            {
                Console.WriteLine(item);
            }
        }
        static void CallHereMyGeneric<T>(params T[] ar)
        {
            Console.WriteLine("Generic callback received");
            foreach (var item in ar)
            {
                Console.WriteLine(item);
            }
        }
        
        static void Main(string[] args)
        {
            MyCar car = new MyCar { CurrentSpeed = 10, MaxSpeed = 70 };

            //registeringDelegates(car);
            //HitTheGas(car);
            //workWithGenericDelegate();
            //workWithAction();
            //workWithFunc();
            workWithEvents();
            Console.ReadLine();
        }
    }
}