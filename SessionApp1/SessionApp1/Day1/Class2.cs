using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionApp1.Day1
{
    class BaseclassA
    {
        public void fun1()
        {
            Console.Write("Base class" + " ");
        }
    }
    class Derived1 : BaseclassA
    {
        new void fun1()
        {
            Console.Write("Derived1 class" + " ");
        }
    }
    class Derived2 : Derived1
    {
        new void fun1()
        {
            Console.Write("Derived2 class" + " ");
        }
    }
}