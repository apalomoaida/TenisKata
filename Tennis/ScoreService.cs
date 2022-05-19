namespace Tennis {
    public class ScoreService {
        private PlayersScores _playersScores { get; }
        private readonly string[] scoreNames = { "Love", "Fifteen", "Thirty", "Forty" };

        public ScoreService(PlayersScores playersScores) {

            this._playersScores = playersScores;
        }

        public bool GameHaveLessThan6Points(out string score) {
            if (ScoreMinorThan4() && (SumScoreMinorThan6())) {
                {
                    score = GetPlayerScore(_playersScores.Player1Score) + (ScoresHasSameValue() ? "-All" : "-" + GetPlayerScore(_playersScores.Player2Score));
                    return true;
                }
            }
            score = null;
            return false;
        }

        public bool ScoresHasSameValue() {
            return _playersScores.Player1Score == _playersScores.Player2Score;
        }
        public string GetMaxScorePLayerName() {
            return _playersScores.Player1Score > _playersScores.Player2Score ? _playersScores.Player1Name : _playersScores.Player2Name;
        }

        public bool Player1HasAdvantage() {
            return (SubstractPLayerScore() * SubstractPLayerScore() == 1);
        }

        #region private functions
        private bool SumScoreMinorThan6() {
            return _playersScores.Player1Score + _playersScores.Player2Score < 6;
        }

        private bool ScoreMinorThan4() {
            return (_playersScores.Player1Score < 4 && _playersScores.Player2Score < 4);
        }

        private  string GetPlayerScore(int score) {
            return scoreNames[score];
        }
        private int SubstractPLayerScore() {
            return (_playersScores.Player1Score - _playersScores.Player2Score);
        }
        #endregion
    }
}

