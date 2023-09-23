using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionApp1.DayFive
{
    internal class EmployeeClass
    {
            private readonly double Id;
            public string Name;
            public string FirstName { get; set; }
            public string MiddleName { get; set; }
            public string LastName { get; set; }
            public double Salary { get; set; }
            public EmployeeClass() { }
            public EmployeeClass(double v1)
            {
                Id = v1;
            }
            public double GetID()
            {
                return Id;
            }
        public static void EmpArray()
        {
            EmployeeClass[] elist = new EmployeeClass[10];
            for (int i = 0; i < 10; i++)
            {
                EmployeeClass e1 = new EmployeeClass(i);
                e1.FirstName = "Emp" + i;
                elist[i] = e1;
            }
            Console.WriteLine("No of EmployeeClassloyees " + elist.Length);
            for (int i = 0; i < 10; i++)
            {
                EmployeeClass e1 = elist[i];
                Console.WriteLine("ID=" + e1.GetID() + " Name=" + e1.FirstName);
            }
        }
    }
}
