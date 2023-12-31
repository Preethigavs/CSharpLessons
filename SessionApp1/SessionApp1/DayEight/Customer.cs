﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionApp1.DayEight
{
    [Serializable]
    internal class Customer  // classes that are not implemting ISERIALIZING Interface
    {
        private readonly double Id;
        public string Title;
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string CreditLimit { get; set; }
        public Customer(double v1)
        {
            Id = v1;
        }
        public double GetID() { return Id; }

        public override string ToString()
        {
            return $"Details: {Id} {FirstName} {MiddleName} {LastName} {CreditLimit}";
        }
    }
}
