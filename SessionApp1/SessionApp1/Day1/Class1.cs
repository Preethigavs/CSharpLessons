using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionApp1.Day1
{
    class Baseclass
    {
        public Baseclass() {
            Console.WriteLine("Parent");
        }
        public virtual void Fun()
        {
            Console.WriteLine("Hi" + " ");
        }
        //public virtual void Fun(int i)
        //{
        //    Console.Write("Hello" + " ");
        //}
    }
    class Derived : Baseclass
    {
        public Derived() {
            Console.WriteLine("Child");
        }
        public override void Fun()
        {
            Console.Write("Bye" + " ");
        }
        public new void Fun(int i)
        {
            Console.Write("Derived " + " Fun i=" + i);
        }
    }
  


}
