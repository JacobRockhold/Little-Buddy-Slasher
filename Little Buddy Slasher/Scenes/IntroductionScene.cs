using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Little_Buddy_Slasher
{
    class IntroductionScene
    {
        public void scenePlay()
        {
            Console.WriteLine($"Nice to meet you, {this.PlayerName}. Too bad we had to meet under " +
                "these circumstances.");
            Console.ReadLine();
        }
    }
}
