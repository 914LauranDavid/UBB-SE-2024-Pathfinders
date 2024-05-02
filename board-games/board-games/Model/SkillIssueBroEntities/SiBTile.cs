using board_games.Model.CommonEntities;

namespace board_games.Model.SkillIssueBroEntities
{
    internal class SiBTile :Tile
    {
        private int _tileId;
        private int _gridRowIndex;
        private int _gridColumnIndex;

        //someone find a solution
        public SiBTile(int tileId, int gridRowIndex, int gridColumnIndex) : base(tileId, gridColumnIndex, gridRowIndex)
        {
            _tileId = tileId;
            _gridRowIndex = gridRowIndex;
            _gridColumnIndex = gridColumnIndex;
        }   

        public int GetTileId() { return _tileId; }
        public int GetGridRowIndex() { return _gridRowIndex; }  
        public int GetGridColumnInded() {  return _gridColumnIndex; }
    }
}
