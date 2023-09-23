using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionApp1.DayThree
{
    internal class MediaContent //Polymorphism
    {
        public virtual void StartPlayingContent()
        {
            Console.WriteLine("Start");
        }
        public virtual void StopPlayingContent()
        {
            Console.WriteLine("Stop");
        }
        public virtual void PausePlayingContent()
        {
            Console.WriteLine("Pause");
        }
        public virtual void ContinuePayingContent()
        {
            Console.WriteLine("Continue");
        }
        public override string ToString()
        {
            Console.WriteLine("Media ToString");
            return "OTT";
        }

    }

    internal class AudioContent : MediaContent
    {
        /*public override void StartPlayingContent() - can't override or parent should permit to override
        {
            Console.WriteLine("Start");
        }*/

        /* public override void StartPlayingContent() // use virtual method - to permit parent to override the child
         {
             Console.WriteLine("Start");
         }*/
        public override sealed void StartPlayingContent() // to stop being inherited, use sealed so that next generation cannot be inherited
        {
            Console.WriteLine("Start from AudioContent");
        }
    }
    internal class VideoContent : AudioContent  // multilevel inheritance
    {

        internal class MediaTester
        {
            public static void TestOne()
            {

            }
        }
    }
}
