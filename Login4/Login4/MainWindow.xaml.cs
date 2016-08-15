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
    /// 
    public partial class MainWindow : Window
    {
        private Button[] arrButtons = new Button[9];
        private int intTurn = 0;
        
        // buttons are ordered from 0 as topleft to 8 as buttom right
        public MainWindow()
        {
            InitializeComponent();
        }

        //changes butons to "X" and "O' 
        private void button_Click(object sender, RoutedEventArgs e)
        {
            Button btnThisButton = (Button)sender;
            if (intTurn == 0)
            {
                btnThisButton.Content = "X";
                checker();
                intTurn = 1;
                btnThisButton.IsHitTestVisible = false;
            }
            else
            {
                btnThisButton.Content = "O";
                checker();
                intTurn = 0;
                btnThisButton.IsHitTestVisible = false;
            }


        }
        private void checker()
        {
            String winner = "";
            if (buttonTL.Content == buttonTM.Content && buttonTL.Content == buttonTR.Content && buttonTL.Content.ToString() != "")
            {
                winner = buttonTL.Content.ToString();
                label.Content = winner + " WIN'S";
            }
            else if (buttonML.Content == buttonMM.Content && buttonML.Content == buttonMR.Content && buttonML.Content.ToString() != "")
            {
                winner = buttonTL.Content.ToString();
                label.Content = winner + " WIN'S";
            }
            else if (buttonBL.Content == buttonBM.Content && buttonBL.Content == buttonBR.Content && buttonBL.Content.ToString() != "")
            {
                winner = buttonTL.Content.ToString();
                label.Content = winner + " WIN'S";
            }
            else if (buttonTL.Content == buttonML.Content && buttonTL.Content == buttonML.Content && buttonTL.Content.ToString() != "")
            {
                winner = buttonTL.Content.ToString();
                label.Content = winner + " WIN'S";
            }
            else if (buttonTM.Content == buttonMM.Content && buttonTM.Content == buttonBM.Content && buttonTM.Content.ToString() != "")
            {
                winner = buttonTL.Content.ToString();
                label.Content = winner + " WIN'S";
            }
            else if (buttonTR.Content == buttonMR.Content && buttonTR.Content == buttonBR.Content && buttonTR.Content.ToString() != "")
            {
                winner = buttonTL.Content.ToString();
                label.Content = winner + " WIN'S";
            }
            else if (buttonTL.Content == buttonMM.Content && buttonTL.Content == buttonBR.Content && buttonTL.Content.ToString() != "")
            {
                winner = buttonTL.Content.ToString();
                label.Content = winner + " WIN'S";
            }
            else if (buttonBL.Content == buttonMM.Content && buttonBL.Content == buttonTR.Content && buttonBL.Content.ToString() != "")
            {
                winner = buttonTL.Content.ToString();
                label.Content = winner + " WIN'S";
            }

        }
    }
}
