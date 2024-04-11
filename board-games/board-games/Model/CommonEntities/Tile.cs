using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace board_games.Model.CommonEntities
{
    internal class Tile
    {
        private int _tileId;
        private float _centerXPosition;
        private float _centerYPosition;

        public Tile(int tileId, float centerXPosition, float centerYPosition)
        {
            this._tileId = tileId;
            this._centerXPosition = centerXPosition;
            this._centerYPosition = centerYPosition;
        }

        public float GetCenterXPosition() { return _centerXPosition; }
        public float GetCenterYPosition() { return _centerYPosition; }
        public int GetTileId() { return _tileId; }
    }
}
