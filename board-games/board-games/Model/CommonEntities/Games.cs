namespace board_games.Model.CommonEntities
{
    internal abstract class Games
    {
        private int gameId;
        /* todo add CompletedAchievements
         */

        public Games(int gameId)
        {
           this.gameId = gameId;
        }

        public int GetGameId() { return gameId; }
        public abstract void UpdateLeaderboard(Leaderboard leaderboard);
        public abstract void SetState();
        public abstract void SaveGameState();
        public abstract List<Player> GetPlayers();
    }
}
