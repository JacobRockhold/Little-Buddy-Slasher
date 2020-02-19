using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Little_Buddy_Slasher
{
    struct PlayerCharacter
    {
        public PlayerState State;
        public PlayerInventory Inventory;
        public string Name;
        public int Strength;
        public int Defence;
        public int Health;
    }
    public class Player
    {
        PlayerCharacter playerCharacter = new PlayerCharacter();
        readonly UiService uiService = new UiService();
        public string PlayerName { get; set; }
        public int Strength { get; set; }
        public int Defence { get; set; }
        public int Health { get; set; }
        public void CreatePlayer()
        {
            playerCharacter.State = PlayerState.Creation;
            playerCharacter.Strength = 2;
            playerCharacter.Defence = 2;
            playerCharacter.Health = 10;
            playerCharacter.Inventory = PlayerInventory.Empty;
            PlayerName = playerCharacter.Name;
        }
        public void UpdatePlayerState(string stateName)
        {
            switch (stateName)
            {
                case "PlayingScene":
                    playerCharacter.State = PlayerState.PlayingScene;
                    break;
                case "EndingScene":
                    playerCharacter.State = PlayerState.EndingScene;
                    break;
                case "InMenu":
                    playerCharacter.State = PlayerState.InMenu;
                    break;
                case "Battle":
                    playerCharacter.State = PlayerState.Battle;
                    break;
                default:
                    StandardMessages.UpdatePlayerStateError();
                    break;
            }
        }
        public void UpdateName()
        {
            playerCharacter.Name = uiService.InputServiceSelect("PlayerName");
        }
    }
}
