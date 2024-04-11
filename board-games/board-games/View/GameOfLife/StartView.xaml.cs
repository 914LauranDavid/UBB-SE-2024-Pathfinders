using board_games.View.GameOfLife;
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
    /// Interaction logic for StartView.xaml
    /// </summary>
    public partial class StartView
    {
        public StartView()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new HostJoinView());
        }

        private void StartButton_MouseEnter(object sender, MouseEventArgs e)
        {
            StartButton.BorderBrush = Brushes.DarkBlue;
            StartButton.Background = Brushes.Transparent;
        }

        private void StartButton_MouseLeave(object sender, MouseEventArgs e)
        {
            StartButton.BorderBrush = Brushes.Transparent;

        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            // Should go to Choose Game Page
            
            throw new NotImplementedException();
        }

        private void SettingsButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Settings());
        }
    }
}
