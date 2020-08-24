using System;
using System.Threading;

namespace Little_Buddy_Slasher
{
    static class UiService
    {
        //not yet implemented
        public static bool ConfirmChoice()
        {
            bool choice = false;
            Console.WriteLine("");
            return choice;
        }

        //accepts Y or y to return true and confirm an ingame choice
        public static bool ConfirmChoice(string inputText)
        {
            Console.WriteLine("You entered: " + inputText.ToLower() + " is this correct? [y/n] ");
            string playerInput = Console.ReadLine();
            if (playerInput == "y")
            {
                return true;
            }
            return false;
        }

        //sleeps for x amount time
        public static void PauseTimer(int time)
        {
            // override array 
            int[] pauseTime = new int[] { 0, 1, 2 };
            // real array 
            //int[] pauseTime = new int[] { 900, 1800, 3600 };
            Thread.Sleep(pauseTime[time]);
        }

        //adds specified amount of periods in sequence to terminal for loading effect
        public static void LoadingPause(int repeat)
        {
            for (int i = 0; i < repeat; i++)
            {
                PauseTimer(0);
                Console.Write(".");
            }
            PauseTimer(1);
            Console.Clear();
        }
    }
}
