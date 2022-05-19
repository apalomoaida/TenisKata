namespace Tennis {

    public class TennisGameMine : ITennisGame {
        private static PlayersScores _playersScores;
        private static ScoreService _scoreService;

        public TennisGameMine(string player1Name, string player2Name) {
            _playersScores = new PlayersScores(player1Name, player2Name);
            _scoreService = new ScoreService(_playersScores);
        }

        public string GetScore() {
            if (_scoreService.GameHaveLessThan6Points(out var score)) return score;
            if (_scoreService.ScoresHasSameValue()) return "Deuce";
            return (_scoreService.Player1HasAdvantage() ? "Advantage " : "Win for ") + _scoreService.GetMaxScorePLayerName();
        }

        public void WonPoint(string playerName) {
            if (playerName == "player1")
                ++_playersScores.Player1Score;
            else
                ++_playersScores.Player2Score;
        }
    }
}

