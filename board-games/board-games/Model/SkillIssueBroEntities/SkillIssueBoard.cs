using board_games.Model.CommonEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace board_games.Model.SkillIssueBroEntities
{
    internal class SkillIssueBoard : Games
    {
        private int _currentPlayerId;
        private List<Player> _players;
        private List<Pawn> _pawns;
        private List<SiBTile> _sibTiles;
        private Dice _sixSidedDice;

        public SkillIssueBoard(int gameId, List<SiBTile> tiles,List<Pawn> pawns, List<Player> players, int idOfFirstPlayerToRoll):base(gameId)
        {
            _sibTiles = tiles;
            _players = players;
            _currentPlayerId = idOfFirstPlayerToRoll;
            _sixSidedDice = new Dice();
            _pawns = pawns;
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

        public List<SiBTile> GetTiles()
        {
            return _sibTiles;
        }

        public List<Pawn> GetPawns()
        {
            return _pawns;
        }

        public Dice GetDice()
        {
            return _sixSidedDice;
        }

        public void UpdatePawns(List<Pawn> newPawns)
        {
            _pawns = newPawns;
            //SaveGameState();
        }
    }
}
