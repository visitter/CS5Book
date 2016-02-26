using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    class CarEventArgs : EventArgs
    {
        public readonly string message;
        public readonly DateTime timeStamp;
        public CarEventArgs( string message )
        {
            this.message = message;
            timeStamp = DateTime.Now;
        }
    }
    class MyEventCarClass
    {
        public delegate void CarEngineHandler(String msg);
        public event CarEngineHandler Exploded;
        public event CarEngineHandler AboutToBlow;

        public delegate void CarEngineListener(Object sender, CarEventArgs args);

        public event CarEngineListener OnStart;
        public event CarEngineListener OnStop;
        public event CarEngineListener OnRev;

        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; }

        private Boolean carIsDead;

        public void Accelerate(int delta)
        {
            // If the car is dead, fire Exploded event.
            if (carIsDead)
            {
                if (OnStop != null)
                    OnStop(this, new CarEventArgs("stopped"));

                if (Exploded != null)
                {
                    Exploded("Sorry, this car is dead...");                    
                }
                
                //annonymous method
                //Exploded = new CarEngineHandler(delegate(String msg) { Console.WriteLine(msg); });
            }
            else
            {
                CurrentSpeed += delta;
                // Almost dead?
                if (10 == MaxSpeed - CurrentSpeed
                && AboutToBlow != null)
                {
                    AboutToBlow("Careful buddy! Gonna blow!");                    
                }
                if (OnStart != null)
                    OnStart(this, new CarEventArgs("started"));

                // Still OK!
                if (CurrentSpeed >= MaxSpeed)
                    carIsDead = true;
                else
                    Console.WriteLine("CurrentSpeed = {0}", CurrentSpeed);
            }
        }
    }
}
