using SessionApp1.DaySix.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionApp1.DaySix.CarClass
{
    internal class TestCar
    {
        public static void TestA()
        {
            try
            {
                CarClass.Wheel CarWheel = new CarClass.Wheel();
                CarClass.Engine CarEngine = new CarClass.Engine();

            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
            CarClass e1 = new CarClass();
            //Inner class object
            CarClass.Wheel wheels = e1.GetCarWheel();
            CarClass.Engine engines = e1.GetCarEngine();

            wheels.wheelCar = "wheel1";
            engines.engineCar = "engine1";
            Console.WriteLine($"CarWheel:{wheels.wheelCar}");
            Console.WriteLine($"CarEngine:{engines.engineCar}");
        }
    }
}
