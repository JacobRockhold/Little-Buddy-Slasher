namespace Little_Buddy_Slasher
{
    class Game
    {
        private static PlayerModel playerModel = new PlayerModel();
        private static Scenes scene = new Scenes();
        public Game()
        {
            Scene = scene;
            PlayerModel = playerModel;
            PlayerModel.CreatePlayer();
        }
        private PlayerModel PlayerModel { get; set; }
        private Scenes Scene { get; set; }

        public PlayerModel ReturnPlayerModel()
        {
            return PlayerModel;
        }

        public Scenes ReturnScene()
        {
            return Scene;
        }
    }
}
