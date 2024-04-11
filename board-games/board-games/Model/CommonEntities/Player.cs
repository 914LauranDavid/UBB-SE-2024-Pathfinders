using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace board_games.Model.CommonEntities
{
    internal class Player
    {
        private int _playerId;
        private string _playerName;

        public Player(int playerId, string playerName)
        {
            this._playerId = playerId;
            this._playerName = playerName;
        }

        public string GetPlayerName()
        {
            return _playerName;
        }
        public int GetPlayerId() {  return _playerId; }

        /* todo: add completed achievements */

    }
}
