using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionApp1.DayTwo
{
    internal class Box
    {
        public static int height; // static variable
        public int width; // non-static variable
        public const String type = "Wooden"; 
        public int GetHeight() 
        { return height; }
    }
    internal class TestBox
    {
        public static void TestOne()
        {
            Box.height = 100;
            // Box.width = 200;

           
            Box firstBox = new Box();
            Box SecondBox = new Box();
            //to access a non - static variable create obj to access
            firstBox.width = 12345;
            SecondBox.width = 1000;

            Console.WriteLine($"First Box={firstBox.width}, {Box.height}"); // using static variable
            Console.WriteLine($"Second Box={SecondBox.width}, {Box.height}"); // using static variable

            Console.WriteLine($"First Box={firstBox.width}, {firstBox.GetHeight()}"); // non-static methods
            Console.WriteLine($"Second Box={SecondBox.width}, {SecondBox.GetHeight()}"); // non-static methods
           // Box.type = "Glass"; --> gives an error when we try to change THE VALUE OF CONST variable
           
            Box.height = 5555;
            Console.WriteLine($"First Box={firstBox.width}, {firstBox.GetHeight()}"); // non-static methods
            Console.WriteLine($"Second Box={SecondBox.width}, {SecondBox.GetHeight()}"); // non-static methods

        }

    }

}
