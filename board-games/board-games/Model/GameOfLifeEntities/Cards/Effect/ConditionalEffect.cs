using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace board_games.Model.GameOfLife.Cards.Effect
{
    public class ConditionalEffect : IEffect
    {
        private readonly IEffect _effectIfFirstPathChosen;
        private readonly IEffect _effectIfSecondPathChosen;

        public ConditionalEffect(IEffect effectIfFirstPathChosen, IEffect effectIfSecondPathChosen)
        {
            this._effectIfFirstPathChosen = effectIfFirstPathChosen;
            this._effectIfSecondPathChosen = effectIfSecondPathChosen;
            this._additionalEffect = null;
        }

        public ConditionalEffect(IEffect effectIfFirstPathChosen, IEffect effectIfSecondPathChosen, IEffect additionalEffect)
        {
            this._effectIfFirstPathChosen = effectIfFirstPathChosen;
            this._effectIfSecondPathChosen = effectIfSecondPathChosen;
            this._additionalEffect = additionalEffect;
        }

        public override void DoEffect()
        {
            throw new NotImplementedException("DoEffect will be implemented");
        }
    }
}
