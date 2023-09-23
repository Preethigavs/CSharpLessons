using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionApp1.DayThree
{
    internal abstract class Vehicle // it is not complusory to have abstract method in abstract class
    {
        public Vehicle() 
        {
            Console.WriteLine("Vehicle Constructor");
        }   
        
        public void Start()
        {
            Console.WriteLine("Vehicle Started");
        }
    }
    internal class Car : Vehicle
    {
        public Car()
        {
            Console.WriteLine("Car Constructor");
        }
    }
    class VechileTester
    {
        public static void TestOne()
        {
         //   Vechile tester = new Vechile(); // cannot be done canot create new objects
         Vehicle tester = new Car();
            tester.Start();
        }

    }
}
