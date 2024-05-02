using board_games.View.Achievements;
using board_games.View.SkillIssueBro.Menus;
using System.Windows;
using System.Windows.Controls;

namespace board_games.View
{
    /// <summary>
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Page
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void OnSiBButtonClicked(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SkillIssueBroMainMenu());
        }

        private void OnGoLButtonClicked(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new StartView());
        }

        private void OnMyAchievementsClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AchievementPage());
        }
    }
}
