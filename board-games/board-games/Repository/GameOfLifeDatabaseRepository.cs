using board_games.Model.GameOfLife.Cards;
using board_games.Model.GameOfLife.Cards.Effect;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Data;
using System.Data.SqlClient;
using board_games.Model.Logging;
using board_games.Model.CommonEntities;
using System.Data.Common;

namespace board_games.Repository
{
    internal class GameOfLifeDatabaseRepository : IGameOfLifeRepository
    {

        const string serverConnectionString = "Data Source=DESKTOP-Q75520B;Initial Catalog=BoardGames;Integrated Security=True";
        SqlConnection serverConnection = new SqlConnection(serverConnectionString);


        public object[] processParameters(string paramtersString)
        {
            string pattern = "([a-zA-Z-0-9]*(\\((?>\\((?<c>)|[^()]+|\\)(?<-c>))*(?(c)(?!))\\))?),?"; // separates each parameter
            //                              ^ ------------------------------------------------ ^ getting matching paranthesis
            var matches = Regex.Matches(paramtersString, pattern);
            List<string> parametersStringList = new List<string>();
            foreach (Match match in matches)
            {
                if (match.Length == 0) continue;
                if (match.Value.EndsWith(",")) { // if not last parameter, have to get rid of the string (did this to reduce empty matches)
                    parametersStringList.Add(match.Value.Substring(0,match.Value.Length-1));
                }
                else {
                    parametersStringList.Add(match.Value);
                }
            }
            object[] parameters = new object[parametersStringList.Count];
            for (int index = 0; index < parametersStringList.Count; index++)
            {
                var parameter = parametersStringList[index];
                int temporaryVariableForParseAttempts;
                if (int.TryParse(parameter, out temporaryVariableForParseAttempts))
                {
                    parameters[index] = temporaryVariableForParseAttempts;
                }
                else
                {
                    parameters[index] = processEffect(parameter);
                }
            }
            return parameters;
        }

        public IEffect processEffect(string effectConstructor)
        {
            string pattern = "^([a-zA-Z]+)\\(([a-zA-Z0-9,()-]*)\\)$"; //Separates the type from the arguments
            var matches = Regex.Matches(effectConstructor, pattern);
            object[] parameters = processParameters(matches[0].Groups[2].Value);
            Type? type = Type.GetType("board_games.Model.GameOfLife.Cards.Effect." + matches[0].Groups[1].Value);
            if (parameters.Length > 0)
            {
                return (IEffect)Activator.CreateInstance(type,parameters);
            }
            else {
                return (IEffect)Activator.CreateInstance(type);
            }
        }

        private Card processCard(int type, string pathToTexture, string effectConstructor, Boolean isConsideredBad)
        {

            /*
             * TODO: Add Texture Processing
             */

            return new Card((CardType)type, new Texture(), processEffect(effectConstructor), isConsideredBad);


        }

        public override List<Card> GetAllCards()
        {
            var cards = new List<Card>();

            string queryStatement = "SELECT * FROM dbo.Cards";

            DataTable cardsTable = new DataTable("Cards");
            SqlDataAdapter dataAdapter = new SqlDataAdapter();


            using (SqlCommand sqlCommand = new SqlCommand(queryStatement, serverConnection))
            {

                dataAdapter.SelectCommand = sqlCommand;
                
                serverConnection.Open();
                dataAdapter.Fill(cardsTable);
                serverConnection.Close();

            }

            SimpleFileLogger logger = new SimpleFileLogger("database.txt");

            for (int i = 0; i < cardsTable.Rows.Count; i++)
            {
                //logger.Log("Loading card: " + cardsTable.Rows[i][0].ToString() + ";" + cardsTable.Rows[i][1].ToString() + ";" + cardsTable.Rows[i][2].ToString() + ";" + cardsTable.Rows[i][3].ToString() + ";" + cardsTable.Rows[i][4].ToString() + ";", LogLevel.Info);
                cards.Add(processCard((int)cardsTable.Rows[i][1], (string)cardsTable.Rows[i][2], (string)cardsTable.Rows[i][3], (Boolean)cardsTable.Rows[i][4]));
            }

            logger.Shutdown();

            return cards;
        }

        public override List<Card> GetCardsByType(CardType typeToLookFor)
        {
            var cards = new List<Card>();

            string queryStatement = "SELECT * FROM dbo.Cards WHERE cardType=@type";

            DataTable cardsTable = new DataTable("Cards");
            SqlDataAdapter dataAdapter = new SqlDataAdapter();


            using (SqlCommand sqlCommand = new SqlCommand(queryStatement, serverConnection))
            {
                sqlCommand.Parameters.AddWithValue("type", (int)typeToLookFor);
                dataAdapter.SelectCommand = sqlCommand;

                serverConnection.Open();
                dataAdapter.Fill(cardsTable);
                serverConnection.Close();

            }

            SimpleFileLogger logger = new SimpleFileLogger("database.txt");

            for (int i = 0; i < cardsTable.Rows.Count; i++)
            {
                //logger.Log("Loading card: " + cardsTable.Rows[i][0].ToString() + ";" + cardsTable.Rows[i][1].ToString() + ";" + cardsTable.Rows[i][2].ToString() + ";" + cardsTable.Rows[i][3].ToString() + ";" + cardsTable.Rows[i][4].ToString() + ";", LogLevel.Info);

                Boolean isConsideredBad = (byte)cardsTable.Rows[i][4] == 1;
                cards.Add(processCard((int)cardsTable.Rows[i][1], (string)cardsTable.Rows[i][2], (string)cardsTable.Rows[i][3], isConsideredBad));
            }

            logger.Shutdown();

            return cards;
        }

        public override List<Tile> getAllTiles()
        {
            var tiles = new List<Tile>();

            string queryStatement = "SELECT * FROM dbo.Tiles";

            DataTable tilesTable = new DataTable("Tiles");
            SqlDataAdapter dataAdapter = new SqlDataAdapter();


            using (SqlCommand sqlCommand = new SqlCommand(queryStatement, serverConnection))
            {

                dataAdapter.SelectCommand = sqlCommand;

                serverConnection.Open();
                dataAdapter.Fill(tilesTable);
                serverConnection.Close();

            }

            
            for (int i = 0; i < tilesTable.Rows.Count; i++)
            {
                tiles.Add(new Tile((int)tilesTable.Rows[i][0], (float)tilesTable.Rows[i][2], (float)tilesTable.Rows[i][3]));
            }

            
            return tiles;
        }

        public override List<Pawn> getAllPawns()
        {
            var pawns = new List<Pawn>();

            string queryStatement = "SELECT * FROM GoLPawns";
            DataTable pawnsTable = new DataTable("GoLPawns");
            SqlDataAdapter dataAdapter = new SqlDataAdapter();

            using (SqlCommand sqlCommand = new SqlCommand(queryStatement, serverConnection))
            {

                dataAdapter.SelectCommand = sqlCommand;

                serverConnection.Open();
                dataAdapter.Fill(pawnsTable);
                serverConnection.Close();

            }


            for (int i = 0; i < pawnsTable.Rows.Count; i++)
            {
                pawns.Add(new Pawn((int)pawnsTable.Rows[i][0], (int)pawnsTable.Rows[i][2], (int)pawnsTable.Rows[i][3]));
            }

            return pawns;
        }
    }
}
