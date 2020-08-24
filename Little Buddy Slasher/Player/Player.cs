using FluentValidation;
using FluentValidation.Results;
using System;

namespace Little_Buddy_Slasher
{
    public class Player
    {
        public Player(PlayerModel playerModel)
        {
            PlayerModelObject = playerModel;
        }

        private PlayerModel PlayerModelObject { get; set; }

        public void CreatePlayer()
        {
            PlayerModelObject.Strength = 2;
            PlayerModelObject.Defence = 2;
            PlayerModelObject.Health = 10;
            PlayerModelObject.Inventory = new PlayerInventory();
        }
    }
}