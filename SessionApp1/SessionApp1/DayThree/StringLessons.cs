﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionApp1.DayThree
{
    internal class StringLessons
    {
        public static void DemoA()
        {
            String firstString = "Preethi";
            char[] data = { 'P', 'r', 'e', 'e', 't', 'h', 'i' };

            String secondString = new String(data);
            Console.WriteLine(firstString +" "+ secondString);
            String thirdString = String.Empty; // always initialize with the empty value with local variables. no need to intialize pf global variables
            int x = 0;
        }
        public static void DemoB()
        {
            String s1 = "Tom and jerry are good friends";
            Console.WriteLine("Length" + s1.Length);
            Char[] data = s1.ToCharArray();
            foreach (char c in data)
            {
                Console.WriteLine(c);
            }
        }
        public static void DemoC()
        {
            String s1 = "Tom and jerry are good friends";
            String[] words = s1.Split(' ');
            Console.WriteLine("Words Count" + words.Count());
            foreach (var item in words)
            {
                Console.WriteLine(item);
            }

        }
        public static void DemoD()
        {
            String firstString = "Alex volkov and Ava chen";
            String stringInUpper = firstString.ToUpper();
            Console.WriteLine("first:" + firstString);
            Console.WriteLine("stringInUpper" + stringInUpper);
            String stringInLower = firstString.ToLower();
            Console.WriteLine("firstString: " + firstString);
            Console.WriteLine("stringInlower: " + stringInLower);
        }

        public static void DemoE()
        {
            String secondString = "    abcdef    ";
            String trimmedString = secondString.Trim();
            Console.WriteLine(secondString);
            Console.WriteLine("secondString Length: " + secondString.Length);
            Console.WriteLine(trimmedString);
            Console.WriteLine("trimmedString Length: " + trimmedString.Length);
            String trimmedAtEnd = secondString.TrimEnd();
            Console.WriteLine(trimmedAtEnd);
            Console.WriteLine("trimmedAtEnd Length: " + trimmedAtEnd.Length);
            String trimmedAtStart = secondString.TrimStart();
            Console.WriteLine(trimmedAtStart);
            Console.WriteLine("trimmedAtStart Length: " + trimmedAtStart.Length);
        }
        public static void TestStringEquals()
        {
            String firstString = "Hello";
            String secondString = "Hello";
            String thirdString = "Gavs";

            bool firstResult = (firstString == secondString);
            bool secondResult = (firstString == thirdString);
            Console.WriteLine("firstString==secondString " + firstResult); // true
            Console.WriteLine("firstString==thirdString " + secondResult);// false

            firstResult = (firstString.Equals(secondString));
            secondResult = (firstString.Equals(thirdString));
            Console.WriteLine("firstString.Equals(secondString) " + firstResult); // true
            Console.WriteLine("firstString.Equals(thirdString) " + secondResult); // false
                                                                                  // 
            String fourthString = new String(new char[] { 'h', 'e', 'l', 'l', 'o' });
            firstResult = (firstString.Equals(fourthString));
            Console.WriteLine("" + firstResult);
        }

        public static void TestSubstring()
        {
            String s1 = "It looks like September is going to have more rain";
            Console.WriteLine(s1);
            Console.WriteLine("Length " + s1.Length);
            String s2 = s1.Substring(5);
            Console.WriteLine(s2);
            Console.WriteLine("s2 Length " + s2.Length);
            String s3 = s1.Substring(5, 10);
            Console.WriteLine(s3);
            Console.WriteLine("s3 Length " + s3.Length);
        }
        public static void TestCompareTo()
        {
            String s1 = "September";
            String s3 = "November";
            int x = s1.CompareTo(s3);
            Console.WriteLine("September Compare November = " + x);
            x = s1.CompareTo("Saptember");
            Console.WriteLine("September Compare Saptember = " + x);
            x = s1.CompareTo("September");
            Console.WriteLine("September Compare September = " + x);
            x = s1.CompareTo("Setpember");
            Console.WriteLine("September Compare Setpember = " + x);
            bool flag = s1.Contains("ber");
            Console.WriteLine("Contains-ber " + flag);
            String s2 = s1.Insert(3, " 2017 ");
            Console.WriteLine("Insert " + s2);
            var reversdata = s1.Reverse().ToArray();
            String s4 = new String(reversdata);
            Console.WriteLine("Reverse " + s4);
        }

        public static void SortingStrings()
        {
            //sort the names
            String[] names = new String[5];
            names[0] = "Xavier";
            names[1] = "Basker";
            names[2] = "Anandh";
            names[3] = "John";
            names[4] = "anandh";

            //String temp;
            String temp = String.Empty;
            int len = names.Length;
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < (len - 1); j++)
                {
                    if (names[j].CompareTo(names[j + 1]) > 0)
                    {
                        temp = names[j];
                        names[j] = names[j + 1];
                        names[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < len; i++)
            {
                Console.Write(names[i] + ",");
            }
        }
        public static void ModifyNumberMultipleTimes()
        {
            int begin = DateTime.Now.Millisecond;
            double x = 100;
            for (int i = 1; i < 1000000; i++)
            {
                x += i;
            }
            int after = DateTime.Now.Millisecond;
            Console.WriteLine(after - begin);
            Console.WriteLine(x);
        }
        
        public static void AssignSameStringMultipleTimes()
        {   int begin = DateTime.Now.Millisecond;
            String s1 = "Abcd";
            for (int i = 1; i < 1000000; i++)
            { 
                s1 = "Hello";

            }
            int after = DateTime.Now.Millisecond;
            Console.WriteLine(after - begin);
            Console.WriteLine(s1 + " ms");
        }
        public static void ModifyStringMultipleTimes()
        {
            int begin = DateTime.Now.Millisecond;
            String s1 = "Abcd";
            for (int i = 1; i < 1000000; i++)
            {
                s1 += i;
            }
            int after = DateTime.Now.Millisecond;
            Console.WriteLine(after - begin);
            Console.WriteLine(s1 + " ms");
        }
    }
}
