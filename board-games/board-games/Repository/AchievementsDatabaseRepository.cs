using board_games.Model.CommonEntities;
using System.Data;
using System.Data.SqlClient;

namespace board_games.Repository
{
    internal class AchievementsDatabaseRepository : IAchievementsRepository
    {
        const string serverConnectionString = "Data Source=DESKTOP-Q75520B;Initial Catalog=BoardGames;Integrated Security=True";
        SqlConnection serverConnection = new SqlConnection(serverConnectionString);

        public override List<Achievement> GetAllAchievements()
        {
            List<Achievement> achievements = new List<Achievement>();

            string queryStatement = "SELECT * FROM Achievements";


            DataTable achivementsTable = new DataTable("Achievements");

            SqlDataAdapter dataAdapter = new SqlDataAdapter();

            using (SqlCommand command = new SqlCommand(queryStatement, serverConnection))
            {
                dataAdapter.SelectCommand = command;

                serverConnection.Open();
                dataAdapter.Fill(achivementsTable);
                serverConnection.Close();

            }

            for (int i = 0; i < achivementsTable.Rows.Count; i++)
                achievements.Add(new Achievement((int)achivementsTable.Rows[i][0], (string)achivementsTable.Rows[i][2], (string)achivementsTable.Rows[i][3], (GameCategory)(int)achivementsTable.Rows[i][1]));

            return achievements;
        }

        public override List<Achievement> GetAllAchievementsByGame(GameCategory game)
        {
            List<Achievement> achievements = new List<Achievement>();

            string queryStatement = "SELECT * FROM Achievements WHERE AchievementGameId=@GameCategory";


            DataTable achivementsTable = new DataTable("Achievements");

            SqlDataAdapter dataAdapter = new SqlDataAdapter();

            using (SqlCommand command = new SqlCommand(queryStatement, serverConnection))
            {
                command.Parameters.AddWithValue("@GameCategory", (int)game);
                dataAdapter.SelectCommand = command;

                serverConnection.Open();
                dataAdapter.Fill(achivementsTable);
                serverConnection.Close();

            }

            for (int i = 0; i < achivementsTable.Rows.Count; i++)
                achievements.Add(new Achievement((int)achivementsTable.Rows[i][0], (string)achivementsTable.Rows[i][2], (string)achivementsTable.Rows[i][3], (GameCategory)(int)achivementsTable.Rows[i][1]));

            return achievements;
        }

        public override List<Achievement> GetAllAchievementsByPlayer(int idOfPlayer)
        {
            List<Achievement> achievements = new List<Achievement>();

            string queryStatement = "SELECT a.AchivementId, a.AchievementGameId, a.AchivementTitle, a.AchievementDescr FROM Achievements a INNER JOIN PlayerAchivements ap ON a.AchievementId = ap.AchievementId WHERE ap.PlayerId=@playerId";


            DataTable achivementsTable = new DataTable("Achievements");

            SqlDataAdapter dataAdapter = new SqlDataAdapter();

            using (SqlCommand command = new SqlCommand(queryStatement, serverConnection))
            {
                command.Parameters.AddWithValue("@playerId", idOfPlayer); 
                dataAdapter.SelectCommand = command;

                serverConnection.Open();
                dataAdapter.Fill(achivementsTable);
                serverConnection.Close();

            }

            for (int i = 0; i < achivementsTable.Rows.Count; i++)
                achievements.Add(new Achievement((int)achivementsTable.Rows[i][0], (string)achivementsTable.Rows[i][2], (string)achivementsTable.Rows[i][3], (GameCategory)(int)achivementsTable.Rows[i][1]));

            return achievements;
        }

        public override List<Achievement> GetAllAchievementsByPlayerAndGame(int idOfPlayer, GameCategory game)
        {
            List<Achievement> achievements = new List<Achievement>();

            string queryStatement = "SELECT a.AchivementId, a.AchievementGameId, a.AchivementTitle, a.AchievementDescr FROM Achievements a INNER JOIN PlayerAchivements ap ON a.AchievementId = ap.AchievementId WHERE ap.PlayerId=@playerId AND a.AchievementGameId=@game";

            DataTable achivementsTable = new DataTable("Achievements");

            SqlDataAdapter dataAdapter = new SqlDataAdapter();

            using (SqlCommand command = new SqlCommand(queryStatement, serverConnection))
            {
                command.Parameters.AddWithValue("@playerId", idOfPlayer);
                command.Parameters.AddWithValue("@game", (int)game);
                dataAdapter.SelectCommand = command;

                serverConnection.Open();
                dataAdapter.Fill(achivementsTable);
                serverConnection.Close();
            }

            for (int i = 0; i < achivementsTable.Rows.Count; i++)
                achievements.Add(new Achievement((int)achivementsTable.Rows[i][0], (string)achivementsTable.Rows[i][2], (string)achivementsTable.Rows[i][3], (GameCategory)(int)achivementsTable.Rows[i][1]));

            return achievements;
        }
    }
}
