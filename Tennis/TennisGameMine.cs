namespace Tennis {

    public class TennisGameMine : ITennisGame
    {
        private static PlayersScores _playersScores;
        private static ScoreService _scoreService;

        public TennisGameMine(string player1Name, string player2Name)
        {
            _playersScores = new PlayersScores(player1Name, player2Name);
            _scoreService = new ScoreService(_playersScores);
        }
        
        public string GetScore() {
            string s;
            if (_scoreService.ScoreMinorThan4() && (_scoreService.SumScoreMinorThan6())) {
                string[] scoreNames = { "Love", "Fifteen", "Thirty", "Forty" };
                s = scoreNames[_playersScores.Player1Score];
                return (_playersScores.Player1Score == _playersScores.Player2Score) ? s + "-All" : s + "-" + scoreNames[_playersScores.Player2Score];
            }
            else {
                if (_scoreService.SoresHasSameValue())
                    return "Deuce";
                s = _playersScores.Player1Score > _playersScores.Player2Score ? _playersScores.Player1Name : _playersScores.Player2Name;
                return ((_playersScores.Player1Score - _playersScores.Player2Score) * (_playersScores.Player1Score - _playersScores.Player2Score) == 1) ? "Advantage " + s : "Win for " + s;
            }
        }



        public void WonPoint(string playerName)
        {
            if (playerName == "player1")
                _playersScores.Player1Score += 1;
            else
                _playersScores.Player2Score += 1;
        }

    }
}

