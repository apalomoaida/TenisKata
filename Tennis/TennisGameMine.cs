namespace Tennis {

    public class TennisGameMine : ITennisGame {
        private static Players _players;
        private static MatchService _match;

        public TennisGameMine(string player1Name, string player2Name) {
            _players = new Players(player1Name, player2Name);
            _match = new MatchService(_players);
        }

        public string GetScore() {
            if (_match.LessThan6Points(out var score)) return score;
            if (_match.Same()) return "Deuce";
            return (_match.HasPlayer1Advantage() ? "Advantage " : "Win for ") + _match.GetBestPlayerName();
        }

        public void WonPoint(string playerName)
        {
            _players.AddScore(playerName);
        }
    }
}

