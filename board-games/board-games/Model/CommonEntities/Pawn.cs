using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace board_games.Model.CommonEntities
{
    internal class Pawn
    {
        private int pawnId;
        private Tile tileOccupied;
        private Player player;
        public void ChangeTile(Tile tileToChangeTo)
        {
            tileOccupied = tileToChangeTo;
        }
        public Tile GetTileOccupied() {
            return tileOccupied;
        }
        public int GetPawnId() { return pawnId; }
        public Player GetPlayer() {
            return player;
        }

    }
}
