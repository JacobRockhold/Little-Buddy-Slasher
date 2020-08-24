using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Little_Buddy_Slasher
{
    class Game
    {
        public static PlayerModel playerModel = new PlayerModel();
        public static Player player = new Player(playerModel);
    }
}
