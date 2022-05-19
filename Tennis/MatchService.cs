namespace Tennis {
    public class MatchService {
        private Players _playersScores { get; }
        private readonly string[] scoreNames = { "Love", "Fifteen", "Thirty", "Forty" };

        public MatchService(Players playersScores) {

            this._playersScores = playersScores;
        }

        public bool LessThan6Points(out string score) {
            if (ScoreMinorThan4() && (SumScoreMinorThan6())) {
                {
                    score = GetPlayerScore(_playersScores.Player1Score) + (Same() ? "-All" : "-" + GetPlayerScore(_playersScores.Player2Score));
                    return true;
                }
            }
            score = null;
            return false;
        }

        public bool Same() {
            return _playersScores.Player1Score == _playersScores.Player2Score;
        }
        public string GetBestPlayerName() {
            return _playersScores.Player1Score > _playersScores.Player2Score ? _playersScores.Player1Name : _playersScores.Player2Name;
        }

        public bool HasPlayer1Advantage() {
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

