using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SessionApp1.DaySix.Employee
{
    internal class Testemp
    {
        public static void TestA()
        {
            try
            {
                Emp.Address address = new Emp.Address(null); 
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
            Emp e1 = new Emp();
            //Inner class object
            Emp.Address add = e1.GetAddress();
            add.Address1 = "Ambattur";
            add.Address2 = "Chennai";
            Console.WriteLine($"Address1:{add.Address1}");
            Console.WriteLine($"Address2:{add.Address2}");
        }

    }
}
