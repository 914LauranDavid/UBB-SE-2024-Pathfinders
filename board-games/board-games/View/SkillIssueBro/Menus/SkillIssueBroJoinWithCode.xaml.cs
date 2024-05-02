using System.Windows;
using System.Windows.Controls;
using board_games.View.SkillIssueBro.Board;

namespace board_games.View.SkillIssueBro.Menus
{
    /// <summary>
    /// Interaction logic for SkillIssueBroJoinWithCode.xaml
    /// </summary>
    public partial class SkillIssueBroJoinWithCode : Page
    {
        public SkillIssueBroJoinWithCode()
        {
            InitializeComponent();
        }

        private void OnClickJoin(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new GameBoardWindow());
        }
    }
}
