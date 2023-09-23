using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionApp1.DayThree
{
    internal abstract class BookAbstract
    {
        public BookAbstract() {
            Console.WriteLine("Book Constructor");
        }
        public abstract void OpenBook();

    }

}
