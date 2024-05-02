using System.Windows;
using System.Windows.Controls;

namespace board_games.View
{
    /// <summary>
    /// Interaction logic for Host_WaitingForPlayersView.xaml
    /// </summary>
    public partial class Host_WaitingForPlayersView : Page
    {
        private int _connectedPlayers = 0;
        private int _playerNumber;
        private string _gameID = string.Empty;
        public Host_WaitingForPlayersView(int _playerNumber)
        {
            InitializeComponent();
            this._playerNumber = _playerNumber;
            Loaded += Host_WaitingForPlayersView_Loaded;
        }

        private void Host_WaitingForPlayersView_Loaded(object sender, RoutedEventArgs e)
        {
            // _connectedPlayers = GetConnectedPlayers();
            ConnectedPlayersTextBlock.Text = _connectedPlayers.ToString() + "/" + _playerNumber.ToString();
            // _gameID = GetGameID();
            CodeTextBlock.Text = "#" + _gameID.ToString();
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new GameOfLife_MainWindow());
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new ChoosePlayerNumberView());
            // !!! When backing out of "waiting for players...", we should close that
            // game room; we should STOP WAITING FOR PLAYERS and make the code UNAVAILABLE
        }
    }
}
