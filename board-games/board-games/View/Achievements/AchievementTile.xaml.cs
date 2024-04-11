using board_games.Model.CommonEntities;
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

namespace board_games.View.Achievements
{
    /// <summary>
    /// Interaction logic for AchievementTile.xaml
    /// </summary>
    public partial class AchievementTile : UserControl
    {
        public AchievementTile()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty AchievementProperty =
            DependencyProperty.Register(
                "Achievement",
                typeof(Achievement),
                typeof(AchievementTile),
                new PropertyMetadata(null, OnAchievementChanged));

        internal Achievement Achievement
        {
            get { return (Achievement)GetValue(AchievementProperty); }
            set { SetValue(AchievementProperty, value); }
        }


        private static void OnAchievementChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as AchievementTile;
            control.UpdateText();
        }

        private void UpdateText()
        {
            if (Achievement != null)
            {
                title.Text = Achievement.GetNameOfAchievement();
                description.Text = Achievement.GetDescriptionOfAchievement();
                game.Text = Achievement.GetAchievementGameCategory().ToString();
            }
        }

    }
}