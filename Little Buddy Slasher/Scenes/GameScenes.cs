using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Little_Buddy_Slasher
{
    public class GameScenes
    {
        public void SceneSelection(string sceneName)
        {
            switch (sceneName)
            {
                case "NewPlayerScene":
                    NewPlayerScene scene = new NewPlayerScene();
                    scene.StartNewPlayer();
                    break;
                case "IntroductionScene":
                    IntroductionScene introductionScene = new IntroductionScene();
                    introductionScene.scenePlay();
                    break;
                default:
                    StandardMessages.SceneSelectionError();
                    break;
            }
        }
    }
}
