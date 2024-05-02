using board_games.src.Sort;

namespace board_games.Model.CommonEntities
{
    /*todo: associate a huffman tree */
    internal class PlayerWithScore : IComparable<PlayerWithScore>
    {
        private Player _player { get; }

        private int _score;
        public PlayerWithScore(Player player, int score)
        {
            _player = player;
            _score = score;
        }
        public int CompareTo(PlayerWithScore? otherPlayerWithScore)
        {
            if (otherPlayerWithScore == null)
                return 1;

            return _score.CompareTo(otherPlayerWithScore._score);
        }

        public Player Player
        {
            get { return _player; }
        }
    }
    internal class Leaderboard
    {
        List<PlayerWithScore> _playersWithScore;
        Sorter<PlayerWithScore> _sorter;

        public Leaderboard()
        {
            _playersWithScore = new List<PlayerWithScore>();
            _sorter = new Sorter<PlayerWithScore>();
            _sorter.SetStrategy(new MergeSortStrategy<PlayerWithScore>());
        }

        public void AddPlayerWithScoreToLeaderboard(PlayerWithScore playerWithScore)
        {
            _playersWithScore.Add(playerWithScore);
        }
        
        public List<Player> GetFinalResult()
        {
            _sorter.Sort(_playersWithScore);
            List<Player> playersByRank = _playersWithScore.Select(playerWithScore => playerWithScore.Player).ToList();
            return playersByRank;
        }
    }
}
