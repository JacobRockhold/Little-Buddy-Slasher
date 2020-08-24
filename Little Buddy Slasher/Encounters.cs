using System;

namespace Little_Buddy_Slasher
{
    class Encounters : Game
    {
        public Encounters()
        {
            Scene = ReturnScene();
        }

        private Scenes Scene { get; set; }

        public void LevelSelector(string level)
        {
            switch (level)
            {
                case "LevelOne":
                    LevelOne();
                    break;
                case "LevelTwo":
                    LevelTwo();
                    break;
                case "LevelThree":
                    LevelThree();
                    break;
                case "LevelFour":
                    LevelFour();
                    break;
                case "LevelFive":
                    LevelFive();
                    break;
                case "BossFight":
                    BossFight();
                    break;
                default:
                    break;
            }
        }

        public void LevelOne()
        {
            Scene.LevelOneSceneOne();
        }

        public void LevelTwo()
        {
            Console.WriteLine("2");
        }

        public void LevelThree()
        {
            Console.WriteLine("3");
        }

        public void LevelFour()
        {
            Console.WriteLine("4");
        }

        public void LevelFive()
        {
            Console.WriteLine("5");
        }

        public void BossFight()
        {
            Console.WriteLine("6");
        }
    }
}
