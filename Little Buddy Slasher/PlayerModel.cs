using FluentValidation.Results;
using System;

namespace Little_Buddy_Slasher
{
    public class PlayerModel
    {
        public string PlayerName { get; set; } = null;
        public int Strength { get; set; }
        public int Defence { get; set; }
        public int Health { get; set; }
        public PlayerInventory Inventory { get; set; }

        public void CreatePlayer()
        {
            Strength = 2;
            Defence = 2;
            Health = 10;
            Inventory = new PlayerInventory();
        }

        public string ReturnPlayerName()
        {
            return PlayerName;
        }

        public void GivePlayerAName()
        {
            while (PlayerName == null)
            {
                UpdateName();
            }
        }

        public void UpdateName()
        {
            Console.Write("Enter your name: ");
            PlayerName = Console.ReadLine();
            bool selection = UiService.ConfirmChoice(PlayerName);

            PlayerNameValidator validator = new PlayerNameValidator();
            ValidationResult results = validator.Validate(this);
            if (results.IsValid & selection)
            {
                return;
            }
            Console.WriteLine(results);
            PlayerName = null;
        }
    }
}
