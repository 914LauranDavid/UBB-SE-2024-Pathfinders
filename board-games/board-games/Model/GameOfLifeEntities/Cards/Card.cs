using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using board_games.Model.GameOfLife.Cards.Effect;

namespace board_games.Model.GameOfLife.Cards
{
    public class Card
    {
        private CardType _type;
        private Texture _texture;
        private IEffect _effect;
        private Boolean _isConsideredBad;

        public Card(CardType type, Texture texture, IEffect effect, Boolean isConsideredBad)
        {
            this._type = type;
            this._texture = texture;
            this._effect = effect;
            this._isConsideredBad = isConsideredBad;
        }

        public CardType GetType()
        {
            return _type;
        }

        public Texture GetTexture()
        {
            return _texture;
        }
        
        public IEffect GetEffect()
        {
            return _effect;
        }

        public Boolean IsConsideredBad()
        {
            return _isConsideredBad;
        }

    }
}
