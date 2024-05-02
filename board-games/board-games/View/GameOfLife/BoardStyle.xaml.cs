using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace board_games.View.GameOfLife
{
    /// <summary>
    /// Interaction logic for BoardStyle.xaml
    /// </summary>
    public partial class BoardStyle : Page
    {
        private bool isPicture1Displayed = true;
        private BitmapImage _boardLight;
        private BitmapImage _boardDark;
        public BoardStyle()
        {
            InitializeComponent();
            _boardLight = new BitmapImage(new Uri("../../Resources/board_style_light.png", UriKind.Relative));
            _boardDark = new BitmapImage(new Uri("../../Resources/board_style_dark.png", UriKind.Relative));

            DisplayCurrentPicture();
        }

        private void DisplayCurrentPicture()
        {
            if (isPicture1Displayed)
            {
                ImageControl.Source = _boardLight;
            }
            else
            {
                ImageControl.Source = _boardDark;
            }
        }

        private void ArrowLeftButton_Click(object sender, RoutedEventArgs e)
        {
            isPicture1Displayed = !isPicture1Displayed;

            DisplayCurrentPicture();
        }

        private void ArrowRightButton_Click(object sender, RoutedEventArgs e)
        {
            isPicture1Displayed = !isPicture1Displayed;

            DisplayCurrentPicture();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Settings());
        }
    }
}
