﻿using board_games.Model.CommonEntities;
using board_games.Model.SkillIssueBroEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace board_games.Controller
{
    internal class SkillIssueBroMainGameController
    {
        private SkillIssueBoard _skillIssueBoard;
        private List<Player> _players;
        private List<SiBTile> _sibTiles;
        private List<Pawn> _pawns;
        private int generatedPawnIds = 0; // temporary solution, fix if needed or delete comment
        public SkillIssueBroMainGameController(List<Player> players)
        {
            _players = players;
            _sibTiles =  GenerateTiles();
            _pawns = new List<Pawn>();
            GeneratePawns();
            // id is subject to change; can do an insert first and then retrieve the id (bcuz identity) 
            // and create the object
            _skillIssueBoard = new SkillIssueBoard(1, _sibTiles, _pawns, _players,1);
        }

        private List<Pawn> GenerateBluePawns()
        {
            List<Pawn> bluePawns = new List<Pawn>();
            // 4 pawns on tiles 0-3
            for(int i=0; i < 4; i++)
            {
                Pawn newPawn = new Pawn(generatedPawnIds, _sibTiles[i]);
                generatedPawnIds++;
                bluePawns.Add(newPawn);
            }

            return bluePawns;
        }

        private List<Pawn> GenerateYellowPawns()
        {
            List<Pawn> yellowPawns = new List<Pawn>();
            for(int i=4; i< 8;i++)
            {
                Pawn newPawn = new Pawn(generatedPawnIds, _sibTiles[i]);
                generatedPawnIds++;
                yellowPawns.Add(newPawn);
            }
            return yellowPawns;
        }

        private List<Pawn> GenerateGreenPawns()
        {
            List<Pawn> GreenPawns = new List<Pawn>();
            for (int i = 8; i < 12; i++)
            {
                Pawn newPawn = new Pawn(generatedPawnIds, _sibTiles[i]);
                generatedPawnIds++;
                GreenPawns.Add(newPawn);
            }
            return GreenPawns;
        }

        private  List<Pawn> GenerateRedPawns()
        {
            List<Pawn> RedPawns = new List<Pawn>();
            for (int i = 12; i < 16; i++)
            {
                Pawn newPawn = new Pawn(generatedPawnIds, _sibTiles[i]);
                generatedPawnIds++;
                RedPawns.Add(newPawn);
            }
            return RedPawns;
        }


        private void GeneratePawns()
        {
            // associate pawns depending on the number of players
            List<string> colors = new List<string>{ "Blue", "Yellow", "Green", "Red" };
            List<Pawn> bluePawns, yellowPawns, greenPawns, redPawns;
            bluePawns = new List<Pawn>();
            yellowPawns = new List<Pawn>();
            greenPawns = new List<Pawn>();
            redPawns = new List<Pawn>();

            switch (_players.Count)
            {
                case 2:
                    bluePawns = GenerateBluePawns();
                    yellowPawns = GenerateYellowPawns();
                    break;
                case 3:
                    bluePawns = GenerateBluePawns();
                    yellowPawns = GenerateYellowPawns();
                    greenPawns = GenerateGreenPawns();
                    break;
                case 4:
                    bluePawns = GenerateBluePawns();
                    yellowPawns = GenerateYellowPawns();
                    greenPawns = GenerateGreenPawns();
                    redPawns = GenerateRedPawns();
                    break;
            }
            foreach(Pawn bluePawn in bluePawns)
            {
                bluePawn.SetAssociatedPlayer(_players[0]);
                _pawns.Add(bluePawn);
            }

            foreach (Pawn yellowPawn in yellowPawns)
            {
                yellowPawn.SetAssociatedPlayer(_players[1]);
                _pawns.Add(yellowPawn);
            }

            if(_players.Count > 2)
            {
                foreach(Pawn greenPawn in greenPawns)
                {
                    greenPawn.SetAssociatedPlayer(_players[2]);
                    _pawns.Add(greenPawn);
                }
            }
            if(_players.Count > 3)
            {
                foreach(Pawn redPawn in redPawns)
                {
                    redPawn.SetAssociatedPlayer(_players[3]);
                    _pawns.Add(redPawn);
                }
            }


        }

        private List<SiBTile> GenerateTiles()
        {
            List<SiBTile> siBTiles = new List<SiBTile>();
            //the blue corner
            siBTiles.Add(new SiBTile(0, 9, 0));
            siBTiles.Add(new SiBTile(1, 9, 1));
            siBTiles.Add(new SiBTile(2, 10, 0));
            siBTiles.Add(new SiBTile(3, 10, 1));

            //the yellow corner
            siBTiles.Add(new SiBTile(4,0,0));
            siBTiles.Add(new SiBTile(5, 0, 1));
            siBTiles.Add(new SiBTile(6, 1, 0));
            siBTiles.Add(new SiBTile(7, 1, 1));

            //the green corner
            siBTiles.Add(new SiBTile(8, 0, 9));
            siBTiles.Add(new SiBTile(9, 0, 10));
            siBTiles.Add(new SiBTile(10, 1, 9));
            siBTiles.Add(new SiBTile(11, 1, 10));
            //the red corner
            siBTiles.Add(new SiBTile(12, 9, 9));
            siBTiles.Add(new SiBTile(13, 9, 10));
            siBTiles.Add(new SiBTile(14, 10, 9));
            siBTiles.Add(new SiBTile(15, 10, 10));
            int i;
            int count = 16;
            for (i = 10; i >= 6; i--)
            {
                siBTiles.Add(new SiBTile(count++, i, 4));
            }
            for (i = 3; i >= 0; i--)
            {
                siBTiles.Add(new SiBTile(count++, 6, i));
            }
            for (i = 5; i >= 4; i--)
            {
                siBTiles.Add(new SiBTile(count++, i, 0));
            }
            for (i = 1; i <= 4; i++)
            {
                siBTiles.Add(new SiBTile(count++, 4, i));
            }
            for (i = 0; i <= 3; i++)
            {
                siBTiles.Add(new SiBTile(count++, i, 4));
            }
            for (i = 5; i <=6; i++)
            {
                siBTiles.Add(new SiBTile(count++, 0, i));
            }
            for (i = 1; i <= 4; i++)
            {
                siBTiles.Add(new SiBTile(count++, i, 6));
            }
            for (i = 7; i <= 10; i++)
            {
                siBTiles.Add(new SiBTile(count++, 4, i));
            }
            for (i = 5; i <= 6; i++)
            {
                siBTiles.Add(new SiBTile(count++, i, 10));
            }
            for (i = 9; i >= 6; i--)
            {
                siBTiles.Add(new SiBTile(count++, 6, i));
            }
            for (i = 7; i <= 10; i++)
            {
                siBTiles.Add(new SiBTile(count++, i, 6));
            }
            siBTiles.Add(new SiBTile(count++, 10, 5));
            //the crosses
            //the blue cross
            for (i = 9; i >= 6; i--)
            {
                siBTiles.Add(new SiBTile(count++, i, 5));
            }
            //the yellow cross
            for (i = 1; i <= 4; i++)
            {
                siBTiles.Add(new SiBTile(count++, 5, i));
            }
            //the green cross
            for (i = 1; i <= 4; i++)
            {
                siBTiles.Add(new SiBTile(count++, i, 5));
            }
            //the red cross
            for (i = 9; i >= 6; i--)
            {
                siBTiles.Add(new SiBTile(count++, 5, i));
            }


            return siBTiles;



        }
        public List<Pawn> GetPawns()
        {
            /*
             * Pawns are in order Blue x 4, Yellow x 4, Green x 4, Red x 4
             */
            return _pawns;
        }

        public int RollDice()
        {
            Dice dice = _skillIssueBoard.GetDice();
            return dice.RollDice();
        }

        private int ComputeNewTileId(string pawnColor, int currentTileId, int diceValue)
        {
            //16 first path tile
            if (currentTileId <= 3)
            {
                //blue corner
                return diceValue + 16 - 1;


            }
            else if(currentTileId<=7) {
                //yellow corner
                return diceValue + 26 - 1;
            }
            else if (currentTileId <= 11)
            {
                return diceValue + 36 - 1;
            }
            else if(currentTileId <= 15)
            {
                return diceValue + 46 - 1;
            }


            // compute possible new tile
            int newTileId = currentTileId + diceValue;

            // should enter cross
            if(pawnColor == "b")
            {
                if(newTileId >= 56 && newTileId <=59)
                {
                    return newTileId;
                }
               
            }
            if(pawnColor == "y")
            {


                if (currentTileId <= 25 && newTileId >= 25)
                {
                    if (newTileId-26+60 <= 63)
                        return newTileId - 26 + 60;
                    else return currentTileId;
                }
                
                
            }
            if(pawnColor == "g")
            {

            }
            if(pawnColor == "r")
            {

            }    

            // no extreme cases
            if(newTileId > 55)
            {
                newTileId = newTileId % 56 + 16;
            }

            //temp
            return newTileId;
            
        }

        private string PawnColor(int pawnId)
        {
           if(pawnId < 4)
            {
                return "b";
            }
           else if(pawnId < 8)
            {
                return "y";
            }
           else if(pawnId < 12)
            {
                return "g";
            }
            return "r";
        }

        public void MovePawn(int pawnId, int diceValue)
        {
            //lmoa
            int currentTileId = _pawns[pawnId].GetOccupiedTile().GetTileId();
            int newTileId = ComputeNewTileId(PawnColor(pawnId), currentTileId, diceValue);

            SiBTile newTile = _sibTiles[newTileId];
            _pawns[pawnId].ChangeTile(newTile);

            // update in game state whatever
        }


    }
}
