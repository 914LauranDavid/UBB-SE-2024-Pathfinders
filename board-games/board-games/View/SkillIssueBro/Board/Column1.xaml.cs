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
    /// Interaction logic for Column1.xaml
    /// </summary>
    public partial class Column1 : UserControl
    {
        public Column1()
        {
            InitializeComponent();
            rollButton.ButtonClicked += RollButton_ButtonClicked;
        }

        private void RollButton_ButtonClicked(object sender, EventArgs e)
        {
            rollButton.Visibility = Visibility.Collapsed;
            
        }
    }
}
