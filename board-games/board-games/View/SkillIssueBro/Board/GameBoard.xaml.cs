using board_games.View.SkillIssueBro.Pawns;
using System;
using System.Collections.Generic;
using System.Data.Common;
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
        public event EventHandler<PawnClickedEventArgs> PawnClicked;
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
            bluePawn.button.Click += OnPawnClicked;
        }

        private void OnPawnClicked(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                if (button.Parent is Grid grid)
                {
                    if (grid.Parent is UserControl pawn)
                    {
                        int column = Grid.GetColumn(pawn);
                        int row = Grid.GetRow(pawn);

                        PawnClicked?.Invoke(this, new PawnClickedEventArgs(column, row));
                    }
                }
            }
        }

        public void AddYellowPawn(int column, int row)
        {
            var yellowPawn = new PawnYellow();
            Grid.SetColumn(yellowPawn, column);
            Grid.SetRow(yellowPawn, row);
            MainGrid.Children.Add(yellowPawn);
            yellowPawn.button.Click += OnPawnClicked;
        }

        public void AddGreenPawn(int column, int row)
        {
            var greenPawn = new PawnGreen();
            Grid.SetColumn(greenPawn, column);
            Grid.SetRow(greenPawn, row);
            MainGrid.Children.Add(greenPawn);
            greenPawn.button.Click += OnPawnClicked;
        }

        public void AddRedPawn(int column, int row)
        {
            var redPawn = new PawnRed();
            Grid.SetColumn(redPawn, column);
            Grid.SetRow(redPawn, row);
            MainGrid.Children.Add(redPawn);
            redPawn.button.Click += OnPawnClicked;
        }

    }

    public class PawnClickedEventArgs : EventArgs
    {
        public int Column { get; }
        public int Row { get; }

        public PawnClickedEventArgs(int column, int row)
        {
            Column = column;
            Row = row;
        }
    }
}
