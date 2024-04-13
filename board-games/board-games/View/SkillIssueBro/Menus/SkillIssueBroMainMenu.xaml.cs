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

namespace board_games.View.SkillIssueBro.Menus
{
    /// <summary>
    /// Interaction logic for SkillIssueBroMainMenu.xaml
    /// </summary>
    public partial class SkillIssueBroMainMenu : Page
    {
        public SkillIssueBroMainMenu()
        {
            InitializeComponent();
        }

        private void OnHostButtonClicked(object sender, RoutedEventArgs e)
        {


            this.NavigationService.Navigate(new SkillIssueBroNumberPlayers());
        }

        private void OnJoinButtonClicked(object sender, RoutedEventArgs e)
        {


            this.NavigationService.Navigate(new SkillIssueBroJoinWithCode());
        }

        private void OnBackButtonClicked(object sender, RoutedEventArgs e)
        {


            this.NavigationService.Navigate(new MainMenu());
        }
    }
}
