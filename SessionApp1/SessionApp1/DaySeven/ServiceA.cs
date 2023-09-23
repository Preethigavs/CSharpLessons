using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionApp1.DaySeven
{
    internal class ServiceA
    {
        public void DoTaskA()
        {
            int x = 0;
            Monitor.Enter(this);
            Thread t1 = Thread.CurrentThread;
            int id = t1.ManagedThreadId;
            Console.Write("Inside DoTaskA");
            Console.WriteLine("\t Thread ID: " +id);
            // int x =0;
            try
            {
                for (int icount = 0; icount <= 5; icount++)
                {
                    x += icount;//each thread copy of the x
                    Console.WriteLine("\t ID="+ id + " "+ "X=" + x + " "  + "icount= " + icount); // doubt
                    Thread.Sleep(1000);
                }
            }
            finally
            {
                Monitor.Exit(this);
            }




        }



        }
    }
