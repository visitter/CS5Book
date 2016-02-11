using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28StructuredException
{
    class Radio
    {
        public void TurnOn(bool on)
        {
            if (on)
                Console.WriteLine("Jamming...");
            else
                Console.WriteLine("Quiet time...");
        }
    }

    class Car
    {
        // Constant for maximum speed.
        public const int MaxSpeed = 100;
        // Car properties.
        public int CurrentSpeed { get; set; }
        public string PetName { get; set; }
        // Is the car still operational?
        private bool carIsDead;
        // A car has-a radio.
        private Radio theMusicBox = new Radio();
        // Constructors.
        public Car() { }
        public Car(string name, int speed)
        {
            CurrentSpeed = speed;
            PetName = name;
        }
        public void CrankTunes(bool state)
        {
            // Delegate request to inner object.
            theMusicBox.TurnOn(state);
        }
        // See if Car has overheated.
        public void Accelerate(int delta)
        {
            if (carIsDead)
                Console.WriteLine("{0} is out of order...", PetName);
            else
            {
                CurrentSpeed += delta;
                if (CurrentSpeed > MaxSpeed)
                {
                    Console.WriteLine("{0} has overheated!", PetName);
                    CurrentSpeed = 0;
                    carIsDead = true;
                }
                else
                    Console.WriteLine("=> CurrentSpeed = {0}", CurrentSpeed);
            }
        }

        // See if Car has overheated.
        public void AccelerateEx(int delta)
        {
            if (carIsDead)
                Console.WriteLine("{0} is out of order...", PetName);
            else
            {
                if (delta < 0)
                {
                    throw new ArgumentOutOfRangeException("delta", "\"Delta\" can NOT be negative!");
                }
                else
                {
                    CurrentSpeed += delta;
                    if (CurrentSpeed > MaxSpeed)
                    {
                        //Console.WriteLine("{0} has overheated!", PetName);
                        CurrentSpeed = 0;
                        CarOverheatedException ex = new CarOverheatedException(String.Format("{0} has overheated", PetName),DateTime.Now);
                        ex.HelpLink = "http://www.google.com";
                        throw ex;
                    }
                    else
                        Console.WriteLine("=> CurrentSpeed = {0}", CurrentSpeed);
                }
            }
        }
    }


    public class CarOverheatedException : ApplicationException
    {
        private string messageDetails = String.Empty;
        public string CauseOfException { get; set; }
        public DateTime TimeOfException { get; set; }

        public CarOverheatedException() { }
        public CarOverheatedException( string message, DateTime time )
            :base(message)
        {
            CauseOfException = message;
            TimeOfException = time;
        }
        public CarOverheatedException(string message, Exception inner)
            : base(message, inner)
        {

        }

    }

    [Serializable]
    public class MyException : Exception
    {
        public MyException() { }
        public MyException(string message) : base(message) { }
        public MyException(string message, Exception inner) : base(message, inner) { }
        protected MyException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            //driveCar();
            //stackExcept();
            try
            {
                generalCatch();
            }catch( CarOverheatedException coe){
                Console.WriteLine(coe.InnerException.Message );
            }
            Console.ReadLine(); 
        }

        static void stackExcept(){
            driveCar();
        }

        static void driveCar()
        {
            Console.WriteLine("***** Simple Exception Example *****");
            Console.WriteLine("=> Creating a car and stepping on it!");
            Car myCar = new Car("Zippy", 20);
            myCar.CrankTunes(true);
            try
            {
                for (int i = 0; i < 10; i++)
                    myCar.AccelerateEx(10); //myCar.Accelerate(10);
            }
            catch(ArgumentOutOfRangeException aoore)
            {
                Console.WriteLine(aoore.Message);
            }
            catch (CarOverheatedException e)
            {                
                System.Reflection.ParameterInfo[] paramsInfo =  e.TargetSite.GetParameters();
                String str = "";
                foreach ( System.Reflection.ParameterInfo item in paramsInfo)
	            {
                    str += item;
	            }

                Console.WriteLine("\nException source: {0}", e.Source);
                Console.WriteLine(e.TargetSite.MemberType+" -> "+e.TargetSite.DeclaringType + "." + e.TargetSite.Name+"("+str+")");
                Console.WriteLine("\nException message: {0}", e.Message);
                Console.WriteLine("\nException stack:\n {0}", e.StackTrace);
                Console.WriteLine("\nException helpLink: {0}", e.HelpLink);              
            }
        }
        

        static void generalCatch()
        {
            Car myCar = new Car();
            try
            {                
                Console.WriteLine(@"Attempting to accelerate with ""-10""");
                myCar.AccelerateEx(1030);
            }
            catch(CarOverheatedException coe)
            {
                try
                {
                    System.IO.File.OpenText(@"C:\MyLog.txt");
                }
                catch( System.IO.FileNotFoundException fnfe){
                    throw new CarOverheatedException(coe.Message, fnfe);
                }
            }
            catch
            {
                Console.WriteLine("Opps something went wrong!");
                
            }
        }
    }
}