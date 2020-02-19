using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Little_Buddy_Slasher
{
    enum PlayerState
    {
        Creation,
        PlayingScene,
        EndingScene,
        InMenu,
        Battle
    };
    public class Game
    {
        readonly Player player = new Player();
        public void Start()
        {
            player.CreatePlayer();
            GameScenes scenes = new GameScenes();
            scenes.SceneSelection("NewPlayerScene");
            player.UpdateName();
            scenes.SceneSelection("IntroductionScene");
        }
    }
}