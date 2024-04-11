using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace board_games.Model.GameOfLife
{
    public class Spinner
    {
        private static readonly IDictionary<int, int> resultProbabilitiesAsPercentages = new Dictionary<int, int>()
        {
            [1] = 19,
            [2] = 17,
            [3] = 14,
            [4] = 11,
            [5] = 9,
            [6] = 8,
            [7] = 7,
            [8] = 6,
            [9] = 5,
            [10] = 4
        };
        private Random _randomizer;

        public Spinner()
        {
            _randomizer = new Random();
        }

        public int RollSpinner()
        {
            int randomPercentage = _randomizer.Next(1, 100);

            int valueToBeReturned = 1, probabilitySumUntilValue = resultProbabilitiesAsPercentages[1];
            while (probabilitySumUntilValue < randomPercentage)
            {
                valueToBeReturned++;
                probabilitySumUntilValue += resultProbabilitiesAsPercentages[valueToBeReturned];
            }
            return valueToBeReturned;
        }

        public Random GetRandomizer()
        {
            return _randomizer;
        }
    }
}
