using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace board_games.Model.CommonEntities
{
    /*todo: associate a sorter and a huffman tree */
    internal class Leaderboard
    {
        List<Player> playersByRank = new List<Player>();
        //temporary comment: in the list the index is the rank
        public void PlaceDisconnectedPlayer(Tuple<Player, int> playerAndRank)
        {
            //todo: implement adding a disconnected player
        }
        public void PlaceConnectedPlayer(Tuple<Player, int> playerAndRank)
        {
            //..
        }
        public List<Player> GetFinalResult()
        {
            return playersByRank;
        }
        public int GetPlayerRank(Player player)
        {
            return playersByRank.IndexOf(player);
        }
    }
}
