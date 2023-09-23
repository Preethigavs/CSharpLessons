using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionApp1.DaySeven
{
    public delegate void SMSMessageHAndler(long phone, String msg);
    public delegate void EmailMessageHAndler(String emailAddress, String msg);


    internal class Bank
    {
        public int CustomerId;
        public string Accountno = string.Empty;
        public string BankName = string.Empty;
        public string Address = string.Empty;



        public Bank()
        { }

        public static void CreateAccount()
        {
            Bank bank = new Bank();
            Console.WriteLine(bank.BankName);
        }

        public static void DeleteAccount()
        {

        }

        public static void ChangePIN()
        {

        }

        public class Withdraw : Bank
        {}

    }
}
