using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace board_games.Model.CommonEntities
{
    internal class Player
    {
        private int playerId;
        private string playerName;

        public Player(int playerId, string playerName)
        {
            this.playerId = playerId;
            this.playerName = playerName;
        }

        public string GetPlayerName()
        {
            return playerName;
        }
        public int GetPlayerId() {  return playerId; }

        /* todo: add completed achievements */

    }
}
