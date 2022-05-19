namespace Tennis {

    public class TennisGameMine : ITennisGame {
        private static PlayersScores _playersScores;
        private static ScoreService _scoreService;

        public TennisGameMine(string player1Name, string player2Name) {
            _playersScores = new PlayersScores(player1Name, player2Name);
            _scoreService = new ScoreService(_playersScores);
        }

        public string GetScore() {
            string s;
            if (_scoreService.ScoreMinorThan4() && (_scoreService.SumScoreMinorThan6())) {
                s = _scoreService.GetPlayerScore(_playersScores.Player1Score);
                return (_scoreService.SoresHasSameValue()) ? s + "-All" : s + "-" + _scoreService.GetPlayerScore(_playersScores.Player2Score);
            }
            if (_scoreService.SoresHasSameValue())
                return "Deuce";
            s = _scoreService.GetMaxScorePLayerName();
            return (_scoreService.SubstractPLayerScore() * _scoreService.SubstractPLayerScore() == 1) ? "Advantage " + s : "Win for " + s;

        }
        public void WonPoint(string playerName) {
            if (playerName == "player1")
                ++_playersScores.Player1Score;
            else
                ++_playersScores.Player2Score;
        }
    }
}

