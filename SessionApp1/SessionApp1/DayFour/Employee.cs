using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SessionApp1.DayFour
{
    public enum City { Chennai, Banglore, Hyderabad } // list of constants
    public enum Designation { Manager, Admin , Developer }
    internal class Employee
    {
        public readonly int ID;
        public string Name  = string.Empty;
        public City  Ecity;
        public Designation JobTitle;

        public Employee(int v1)
        {
            ID =v1;
        }

        public override string ToString()
        {
            String output = String.Empty;
            output = $"Details of an employee are: {ID}\n {Name} \n{Ecity}\n {JobTitle} ";
            return output ;
        }


    }
   class TestEmployee
    {
        public static void TestOne()
        {
            Employee e1 = new Employee(344);
            e1.Name = "Jhon";
            e1.Ecity = City.Banglore;
            e1.JobTitle = Designation.Developer;
            String output = e1.ToString();
            Console.WriteLine(output);

        }
    }
}


