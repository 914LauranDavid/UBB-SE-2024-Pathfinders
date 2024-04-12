using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace board_games.Model.CommonEntities
{
    internal enum GameCategory
    {
        SkillIssueBro = 0, 
        GameOfLife = 1,
    }

    internal class Achievement
    {
        private int _achievementId;
        private string _name;
        private string _description;
        private GameCategory _gameCategory;

        public Achievement(int achievementId, string name, string description, GameCategory gameCategory)
        {
            _achievementId = achievementId;
            _name = name;
            _description = description;
            _gameCategory = gameCategory;

        }

        public bool CheckAchievementCompletition(int playerId)
        {
            // database call

            return false;
        }

        public string GetNameOfAchievement()
        {
            return _name;
        }

        public string GetDescriptionOfAchievement()
        {
            return _description;
        }

        public int GetAchievementId()
        {
            return _achievementId;
        }

        public GameCategory GetAchievementGameCategory()
        {
            return _gameCategory;
        }
    }
}