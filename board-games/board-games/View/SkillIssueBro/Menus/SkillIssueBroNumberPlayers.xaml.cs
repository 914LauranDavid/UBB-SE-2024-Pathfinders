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
using board_games.View.SkillIssueBro.Board;

namespace board_games.View.SkillIssueBro.Menus
{
    /// <summary>
    /// Interaction logic for SkillIssueBroNumberPlayers.xaml
    /// </summary>
    public partial class SkillIssueBroNumberPlayers : Page
    {
        public SkillIssueBroNumberPlayers()
        {
            InitializeComponent();
        }

        private void OnBackButtonClicked(object sender, RoutedEventArgs e)
        {


            this.NavigationService.Navigate(new SkillIssueBroMainMenu());
        }

        private void OnChooseTwoPlayers(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new GameBoardWindow());
        }
        
        private void OnChooseThreePlayers(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new GameBoardWindow());
        }
        
        private void OnChooseFourPlayers(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new GameBoardWindow());
        }
    }
}
