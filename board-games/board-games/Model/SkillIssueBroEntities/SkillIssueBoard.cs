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
        private int currentPlayerId;
        private List<Player> players;
        private List<Pawn> pawns;
        private List<Tile> tiles;
        private Dice sixSidedDice;

        public SkillIssueBoard(int gameId, List<Player> players) : base(gameId)
        {
            this.players = players;

            //subject to change, only to get an idea of how it works
            currentPlayerId = players[0].GetPlayerId();
        }

        public override List<Player> GetPlayers()
        {
            return players;
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

        public List<Tile> GetTiles()
        {
            return tiles;
        }

        public List<Pawn> GetPawns()
        {
            return pawns;
        }

        public Dice GetDice()
        {
            return sixSidedDice;
        }
    }
}
