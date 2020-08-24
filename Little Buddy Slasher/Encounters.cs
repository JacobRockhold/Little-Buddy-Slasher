using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Little_Buddy_Slasher
{
    class Encounters : Game
    {
        public Encounters(string name)
        {
            Name = name;
        }

        public Encounters(string name, PlayerModel playerModel)
        {
            Name = name;
            PlayerModelObject = playerModel;
        }

        public Encounters(string name, PlayerModel playerModel, Scenes scenes)
        {
            Name = name;
            PlayerModelObject = playerModel;
            Scene = scenes;
        }

        public string Name { get; set; }
        public PlayerModel PlayerModelObject { get; set; }
        public Scenes Scene { get; set; }

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
