using board_games.View.SkillIssueBro.Pawns;
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

namespace board_games.View.SkillIssueBro.Board
{
    /// <summary>
    /// Interaction logic for GameBoard.xaml
    /// </summary>
    public partial class GameBoard : UserControl
    {
        public GameBoard()
        {
            InitializeComponent();
        }

        public void AddBluePawn(int column, int row)
        {
            var bluePawn = new PawnBlue();
            Grid.SetColumn(bluePawn, column);
            Grid.SetRow(bluePawn, row);
            MainGrid.Children.Add(bluePawn);
        }

        public void AddYellowPawn(int column, int row)
        {
            var yellowPawn = new PawnYellow();
            Grid.SetColumn(yellowPawn, column);
            Grid.SetRow(yellowPawn, row);
            MainGrid.Children.Add(yellowPawn);
        }

        public void AddGreenPawn(int column, int row)
        {
            var greenPawn = new PawnGreen();
            Grid.SetColumn(greenPawn, column);
            Grid.SetRow(greenPawn, row);
            MainGrid.Children.Add(greenPawn);
        }

        public void AddRedPawn(int column, int row)
        {
            var redPawn = new PawnRed();
            Grid.SetColumn(redPawn, column);
            Grid.SetRow(redPawn, row);
            MainGrid.Children.Add(redPawn);
        }
    }
}
