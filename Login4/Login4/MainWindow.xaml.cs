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

namespace Login4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Button[] arrButtons = new Button[9];
        
        // buttons are ordered from 0 as topleft to 8 as buttom right
        public MainWindow()
        {
            InitializeComponent();
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            int turn = 0;
            if (turn == 0)
            {
                buttonTL.Content = "X";
                turn = 1;
            }
            else
            {
                buttonTR.Content = "O";
                turn = 0;
            }


        }
    }
}
