using board_games.Model.CommonEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace board_games.View.Achievements
{
    /// <summary>
    /// Interaction logic for AchievementPage.xaml
    /// </summary>
    public partial class AchievementPage : UserControl
    {
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

        private void OnClickBack()
        {
        }
    }
}