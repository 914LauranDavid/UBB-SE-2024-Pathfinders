using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace board_games.Model.GameOfLife.Cards.Effect
{
    public class MoneyEffect : IEffect
    {
        private readonly int _moneyAmount;

        public MoneyEffect(int moneyAmount)
        {
            this._moneyAmount = moneyAmount;
            this._additionalEffect = null;
        }

        public MoneyEffect(int moneyAmount, IEffect additionalEffect)
        {
            this._moneyAmount = moneyAmount;
            this._additionalEffect = additionalEffect;
        }

        public int GetMoneyAmount()
        {
            return _moneyAmount;
        }

        public override void DoEffect()
        {
            throw new NotImplementedException("DoEffect will be implemented");
        }
    }
}
