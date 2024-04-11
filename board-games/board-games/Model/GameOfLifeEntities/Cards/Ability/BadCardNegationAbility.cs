using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using board_games.Model.GameOfLife.Cards.Ability;

namespace board_games.Model.GameOfLife.Cards
{
    public class BadCardNegationAbility : IAbility
    {
        private CardType _typeToNegate;
        public int TurnsLeft { get; set; }
        public readonly int cooldown;
        
        public BadCardNegationAbility(CardType typeToNegate, int numberOfTurns, int cooldown)
        {
            this._typeToNegate = typeToNegate;
            this.TurnsLeft = numberOfTurns;
            this.cooldown = cooldown;
        }

        public CardType GetTypeToNegate()
        {
            return _typeToNegate;
        }

    }
}
