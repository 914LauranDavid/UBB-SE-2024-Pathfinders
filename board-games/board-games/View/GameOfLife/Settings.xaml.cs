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

namespace board_games.View.GameOfLife
{
    /// <summary>
    /// Interaction logic for Settings.xaml
    /// </summary>
    public partial class Settings : Page
    {
        public Settings()
        {
            InitializeComponent();
            // !!! HERE we should bring the existing settings from controller to GUI
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new StartView());
        }

        private void ChoosePawnStyleButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new PawnStyle());
        }

        private void ChooseBoardStyleButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new BoardStyle());
        }

        private void ChooseCardSetStyleButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new CardSetStyle());
        }
    }
}
