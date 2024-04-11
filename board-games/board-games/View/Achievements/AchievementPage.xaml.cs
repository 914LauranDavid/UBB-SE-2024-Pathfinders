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
            //db call
        }
    }
}