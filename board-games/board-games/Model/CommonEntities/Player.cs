namespace board_games.Model.CommonEntities
{
    internal class Player
    {
        private int _playerId;
        private string _playerName;

        public Player(int playerId, string playerName)
        {
            _playerId = playerId;
            _playerName = playerName;
        }

        public string GetPlayerName()
        {
            return _playerName;
        }
        public int GetPlayerId() {  return _playerId; }

        /* todo: add completed achievements */

    }
}
