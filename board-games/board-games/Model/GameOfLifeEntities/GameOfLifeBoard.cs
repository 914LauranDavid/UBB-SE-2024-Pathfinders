using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using board_games.Model.CommonEntities;
using board_games.Model.GameOfLife.Cards;
using board_games.Model.Logging;

namespace board_games.Model.GameOfLife
{
    internal class GameOfLifeBoard : Games
    {
        private static readonly int _gameId;
        private List<Tile> _tiles;
        private int _currentPlayerId;
        private readonly Spinner _spinner;
        private Leaderboard _leaderboard;
        private List<Card> _cards;
        private List<Player> _players;
        private List<Pawn> _pawns;
        private IFileLogger _logger;

        public GameOfLifeBoard(int gameId) : base(gameId)
        {
            _tiles = new List<Tile>();
            // _currentPlayerId?
            _spinner = new Spinner();
            _leaderboard = new Leaderboard();
            _cards = new List<Card>();
            _players = new List<Player>();
            _pawns = new List<Pawn>();

            _logger = new SimpleFileLogger();
        }

        public override List<Player> GetPlayers()
        {
            return _players;
        }

        public override void SaveGameState()
        {
            throw new NotImplementedException();
        }

        public override void SetState()
        {
            throw new NotImplementedException();
        }

        public override void UpdateLeaderboard(Leaderboard leaderboard)
        {
            throw new NotImplementedException();
        }

        public void SetCurrentPlayerId(int currentPlayerId)
        {
            _currentPlayerId = currentPlayerId;
        }
    }
}
