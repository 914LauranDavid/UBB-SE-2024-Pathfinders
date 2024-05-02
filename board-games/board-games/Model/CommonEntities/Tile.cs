namespace board_games.Model.CommonEntities
{
    internal class Tile
    {
        private int _tileId;
        private float _centerXPosition;
        private float _centerYPosition;

        public Tile(int tileId, float centerXPosition, float centerYPosition)
        {
            _tileId = tileId;
            _centerXPosition = centerXPosition;
            _centerYPosition = centerYPosition;
        }

        public float GetCenterXPosition() { return _centerXPosition; }
        public float GetCenterYPosition() { return _centerYPosition; }
        public int GetTileId() { return _tileId; }
    }
}
