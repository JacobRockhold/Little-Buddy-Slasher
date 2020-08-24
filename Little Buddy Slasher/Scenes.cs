﻿using System;
using System.Threading;

namespace Little_Buddy_Slasher
{
    class Scenes : Game
    {
        public Scenes(string name)
        {
            Name = name;
        }
        public Scenes(string name, PlayerModel playerModel)
        {
            Name = name;
            PlayerModelObject = playerModel;
        }
        public string Name { get; set; }
        public PlayerModel PlayerModelObject { get; set; }
        
        public void StartNewPlayer()
        {
            //0 - short pause, 1 - medium pause 2 - long pause
            UiService.PauseTimer(1);
            Console.WriteLine("*Game start*");
            UiService.LoadingPause(11);
            Console.WriteLine("*You awaken in a dim room*");
            UiService.PauseTimer(1);
            Console.WriteLine("A voice near you: Hello! Who are you?");
            UiService.PauseTimer(0);
            PlayerModelObject.GivePlayerAName();
            UiService.PauseTimer(2);
        }

        public void LevelOneSceneOne()
        {
            Console.WriteLine($"Nice to meet you {Name}, too bad we had to meet under " +
                "these circumstances.");
            Console.ReadLine();
        }
    }
    
}
