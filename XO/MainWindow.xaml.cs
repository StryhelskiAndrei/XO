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

namespace XO
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        

        public MainWindow()
        {
            InitializeComponent();

        }

        string xoUser = "O";
        string xoRobot = "X";

        public void CheckWin()
        {
            //horizontal
            if(btn1.Content.ToString()==xoUser&&btn4.Content.ToString()==xoUser && btn7.Content.ToString() == xoUser)
            {
                line3.Visibility = Visibility.Visible;
                MessageBox.Show("You win!");
                Reset();
            }
            else if (btn2.Content.ToString() == xoUser && btn5.Content.ToString() == xoUser && btn8.Content.ToString() == xoUser)
            {
                line4.Visibility = Visibility.Visible;
                MessageBox.Show("You win!");
                Reset();
            }
            else if (btn3.Content.ToString() == xoUser && btn6.Content.ToString() == xoUser && btn9.Content.ToString() == xoUser)
            {
                line5.Visibility = Visibility.Visible;
                MessageBox.Show("You win!");
                Reset();
            }
            //vertical
            else if (btn1.Content.ToString() == xoUser && btn2.Content.ToString() == xoUser && btn3.Content.ToString() == xoUser)
            {
                line6.Visibility = Visibility.Visible;
                MessageBox.Show("You win!");
                Reset();
            }
            else if (btn4.Content.ToString() == xoUser && btn5.Content.ToString() == xoUser && btn6.Content.ToString() == xoUser)
            {
                line7.Visibility = Visibility.Visible;
                MessageBox.Show("You win!");
                Reset();
            }
            else if (btn7.Content.ToString() == xoUser && btn8.Content.ToString() == xoUser && btn9.Content.ToString() == xoUser)
            {
                line8.Visibility = Visibility.Visible;
                MessageBox.Show("You win!");
                Reset();
            }
            //diagonal
            else if (btn1.Content.ToString() == xoUser && btn5.Content.ToString() == xoUser && btn9.Content.ToString() == xoUser)
            {
                line2.Visibility = Visibility.Visible;
                MessageBox.Show("You win!");
                Reset();
            }
            else if (btn3.Content.ToString() == xoUser && btn5.Content.ToString() == xoUser && btn7.Content.ToString() == xoUser)
            {
                line1.Visibility = Visibility.Visible;
                MessageBox.Show("You win!");
                Reset();
            }

        }

        public void RoboMove()
        {
            if (btn1.IsEnabled == true|| btn2.IsEnabled == true|| btn3.IsEnabled == true|| btn4.IsEnabled == true|| btn5.IsEnabled == true
                || btn6.IsEnabled == true|| btn7.IsEnabled == true|| btn8.IsEnabled == true|| btn9.IsEnabled == true)
            {
                link1:
                Random rnd = new Random();
                int choice = rnd.Next(1, 9);
                switch (choice)
                {
                    case 1:
                        if (btn1.IsEnabled == false)
                        {
                            goto link1;
                        }
                        btn1.IsEnabled = false;
                        btn1.Content = xoRobot;
                        break;
                    case 2:
                        if (btn2.IsEnabled == false)
                        {
                            goto link1;
                        }
                        btn2.IsEnabled = false;
                        btn2.Content = xoRobot;
                        break;
                    case 3:
                        if (btn3.IsEnabled == false)
                        {
                            goto link1;
                        }
                        btn3.IsEnabled = false;
                        btn3.Content = xoRobot;
                        break;
                    case 4:
                        if (btn4.IsEnabled == false)
                        {
                            goto link1;
                        }
                        btn4.IsEnabled = false;
                        btn4.Content = xoRobot;
                        break;
                    case 5:
                        if (btn5.IsEnabled == false)
                        {
                            goto link1;
                        }
                        btn5.IsEnabled = false;
                        btn5.Content = xoRobot;
                        break;
                    case 6:
                        if (btn6.IsEnabled == false)
                        {
                            goto link1;
                        }
                        btn6.IsEnabled = false;
                        btn6.Content = xoRobot;
                        break;
                    case 7:
                        if (btn7.IsEnabled == false)
                        {
                            goto link1;
                        }
                        btn7.IsEnabled = false;
                        btn7.Content = xoRobot;
                        break;
                    case 8:
                        if (btn8.IsEnabled == false)
                        {
                            goto link1;
                        }
                        btn8.IsEnabled = false;
                        btn8.Content = xoRobot;
                        break;
                    case 9:
                        if (btn9.IsEnabled == false)
                        {
                            goto link1;
                        }
                        btn9.IsEnabled = false;
                        btn9.Content = xoRobot;
                        break;
                }
            }                                  
            
            if (btn1.Content.ToString() == xoRobot && btn4.Content.ToString() == xoRobot && btn7.Content.ToString() == xoRobot)
            {
                line3.Visibility = Visibility.Visible;
                MessageBox.Show("You lose");
                Reset();
            }
            else if (btn2.Content.ToString() == xoRobot && btn5.Content.ToString() == xoRobot && btn8.Content.ToString() == xoRobot)
            {
                line4.Visibility = Visibility.Visible;
                MessageBox.Show("You lose");
                Reset();
            }
            else if (btn3.Content.ToString() == xoRobot && btn6.Content.ToString() == xoRobot && btn9.Content.ToString() == xoRobot)
            {
                line5.Visibility = Visibility.Visible;
                MessageBox.Show("You lose");
                Reset();
            }
            //vertical
            else if (btn1.Content.ToString() == xoRobot && btn2.Content.ToString() == xoRobot && btn3.Content.ToString() == xoRobot)
            {
                line6.Visibility = Visibility.Visible;
                MessageBox.Show("You lose");
                Reset();
            }
            else if (btn4.Content.ToString() == xoRobot && btn5.Content.ToString() == xoRobot && btn6.Content.ToString() == xoRobot)
            {
                line7.Visibility = Visibility.Visible;
                MessageBox.Show("You lose");
                Reset();
            }
            else if (btn7.Content.ToString() == xoRobot && btn8.Content.ToString() == xoRobot && btn9.Content.ToString() == xoRobot)
            {
                line8.Visibility = Visibility.Visible;
                MessageBox.Show("You lose");
                Reset();
            }
            //diagonal
            else if (btn1.Content.ToString() == xoRobot && btn5.Content.ToString() == xoRobot && btn9.Content.ToString() == xoRobot)
            {
                line2.Visibility = Visibility.Visible;
                MessageBox.Show("You lose");
                Reset();
            }
            else if (btn3.Content.ToString() == xoRobot && btn5.Content.ToString() == xoRobot && btn7.Content.ToString() == xoRobot)
            {
                line1.Visibility = Visibility.Visible;
                MessageBox.Show("You lose");
                Reset();
            }
            //else
            //{
            //    MessageBox.Show("Ничья");
            //}

        }
        public void Reset()
        {
            btn1.Content = " "; btn2.Content = " "; btn3.Content = " "; btn4.Content = " "; btn5.Content = " ";
            btn6.Content = " "; btn7.Content = " "; btn8.Content = " "; btn9.Content = " ";
            btn1.IsEnabled = true; btn2.IsEnabled = true; btn3.IsEnabled = true; btn4.IsEnabled = true; btn5.IsEnabled = true; btn6.IsEnabled = true;
            btn7.IsEnabled = true; btn8.IsEnabled = true; btn9.IsEnabled = true;
            line1.Visibility = Visibility.Hidden; line2.Visibility = Visibility.Hidden; line3.Visibility = Visibility.Hidden; line4.Visibility = Visibility.Hidden;
            line5.Visibility = Visibility.Hidden; line6.Visibility = Visibility.Hidden; line7.Visibility = Visibility.Hidden; line8.Visibility = Visibility.Hidden;
        }
        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            btn1.Content = " "; btn2.Content = " "; btn3.Content = " "; btn4.Content = " "; btn5.Content = " ";
            btn6.Content = " "; btn7.Content = " "; btn8.Content = " "; btn9.Content = " ";
            btn1.IsEnabled = true; btn2.IsEnabled = true; btn3.IsEnabled = true; btn4.IsEnabled = true; btn5.IsEnabled = true; btn6.IsEnabled = true;
            btn7.IsEnabled = true; btn8.IsEnabled = true; btn9.IsEnabled = true;
            btnX.Visibility = Visibility.Visible;
            btnO.Visibility = Visibility.Visible;
        }
        public void CheckDraw()
        {
            if (btn1.IsEnabled == false && btn2.IsEnabled == false && btn3.IsEnabled == false && btn4.IsEnabled == false && btn5.IsEnabled == false
                && btn6.IsEnabled == false && btn7.IsEnabled == false && btn8.IsEnabled == false && btn9.IsEnabled == false)
            {
                MessageBox.Show("Draw");
                Reset();
            }
        }
        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            (sender as Button).Content = xoUser;
            (sender as Button).IsEnabled = false;
            CheckWin();
            CheckDraw();
            RoboMove();
        }

        private void BtnX_Click(object sender, RoutedEventArgs e)
        {
            xoUser = "X";
            xoRobot = "O";
            btnX.Visibility = Visibility.Hidden;
            btnO.Visibility = Visibility.Hidden;
        }

        private void BtnO_Click(object sender, RoutedEventArgs e)
        {
            xoUser = "O";
            xoRobot = "X";
            btnX.Visibility = Visibility.Hidden;
            btnO.Visibility = Visibility.Hidden;
        }
    }
}
