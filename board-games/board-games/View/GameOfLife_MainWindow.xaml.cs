using board_games.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace board_games
{
    /// <summary>
    /// Interaction logic for GameOfLife_MainWindow.xaml
    /// </summary>
    public partial class GameOfLife_MainWindow
    {
        private const int NumberOfTiles = 80;
        private const int NumberOfEventTilesByCategory = 10;
        private const int TotalNumberOfEventTiles = 3 * NumberOfEventTilesByCategory;
        private const int NumberOfGreenTiles = 8;
        private const string tileNameCommonRoot = "Tile";
        public GameOfLife_MainWindow()
        {
            InitializeComponent();
            Loaded += GameOfLife_MainWindow_Loaded;
        }
        /// <summary>
        /// Generates a list of unique random integers from 1 to 80 (inclusive)
        /// </summary>
        /// <param name="numberOfIndices">The number of random integers to generate.</param>
        /// <returns>A list of unique random integers.</returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when <paramref name="numberOfIndices"/> is greater than the total number of tiles or smaller than 0.
        /// </exception>
        private List<int> GenerateRandomIndices(int numberOfIndices)
        {
            if (numberOfIndices > NumberOfTiles)
            {
                throw new ArgumentOutOfRangeException("The number of randomly generated indices cannot be larger than the total number of tiles.");
            }
            if (numberOfIndices < 0)
            {
                throw new ArgumentOutOfRangeException("The number of randomly generated indices cannot be smaller than 0");
            }
            var lowerBound = 1;
            var upperBound = NumberOfTiles + 1;
            List<int> randomNumbersList = new List<int>();
            Random random = new Random();

            while (numberOfIndices > 0)
            {
                var randomNumber = random.Next(lowerBound, upperBound);

                if (!randomNumbersList.Contains(randomNumber))
                {
                    randomNumbersList.Add(randomNumber);
                    numberOfIndices--;
                }
            }
            return randomNumbersList;
        }
        private void GameOfLife_MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            int nextIndex = 0;
            List<int> indicesToColor = GenerateRandomIndices(TotalNumberOfEventTiles + NumberOfGreenTiles);
            List<int> indicesOfGreenTiles = indicesToColor.GetRange(nextIndex, NumberOfGreenTiles);
            ColorTiles(indicesOfGreenTiles, Color.FromRgb(150,187,32));
            nextIndex = NumberOfGreenTiles;
            List<int> indicesOfRedTiles = indicesToColor.GetRange(nextIndex, NumberOfEventTilesByCategory);
            ColorTiles(indicesOfRedTiles, Color.FromRgb(229, 51, 61));
            nextIndex = nextIndex + NumberOfEventTilesByCategory;
            List<int> indicesOfBlueTiles = indicesToColor.GetRange(nextIndex, NumberOfEventTilesByCategory);
            ColorTiles(indicesOfBlueTiles, Color.FromRgb(43, 163, 171));
            nextIndex = nextIndex + NumberOfEventTilesByCategory;
            List<int> indicesOfOrangeTiles = indicesToColor.GetRange(nextIndex, NumberOfEventTilesByCategory);
            ColorTiles(indicesOfOrangeTiles, Color.FromRgb(241, 151, 54));
        }
        /// <summary>
        /// Colors the tiles with specified indices using the given brush color.
        /// </summary>
        /// <param name="tileIndexesToColor">The indices of the tiles to be colored.</param>
        /// <param name="givenBrushColor">The color to fill the tiles with.</param>
        private void ColorTiles(List<int> tileIndexesToColor, Color givenBrushColor)
        {
            SolidColorBrush currentBrush = new SolidColorBrush(givenBrushColor);
            string currentTileName;
            
            foreach(int tileIndex in tileIndexesToColor)
            {
                currentTileName = tileNameCommonRoot + tileIndex.ToString();
                Path currentTile = (Path)FindName(currentTileName);
                currentTile.Fill = currentBrush;
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new HostJoinView());
        }
    }
}

