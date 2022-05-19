namespace Tennis {
    public class Players
    {
        public int Player2Score;
        public int Player1Score;
        public string Player1Name;
        public string Player2Name;

        public Players(string player1Name, string player2Name)
        {
            this.Player1Name = player1Name;
            this.Player2Name = player2Name;
        }

        public void AddScore(string playerName)
        {
            if (playerName == "player1")
                ++Player1Score;
            else
                ++Player2Score;
        }
    }
}

