using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace board_games.Model.GameOfLife.Cards.Effect
{
    public abstract class IEffect
    {
        protected IEffect? _additionalEffect;

        public abstract void DoEffect(); // we will see how this works when we have the ViewModel/Controller layer
        public IEffect? GetAdditionalEffect()
        {
            return _additionalEffect;
        }
    }
}
