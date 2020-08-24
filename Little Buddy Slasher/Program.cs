using System;

namespace Little_Buddy_Slasher
{
    class Program
    {
        
        
        public static void Main(string[] args)
        {
            try
            {
                Start();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }            
        }

        public static void Start()
        {
            //PlayerModel playerModel = new PlayerModel();
            //Player player = new Player(playerModel);
            Scenes scenes = new Scenes(Game.playerModel.ReturnPlayerName(), Game.playerModel);
            Encounters encounters = new Encounters(Game.playerModel.ReturnPlayerName(), Game.playerModel, scenes);
            Game.player.CreatePlayer();
            scenes.StartNewPlayer();       

            string[] levelNames = new string[] { "LevelOne", "LevelTwo",
                "LevelThree", "LevelFour", "LevelFive", "BossFight", "End" };

            int levelNumber = 0;
            while (levelNumber != 7)
            {
                if (levelNumber > 6)
                {
                    break;
                }
                if (levelNumber < 7)
                {
                    encounters.LevelSelector(levelNames[levelNumber]);
                    levelNumber++;
                }
            }
            Console.WriteLine("The End");
            Console.ReadKey();
        }
    }
}
