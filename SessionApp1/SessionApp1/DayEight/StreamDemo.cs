using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionApp1.DayEight
{
    internal class StreamDemo
    {
        public static void TestOne()
        {
            char ch = ' ';
            Console.WriteLine("Press a key followed by enter: "); // reads only one char
            // console.read() - input stream ; console.write()  - output stream
           while(ch != 'q')
            {
                ch = (char)Console.Read();
                Console.WriteLine("Your key is" + ch);
            }
        }
        public static void TestTwo()
        {
         
            Console.Out.WriteLine("Enter a sentence:  "); 
                                                                  
            string? str  =  Console.ReadLine();
            Console.Out.WriteLine(" " + str);
        }
        public static void TestNullableType()
        {
            int? x  =0;
            x = null;
            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            }
            else
            { Console.WriteLine(x.GetValueOrDefault()); }

        }
    }
}
