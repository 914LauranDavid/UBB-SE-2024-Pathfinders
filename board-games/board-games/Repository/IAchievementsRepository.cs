using board_games.Model.CommonEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace board_games.Repository
{
    internal abstract class IAchievementsRepository
    {

        public abstract List<Achievement> GetAllAchievements();

        public abstract List<Achievement> GetAllAchievementsByGame(GameCategory game);


        public abstract List<Achievement> GetAllAchievementsByPlayer(int idOfPlayer);


        public abstract List<Achievement> GetAllAchievementsByPlayerAndGame(int idOfPlayer, GameCategory game);
    }
}
