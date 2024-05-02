namespace board_games.View.Achievements
{
    using System.Windows;
    using System.Windows.Controls;
    using board_games.Model.CommonEntities;

    /// <summary>
    /// Interaction logic for AchievementTile.xaml
    /// </summary>
    public partial class AchievementTile : UserControl
    {
        public static readonly DependencyProperty AchievementProperty =
            DependencyProperty.Register(
                "Achievement",
                typeof(Achievement),
                typeof(AchievementTile),
                new PropertyMetadata(null, OnAchievementChanged));

        /// <summary>
        /// Initializes a new instance of the <see cref="AchievementTile"/> class.
        /// </summary>
        public AchievementTile()
        {
            InitializeComponent();
        }

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