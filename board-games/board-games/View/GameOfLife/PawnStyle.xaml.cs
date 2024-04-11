using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
    /// Interaction logic for PawnStyle.xaml
    /// </summary>
    public partial class PawnStyle : Page
    {
        // !!! After choosing pawn style, change should be sent to DB!
        private readonly Dictionary<string, Color> _pawnColors = new()
        {
            {"Red", Color.FromRgb(228, 6, 19) },
            {"Orange", Color.FromRgb(255, 133, 0) },
            {"Yellow", Color.FromRgb(255, 228, 0) },
            {"Green", Color.FromRgb(0, 148, 64)},
            {"Blue", Color.FromRgb(83, 74, 153) },
            {"Pink", Color.FromRgb(224, 0, 143) },
        };
        private int _displayedColorIndex = 0;

        public PawnStyle()
        {
            InitializeComponent();
            Loaded += PawnStyle_Loaded;
        }

        private void PawnStyle_Loaded(object sender, RoutedEventArgs e)
        {
            ChangeDisplayedPawnColor(_displayedColorIndex);
        }

        private void ArrowRightButton_Click(object sender, RoutedEventArgs e)
        {
            _displayedColorIndex = (_displayedColorIndex + 1) % _pawnColors.Count;
            ChangeDisplayedPawnColor(_displayedColorIndex);
        }
        private void ArrowLeftButton_Click(object sender, RoutedEventArgs e)
        {
            _displayedColorIndex = (_displayedColorIndex - 1 + _pawnColors.Count) % _pawnColors.Count;
            ChangeDisplayedPawnColor (_displayedColorIndex);
        }
        private void ChangeDisplayedPawnColor(int index)
        {
            Color newColor = _pawnColors.ElementAt(index).Value;
            SolidColorBrush currentBrush = new SolidColorBrush(newColor);
            DisplayedPawn.ChangeBackgroundColor(currentBrush);
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Settings());
        }
    }
}
