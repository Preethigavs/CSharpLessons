using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace SessionApp1.DaySeven
{
    internal class ThreadDemo
    {
        public static void DoCurrentTH()
        {
            Thread t1 = Thread.CurrentThread;
            int id = t1.ManagedThreadId;
            Console.WriteLine("ThreadID=" + id);
            Console.WriteLine("IsAlive=" + t1.IsAlive);
            Console.WriteLine("Priority=" + t1.Priority);
            Console.WriteLine("ThreadState=" + t1.ThreadState);
            Console.WriteLine("CurrentCulture" + t1.CurrentCulture);
            Console.WriteLine(DateTime.Now.ToLongDateString());
            t1.CurrentCulture = new CultureInfo("fr-FR");
            Console.WriteLine("CurrentCulture" + t1.CurrentCulture);
            Console.WriteLine(DateTime.Now.ToLongDateString());
            t1.CurrentCulture = new CultureInfo("de-DE");
            Console.WriteLine("CurrentCulture" + t1.CurrentCulture);
            Console.WriteLine(DateTime.Now.ToLongDateString());
        }
        public static void DemoA()
        {
            Thread t1 = Thread.CurrentThread;
            int id = t1.ManagedThreadId;
            Console.WriteLine("MainTH ID" + id);
            ServiceA a1 = new ServiceA();
            a1.DoTaskA();
        }
        public static void DemoB()
        {
            Thread t1 = Thread.CurrentThread;
            int id = t1.ManagedThreadId;
            Console.WriteLine("MainTH ID" + id);
            ServiceA a1 = new ServiceA();
            Thread t2 = new Thread(a1.DoTaskA);
            t2.Start();
            a1.DoTaskA();
            Console.WriteLine(" ===========End of DemoB============== ");
        }
        public static void DemoB2()// parallel threads
        {
            Thread t1 = Thread.CurrentThread;
            int id = t1.ManagedThreadId;
            Console.WriteLine("MainTH ID" + id);
            ServiceA a1 = new ServiceA();
            Thread t2 = new Thread(a1.DoTaskA); //delegate
            Console.WriteLine(t2.ManagedThreadId + "T1 STATE"+ t2.ThreadState);
            t2.Start();
             //  a1.DoTaskA();
            Console.WriteLine(t2.ManagedThreadId + "State after start" + t2.ThreadState);
            Thread.Sleep(3000);
            Console.WriteLine(t2.ManagedThreadId + "t1 state after stop" + t2.ThreadState);
            Console.WriteLine(" ===========End of DemoB============== ");
        }
        public static void DemoC()  // mutlithreads
        {
            Thread t = Thread.CurrentThread;
            int id = t.ManagedThreadId;
            Console.WriteLine("MainTH ID" + id);
            ServiceA a1 = new ServiceA();
            ThreadStart ts = a1.DoTaskA ;
            Thread t1 = new Thread(ts);
            Thread t2 = new Thread(ts);
            t1.Start();
            t2.Start();
            Console.WriteLine(" ===========End of DemoB============== ");
        }
        public static void DemoD()  // mutlithreads - join
        {
            Thread t = Thread.CurrentThread;
            int id = t.ManagedThreadId;
            Console.WriteLine("MainTH ID" + id);
            ServiceA a1 = new ServiceA();
            ThreadStart ts = a1.DoTaskA;
            Thread t1 = new Thread(ts);
            Thread t2 = new Thread(ts);
            t1.Start();
            t2.Start();
            t1.Join(3000);
           // if(t1.IsAlive) t1.Abort(); thread abort is obsolute
            t2.Join(3000);
           // if (t2.IsAlive) t2.Abort(); 
            Console.WriteLine(" ===========End of DemoB============== ");
        }
    }

}
