using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace board_games.Model.GameOfLife.Cards.Effect
{
    public class DeathEffect : IEffect
    {
        public DeathEffect()
        {
            this._additionalEffect = null;
        }

        public DeathEffect(IEffect additionalEffect)
        {
            this._additionalEffect = additionalEffect;
        }

        public IEffect GetAdditionalEffect()
        {
            return _additionalEffect;
        }

        public override void DoEffect()
        {
            throw new NotImplementedException("DoEffect will be implemented");
        }
    }
}
