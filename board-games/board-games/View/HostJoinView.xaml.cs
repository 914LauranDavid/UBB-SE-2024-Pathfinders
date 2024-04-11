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
    /// Interaction logic for HostJoinView.xaml
    /// </summary>
    public partial class HostJoinView
    {
        //StartView instance = new StartView();
        // Should we store PAGE INSTANCES, or create a new one for every navigation?
        // Does it deppend on the window?
        public HostJoinView()
        {
            InitializeComponent();
        }

        private void HostGameButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new ChoosePlayerNumberView());
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new StartView());
        }

        private void JoinExistingGameButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new JoinExistingGameView());
        }
    }
}
