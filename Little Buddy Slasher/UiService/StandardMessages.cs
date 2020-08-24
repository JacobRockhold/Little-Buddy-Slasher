using System;

namespace Little_Buddy_Slasher
{
    public class StandardMessages
    {
        public static void ErrorOutput(string e)
        {
            Console.WriteLine($"This bad thing happened - \" {e} \" - please try again:");
            Console.ReadLine();
        }
        public static void InputServiceSelectError()
        {
            Console.WriteLine("For some reason UiService.InputServiceSelect has hit the default switch.");
            Console.ReadLine();
        }
        public static void SceneSelectionError()
        {
            Console.WriteLine("For some reason Scenes.SceneSelection has hit the default switch.");
            Console.ReadLine();
        }
        public static void UpdatePlayerStateError()
        {
            Console.WriteLine("For some reason Player.UpdatePlayerState has hit the default switch.");
            Console.ReadLine();
        }
    }
}
