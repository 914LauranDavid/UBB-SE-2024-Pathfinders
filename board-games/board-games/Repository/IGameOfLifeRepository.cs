using board_games.Model.CommonEntities;
using board_games.Model.GameOfLife;
using board_games.Model.GameOfLife.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace board_games.Repository
{
    internal abstract class IGameOfLifeRepository
    {
        public abstract List<Card> GetCardsByType(CardType typeToLookFor);

        public abstract List<Card> GetAllCards();

        public abstract List<Tile> getAllTiles();

        public abstract List<Pawn> getAllPawns();


    }
}
