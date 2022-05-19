namespace Tennis {
    public class ScoreService {
        private PlayersScores _playersScores { get; }
        public readonly string[] scoreNames = { "Love", "Fifteen", "Thirty", "Forty" };

        public ScoreService(PlayersScores playersScores) {

            this._playersScores = playersScores;
        }

        public bool SumScoreMinorThan6() {
            return _playersScores.Player1Score + _playersScores.Player2Score < 6;
        }

        public bool ScoreMinorThan4() {
            return (_playersScores.Player1Score < 4 && _playersScores.Player2Score < 4);
        }

        public bool ScoresHasSameValue() {
            return _playersScores.Player1Score == _playersScores.Player2Score;
        }
        public string GetMaxScorePLayerName() {
            return _playersScores.Player1Score > _playersScores.Player2Score ? _playersScores.Player1Name : _playersScores.Player2Name;
        }

        public  string GetPlayerScore(int score) {
            return scoreNames[score];
        }
        public int SubstractPLayerScore() {
            return (_playersScores.Player1Score - _playersScores.Player2Score);
        }
    }
}

