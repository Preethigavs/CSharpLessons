using SessionApp1.DaySix.Employee;
using SessionApp1.DayThree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SessionApp1.DaySix.Employee.Emp;
using static System.Net.Mime.MediaTypeNames;

//Test - Create a class called Car
//The car has a registration no , model, fuelType, Wheels[4] and 1 Engine

//The FuelType must be an Enum 
//Wheel , and Engine must be INNER Class

namespace SessionApp1.DaySix.CarClass
{
    public enum FuelType { Petrol, Deisel, Gas } // list of constants

    internal class CarClass //outer class
    {
        public int RegistrationNo;
        public string Model ;
        public FuelType FuelType;
        private readonly Wheel wheel;
        private readonly Engine engine;

        public Wheel GetCarWheel()
        {
            return wheel;
        }
        public Engine GetCarEngine()
        {
            return engine;
        }
        public class Wheel //inner class
        {
            public String wheelCar;
        }
        public class Engine //inner class
        {
            public String engineCar;
        }





    }
}
