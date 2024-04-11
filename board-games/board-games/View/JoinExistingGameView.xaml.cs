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

namespace board_games.View
{
    /// <summary>
    /// Interaction logic for JoinExistingGameView.xaml
    /// </summary>
    public partial class JoinExistingGameView : Page
    {
        public JoinExistingGameView()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new HostJoinView());
        }

        private void JoinGameButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new GameOfLife_MainWindow());
        }
    }
}
