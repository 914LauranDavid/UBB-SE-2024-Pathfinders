using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace board_games.Model.CommonEntities
{
    internal class Pawn
    {
        private int _pawnId;
        private int _occupiedTileId;
        private int _associatedPlayerId;

        public Pawn(int pawnId, int occupiedTile, int associatedPlayer)
        {
            _pawnId = pawnId;
            _occupiedTileId = occupiedTile;
            _associatedPlayerId = associatedPlayer;
        }

        public void ChangeTile(int idOfTileToChangeTo)
        {
            _occupiedTileId = idOfTileToChangeTo;
        }
        public int GetOccupiedTileId() {
            return _occupiedTileId;
        }
        public int GetPawnId() { return _pawnId; }
        public int GetPlayerId() {
            return _associatedPlayerId;
        }

    }
}
