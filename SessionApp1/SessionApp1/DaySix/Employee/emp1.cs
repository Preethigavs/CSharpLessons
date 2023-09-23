using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionApp1.DaySix.Employee
{
    class Emp
    {

        public int Eno = 0;
        private readonly Address address;
        public Emp() //constructor

        {
            address = new Address(this);
        }
        public Address GetAddress()
        {
            return address;
        }
        //Inner class
        public class Address //inner class
        {
            public String Address1;
            public String Address2;
            private readonly Emp e1;

            internal Address(Emp outerEmp)
            {
                if (outerEmp == null)
                    throw new NullReferenceException("Outer Emp is NULL!!!!");

                e1 = outerEmp;
            }

            public override String ToString()
            {
                return Address1 + "," + Address2 + "of" + e1.Eno;
            }
        }
    }
}
