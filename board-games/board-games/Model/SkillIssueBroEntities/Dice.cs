using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace board_games.Model.SkillIssueBroEntities
{
    internal class Dice
    {
        private Random randomizer = new Random();
        
        public int RollDice()
        {
            return randomizer.Next(1, 7);
        }
    }
}
