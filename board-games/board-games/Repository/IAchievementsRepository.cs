using board_games.Model.CommonEntities;

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
