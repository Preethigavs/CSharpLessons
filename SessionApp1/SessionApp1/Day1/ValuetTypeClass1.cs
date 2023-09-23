using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionApp1.Day1
{
    internal class ValuetTypeClass1
    {
        public static void TestMethod1() {
            Console.WriteLine(int.MaxValue);
            long l1 = int.MaxValue;
            Console.WriteLine(l1);
            bool flag = true;
            Console.WriteLine("hkkk" +bool.TrueString);
            byte b = 90;
            Console.WriteLine(byte.MaxValue);
        }

        internal static void TestMethod2()
        { 
            Console.WriteLine("test"); 
        }
    }
}
