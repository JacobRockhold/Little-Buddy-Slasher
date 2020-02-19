using System;
using System.Threading;

namespace Little_Buddy_Slasher
{
    class NewPlayerScene
    {
        public void StartNewPlayer()
        {
            Thread.Sleep(1200);
            Console.WriteLine("*You awaken in a dim room*");
            Thread.Sleep(1300);
            Console.WriteLine("A voice near you: Hello! Who are you?");
            Thread.Sleep(1300);
        }
    }
}
