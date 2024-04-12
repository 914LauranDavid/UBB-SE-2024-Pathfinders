using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using board_games.Model.CommonEntities;
using board_games.Model.GameOfLife;
using board_games.Model.GameOfLife.Cards;
using board_games.Model.SkillIssueBroEntities;

namespace board_games.Controller
{
    internal class GameOfLifeMainGameController
    {
        private GameOfLifeBoard _gameOfLifeBoard;
        private List<Player> _players;
        private List<Tile> _tiles;
        private List<Pawn> _pawns;
        private List<Card> _cards;
        private int generatedPawnIds = 0; // temporary solution, fix if needed or delete comment

        public GameOfLifeMainGameController(List<Player> players)
        {
            _players = players;
            _tiles = GenerateTiles();
            _pawns = new List<Pawn>();
            _cards = GenerateCards();
            GeneratePawns();

            _gameOfLifeBoard = new GameOfLifeBoard(2, _tiles, _pawns, _players, _cards, 1);
        }

        private List<Tile> GenerateTiles()
        {
            List<Tile> tiles = new List<Tile>();

            for (int i = 1; i <= 80; i++)
                tiles.Add(new Tile(i, 999, 999));

            return tiles;
        }

        private void GeneratePawns()
        {
            // associate pawns depending on the number of players
            List<string> colors = new List<string> { "Red", "Yellow", "Green", "Blue", "Orange", "Pink" };
            List<Pawn> orangePawns, pinkPawns, bluePawns, yellowPawns, greenPawns, redPawns;
            orangePawns = new List<Pawn>();
            pinkPawns = new List<Pawn>();
            bluePawns = new List<Pawn>();
            yellowPawns = new List<Pawn>();
            greenPawns = new List<Pawn>();
            redPawns = new List<Pawn>();

            Pawn bluePawn = new Pawn(generatedPawnIds, _tiles[1]);
            generatedPawnIds++;
            bluePawn.SetAssociatedPlayer(_players[0]);
            _pawns.Add(bluePawn);

            Pawn yellowPawn = new Pawn(generatedPawnIds, _tiles[2]);
            generatedPawnIds++;
            yellowPawn.SetAssociatedPlayer(_players[1]);
            _pawns.Add(yellowPawn);

            if (_players.Count >= 3)
            {
                Pawn greenPawn = new Pawn(generatedPawnIds, _tiles[3]);
                generatedPawnIds++;
                greenPawn.SetAssociatedPlayer(_players[2]);
                _pawns.Add(greenPawn);
            }
            if (_players.Count >= 4)
            {
                Pawn redPawn = new Pawn(generatedPawnIds, _tiles[4]);
                generatedPawnIds++;
                redPawn.SetAssociatedPlayer(_players[3]);
                _pawns.Add(redPawn);
            }
            if (_players.Count >= 5)
            {
                Pawn orangePawn = new Pawn(generatedPawnIds, _tiles[5]);
                generatedPawnIds++;
                orangePawn.SetAssociatedPlayer(_players[4]);
                _pawns.Add(orangePawn);
            }
            if (_players.Count >= 6)
            {
                Pawn pinkPawn = new Pawn(generatedPawnIds, _tiles[6]);
                generatedPawnIds++;
                pinkPawn.SetAssociatedPlayer(_players[5]);
                _pawns.Add(pinkPawn);
            }
        }

        private List<Card> GenerateCards()
        {
            List<Card> cards = new List<Card>();

            // TODO

            return cards;
        }
    }
}
