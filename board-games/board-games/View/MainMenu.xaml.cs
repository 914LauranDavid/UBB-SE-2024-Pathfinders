﻿using board_games.View.Achievements;
using board_games.View.SkillIssueBro.Menus;
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
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Page
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void RadioButton_SizeChanged(object sender, SizeChangedEventArgs e)
        {

        }
        private void OnSiBButtonClicked(object sender, RoutedEventArgs e)
        {
   

            this.NavigationService.Navigate(new SkillIssueBroMainMenu());
        }

        private void OnGoLButtonClicked(object sender, RoutedEventArgs e)
        {


            this.NavigationService.Navigate(new StartView());
        }

        private void OnMyAchievementsClick(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new AchievementPage());
        }

    }
}
