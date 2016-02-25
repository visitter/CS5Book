using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    class MyCar
    {
        public delegate void EngineHandler(string msg);
        public delegate void GenericDelegate<T>(params T[] ar);

        private Boolean carIsDead;
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; }
        public GenericDelegate<int> genericDelegate;


        private EngineHandler engHandle;

        //property style
        public EngineHandler EngineHandlerField
        {
            get { return engHandle; }
            set
            {
                if (engHandle == null)
                {
                    engHandle = value;
                }
                else
                {
                    engHandle = (EngineHandler)Delegate.Combine(engHandle, new MyCar.EngineHandler(value));
                    foreach (var item in engHandle.GetInvocationList())
                    {
                        Console.WriteLine(item.Method);
                    }
                }
                //or
                /*
                if (value != null)
                {
                    engHandle += value;
                }
                */
            }
        }
        public void RemoveEngineEvent(EngineHandler value)
        {
            if (value != null)
            {
                engHandle -= value;
            }
        }
        //register with function
        public void RegisterForEngineEvents(EngineHandler value)
        {
            if (value != null)
            {
                engHandle += value;
            }
        }

        public void Accelerate(int delta)
        {
            // If this car is "dead," send dead message.
            if (carIsDead)
            {
                if (engHandle != null)
                    engHandle("Sorry, this car is dead...");
            }
            else
            {
                CurrentSpeed += delta;
                // Is this car "almost dead"?
                if (10 == (MaxSpeed - CurrentSpeed))
                {
                    if (engHandle != null)
                        engHandle("Careful buddy! Gonna blow!");
                    if (genericDelegate != null)
                        genericDelegate(1, 2, 3, 4, 5);
                }
            }
            if (CurrentSpeed >= MaxSpeed)
                carIsDead = true;
            else
                Console.WriteLine("CurrentSpeed = {0}", CurrentSpeed);
        }
    }
}
