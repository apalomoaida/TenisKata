namespace Tennis {

    public class TennisGameMine : ITennisGame
    {
        private readonly PlayersScores _playersScores;

        public TennisGameMine(string player1Name, string player2Name)
        {
            _playersScores = new PlayersScores(player1Name, player2Name);
        }

        public string GetScore()
        {
            string s;
            if ((_playersScores.Player1Score < 4 && _playersScores.Player2Score < 4) && (_playersScores.Player1Score + _playersScores.Player2Score < 6))
            {
                string[] p = { "Love", "Fifteen", "Thirty", "Forty" };
                s = p[_playersScores.Player1Score];
                return (_playersScores.Player1Score == _playersScores.Player2Score) ? s + "-All" : s + "-" + p[_playersScores.Player2Score];
            }
            else
            {
                if (_playersScores.Player1Score == _playersScores.Player2Score)
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

