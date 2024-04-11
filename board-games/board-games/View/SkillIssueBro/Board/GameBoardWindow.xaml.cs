using board_games.Controller;
using board_games.Model.CommonEntities;
using board_games.Model.SkillIssueBroEntities;
using board_games.View.SkillIssueBro.Dice;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Net.WebSockets;
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
    /// Interaction logic for GameBoardWindow.xaml
    /// </summary>
    public partial class GameBoardWindow : UserControl
    {
        // temporary hardcoded players
        private List<Player> _players = new List<Player> { 
            new Player(1, "Egg"),
            new Player(2, "Mario"),
            new Player(3, "Gigi"),
            new Player(4, "Flower")
        };


        private SkillIssueBroMainGameController skillIssueBroController;
        public GameBoardWindow()
        {
            InitializeComponent();
            Loaded += GameBoardWindow_Loaded;
            column1.rollButton.ButtonClicked += RollButton_Clicked;
        }


        private void RollButton_Clicked(object sender, EventArgs e)
        {
            //skillIssueBroController.HandleRollButtonClick();
            int valueOfLeftDice = skillIssueBroController.RollDice();
            int valueOfRightDice = skillIssueBroController.RollDice();
            
            // show the dice in the view
            GenerateLeftDice(valueOfLeftDice);
            GenerateRightDice(valueOfRightDice);


            // actually move the pawn
        }

        private void GenerateLeftDice(int value)
        {
            switch(value)
            {
                case 1:
                    var leftDice1 = new DiceWithNumber1();
                    Grid.SetColumn(leftDice1, 0);
                    Grid.SetRow(leftDice1, 1);
                    column1.column1Grid.Children.Add(leftDice1);
                    break;
                case 2:
                    var leftDice2 = new DiceWithNumber2();
                    Grid.SetColumn(leftDice2, 0);
                    Grid.SetRow(leftDice2, 1);
                    column1.column1Grid.Children.Add(leftDice2);
                    break;
                case 3:
                    var leftDice3 = new DiceWithNumber3();
                    Grid.SetColumn(leftDice3, 0);
                    Grid.SetRow(leftDice3, 1);
                    column1.column1Grid.Children.Add(leftDice3);
                    break;
                case 4:
                    var leftDice4 = new DiceWithNumber2();
                    Grid.SetColumn(leftDice4, 0);
                    Grid.SetRow(leftDice4, 1);
                    column1.column1Grid.Children.Add(leftDice4);
                    break;
                case 5:
                    var leftDice5 = new DiceWithNumber5();
                    Grid.SetColumn(leftDice5, 0);
                    Grid.SetRow(leftDice5, 1);
                    column1.column1Grid.Children.Add(leftDice5);
                    break;
                default:
                    var leftDice6 = new DiceWithNumber6();
                    Grid.SetColumn(leftDice6, 0);
                    Grid.SetRow(leftDice6, 1);
                    column1.column1Grid.Children.Add(leftDice6);
                    break;
            }
        }

        private void GenerateRightDice(int value)
        {
            switch (value)
            {
                case 1:
                    var rightDice1 = new DiceWithNumber1();
                    Grid.SetColumn(rightDice1, 0);
                    Grid.SetRow(rightDice1, 1);
                    column2.column2Grid.Children.Add(rightDice1);
                    break;
                case 2:
                    var rightDice2 = new DiceWithNumber2();
                    Grid.SetColumn(rightDice2, 0);
                    Grid.SetRow(rightDice2, 1);
                    column2.column2Grid.Children.Add(rightDice2);
                    break;
                case 3:
                    var rightDice3 = new DiceWithNumber3();
                    Grid.SetColumn(rightDice3, 0);
                    Grid.SetRow(rightDice3, 1);
                    column2.column2Grid.Children.Add(rightDice3);
                    break;
                case 4:
                    var rightDice4 = new DiceWithNumber2();
                    Grid.SetColumn(rightDice4, 0);
                    Grid.SetRow(rightDice4, 1);
                    column2.column2Grid.Children.Add(rightDice4);
                    break;
                case 5:
                    var rightDice5 = new DiceWithNumber5();
                    Grid.SetColumn(rightDice5, 0);
                    Grid.SetRow(rightDice5, 1);
                    column2.column2Grid.Children.Add(rightDice5);
                    break;
                default:
                    var rightDice6 = new DiceWithNumber6();
                    Grid.SetColumn(rightDice6, 0);
                    Grid.SetRow(rightDice6, 1);
                    column2.column2Grid.Children.Add(rightDice6);
                    break;
            }
        }


        private void GameBoardWindow_Loaded(object sender, RoutedEventArgs e)
        {
            // create the controller when the window is loaded
            skillIssueBroController = new SkillIssueBroMainGameController(_players);
            SpawnPawns(skillIssueBroController.GetPawns());
        }

        private void SpawnPawns(List<Pawn> pawnsToSpawn)
        {
            // blue and yellow spawned regardless
            for(int i=0; i<4;i++)
            {
                Tile occupiedTile = pawnsToSpawn[i].GetOccupiedTile();
                gameBoard.AddBluePawn((int)occupiedTile.GetCenterXPosition(), (int)occupiedTile.GetCenterYPosition());
            }

            for(int i = 4; i < 8; i++)
            {
                Tile occupiedTile = pawnsToSpawn[i].GetOccupiedTile();
                gameBoard.AddYellowPawn((int)occupiedTile.GetCenterXPosition(), (int)occupiedTile.GetCenterYPosition());
            }

            // green if player count > 2
            if(_players.Count > 2)
            {
                for(int i=8; i<12; i++)
                {
                    Tile occupiedTile = pawnsToSpawn[i].GetOccupiedTile();
                    gameBoard.AddGreenPawn((int)occupiedTile.GetCenterXPosition(), (int)occupiedTile.GetCenterYPosition());
                }
            }
            // red if player count > 3 
            if (_players.Count > 3)
            {
                for(int i=12; i < 16; i++)
                {
                    Tile occupiedTile = pawnsToSpawn[i].GetOccupiedTile();
                    gameBoard.AddRedPawn((int)occupiedTile.GetCenterXPosition(), (int)occupiedTile.GetCenterYPosition());
                }
            }
        }

    }
}
