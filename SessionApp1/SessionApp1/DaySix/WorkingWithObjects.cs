using SessionApp1.DayFour;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionApp1.DaySix
{
    internal class WorkingWithObjects
    {
        public static void TestOne()
        {
            Object objectOne = new object();
            Console.WriteLine($"ToString: {objectOne.ToString()}");
            Console.WriteLine($"HashCode: {objectOne.GetHashCode()}");
            Type typeOne = objectOne.GetType();
            Console.WriteLine($"Type: {typeOne.FullName}");

            String stringData = "WorldCup 2023";
            Console.WriteLine($"ToString: {stringData.ToString()}");
            Console.WriteLine($"HashCode: {stringData.GetHashCode()}");
            Type typeTwo = stringData.GetType();
            Console.WriteLine($"Type: {typeTwo.FullName}");
        }
        class Emp
        {
            public int ID;
            public string Name;
            public double Salary;
        }
        public static void TestTwo()
        {
            Emp empOne = new Emp();
            // empOne.ID = 100;
            empOne.Name = "Preethi";
            Emp empTwo = empOne;
            // empTwo.ID = 200;
            empTwo.Name = "Preethi";
            Emp empThree = new Emp();
            //  empThree.ID = 300;
            empThree.Name = "Preethi";
            bool flag = (empOne.Equals(empTwo)); // prints 
            Console.WriteLine(flag);
            flag = empOne.Equals(empThree);
            Console.WriteLine(flag);
            Console.WriteLine(empOne.GetHashCode()); // 2 OBJECTS MAY BE SIMILAR BUT NOT SAME
            Console.WriteLine(empTwo.GetHashCode());
            Console.WriteLine(empThree.GetHashCode());


        }
    }
        class BoxExample //doubt
        {
            List<int> noList = new List<int>();
            public void FillList(int from, int to)
            {
                int i = 0;
                for (i = from; i < to; i++)
                {
                    noList.Add(i);
                }
            }
            public List<int> GetList()
            {
                return noList;
            }
        }
        class BoxExampleA<T>
        {
            List<T> myList = new List<T>();
            public void FillList(T data)
            {
                myList.Add(data);
            }
            public List<T> GetList()
            {
                return myList;
            }

        public static void TestA()
        {
            BoxExample b1 = new BoxExample();
            b1.FillList(100, 110);
            List<int> l = b1.GetList();
            foreach (int x in l)
            {
                Console.WriteLine(x);
            }
        }
        public static void TestB()
        {
            BoxExampleA<string> b1 = new BoxExampleA<string>();
            b1.FillList("Hello");
            List<string> l = b1.GetList();
            foreach (string s in l)
                Console.WriteLine(s);

            BoxExampleA<float> b2 = new BoxExampleA<float>();
            b2.FillList(55.24f);
            List<float> flist = b2.GetList();
            foreach (float f in flist)
                Console.WriteLine(f);
        }
    }



       

    
}
