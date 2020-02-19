namespace Little_Buddy_Slasher
{
    class UiService
    {
        public string InputServiceSelect(string selection, string output = "")
        {
            switch (selection)
            {
                case "PlayerName":
                    PlayerNameInput playerNameInput = new PlayerNameInput();
                    return playerNameInput.PlayerName();
                default:
                    StandardMessages.InputServiceSelectError();
                    return selection;
            }
        }        
    }
}
