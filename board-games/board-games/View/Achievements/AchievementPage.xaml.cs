namespace board_games.View.Achievements
{
    using System.Windows.Controls;
    using board_games.Model.CommonEntities;

    /// <summary>
    /// Interaction logic for AchievementPage.xaml
    /// </summary>
    public partial class AchievementPage : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AchievementPage"/> class.
        /// </summary>
        public AchievementPage()
        {
            InitializeComponent();
            LoadAchivements();
        }

        private void AddAchivementToStack(Achievement achievement)
        {
            AchievementTile achievementTile = new AchievementTile();
            achievementTile.Achievement = achievement;
            achStack.Children.Add(achievementTile);
        }

        private void LoadAchivements()
        {
            // to be replaced by db/repository call
            Achievement firstAchievement = new Achievement(1, "Rich man", "Be the first to reach $100k", GameCategory.GameOfLife);
            Achievement secondAchievement = new Achievement(2, "Strategist", "Knock 3 opponent pawns off the final tiles in a match", GameCategory.SkillIssueBro);

            AddAchivementToStack(firstAchievement);
            AddAchivementToStack(secondAchievement);
        }
    }
}