using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace board_games.Model.GameOfLife.Cards.Effect
{
    public class HappinessEffect : IEffect
    {
        private readonly int _happinessAmount;

        public HappinessEffect(int happinessAmount)
        {
            this._happinessAmount = happinessAmount;
            this._additionalEffect = null;
        }

        public HappinessEffect(int happinessAmount, IEffect additionalEffect)
        {
            this._happinessAmount = happinessAmount;
            this._additionalEffect = additionalEffect;
        }

        public override void DoEffect()
        {
            throw new NotImplementedException("DoEffect will be implemented");
        }
    }
}
