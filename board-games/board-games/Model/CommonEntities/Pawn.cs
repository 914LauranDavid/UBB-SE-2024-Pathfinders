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
        private Tile _occupiedTile;
        private Player _associatedPlayer;

        public Pawn(int pawnId, Tile occupiedTile, Player associatedPlayer)
        {
            _pawnId = pawnId;
            _occupiedTile = occupiedTile;
            _associatedPlayer = associatedPlayer;
        }

        public void ChangeTile(Tile tileToChangeTo)
        {
            _occupiedTile = tileToChangeTo;
        }
        public Tile GetOccupiedTile() {
            return _occupiedTile;
        }
        public int GetPawnId() { return _pawnId; }
        public Player GetPlayer() {
            return _associatedPlayer;
        }

    }
}
