using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionApp1.DayThree
{
    internal interface MessageService
    {
        void SendMessage(string message);
        void SendAudioMessage(string message);
        void SendVideoMessage(string message);
        void ReceiveMessage();
        void DeleteMessage();
    }
    internal interface Payments
    {
        void MakePayment(float amount); // no body can be created in the interface, 
    }
    internal class WhatsApp : MessageService , Payments
    {
        public void DeleteMessage()
        {
            Console.WriteLine("Matched Not Implemented");
        }
        public void ReceiveMessage()
        {
            Console.WriteLine("Matched Not Implemented");
        }
        public void SendAudioMessage(string message)
        {
            Console.WriteLine("Matched Not Implemented");

        }
        public void SendMessage(string message)
        {
            Console.WriteLine("Matched Not Implemented");

        }
       // public abstract void SendVedioMessage(string message);
        public void SendVideoMessage(string message)
        {
            Console.WriteLine("Matched Not Implemented");
        }

        public void MakePayment(float amount)
        {
            Console.WriteLine($"Paid Amount {amount}");
        }
    }

   public class MessageTester
    {
        public static void TestOne()
        {
            MessageService messageService = new WhatsApp();
            messageService.SendMessage("Hello");
            messageService.ReceiveMessage();

        }
    }
}
