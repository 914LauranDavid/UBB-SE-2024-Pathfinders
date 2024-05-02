using System.Windows;
using System.Windows.Controls;

namespace board_games.View
{
    /// <summary>
    /// Interaction logic for ChoosePlayerNumberView.xaml
    /// </summary>
    public partial class ChoosePlayerNumberView : Page
    {
        // !!!! TODO: add a CONTINUE or START button here as well!!!!
        private int _playerNumber = 0;
        public ChoosePlayerNumberView()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new HostJoinView());
        }

        private void UpArrowButton_Click(object sender, RoutedEventArgs e)
        {
            if (_playerNumber + 1 <= 6)
            {
                _playerNumber++;
                PlayerNumberTextBlock.Text = _playerNumber.ToString();
            }
        }

        private void DownArrowButton_Click(object sender, RoutedEventArgs e)
        {
            if (_playerNumber - 1 >= 0)
            {
                _playerNumber--;
                PlayerNumberTextBlock.Text = _playerNumber.ToString();
            }
        }

        private void ConfirmButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Host_WaitingForPlayersView(_playerNumber));
        }
    }
}
