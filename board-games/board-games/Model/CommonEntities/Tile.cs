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
        private float xPosition;
        private float yPosition;

        public float GetXPosition() { return xPosition; }
        public float GetYPosition() { return yPosition; }
        public int GetTileId() { return tileId; }
    }
}
