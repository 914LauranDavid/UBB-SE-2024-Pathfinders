using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace board_games.Model.CommonEntities
{
    internal class Tile
    {
        private int tileId;
        private float centerXPosition;
        private float centerYPosition;

        public Tile(int tileId, float centerXPosition, float centerYPosition)
        {
            this.tileId = tileId;
            this.centerXPosition = centerXPosition;
            this.centerYPosition = centerYPosition;
        }

        public float GetCenterXPosition() { return centerXPosition; }
        public float GetCenterYPosition() { return centerYPosition; }
        public int GetTileId() { return tileId; }
    }
}
