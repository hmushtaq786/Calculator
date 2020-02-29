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
using System.Data;
namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string operators = "";              //to store the previous operator entered by the user
        int counter = 0;                    //to make sure user enter two operands before performing any operation
        double[] numArr = new double[2];    //to store the two operands
        public MainWindow()
        {
            InitializeComponent();

        }
        /// <summary>
        /// Event handler for all the number, CE, C and Backspace buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numberBtn_Click(object sender, RoutedEventArgs e)
        {
            if (((Button)sender).Content.ToString() == "CE")
            {
                this.displayLbl.Content = "0";
            }
            else if (((Button)sender).Content.ToString() == "C")
            {
                this.displayLbl.Content = "0";
                this.expressionLbl.Content = "";
                operators = "";
                counter = 0;
                numArr[0] = 0;
                numArr[1] = 0;

            }
            else if (((Button)sender).Content.ToString() == "⌫")
            {
                if (this.displayLbl.Content.ToString() != "")
                {
                    this.displayLbl.Content = this.displayLbl.Content.ToString().Remove(this.displayLbl.Content.ToString().Length - 1);
                }
                if (this.displayLbl.Content.ToString() == "")
                {
                    this.displayLbl.Content = "0";
                }
            }
            else
            {
                string s = " ";
                s = ((Button)sender).Content.ToString();
                if (this.displayLbl.Content.ToString().Length < 8)
                {
                    if ((String)this.displayLbl.Content == "0")
                    {
                        this.displayLbl.Content = "";
                    }

                    this.displayLbl.Content += ((Button)sender).Content.ToString();
                }
                else
                {
                    MessageBox.Show("Maximum operand size reached!");
                }
            }

        }

        /// <summary>
        /// Event handler for all the operation buttons including = button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void signBtn_Click(object sender, RoutedEventArgs e)
        {
            if (counter == numArr.Length)
            {
                counter = 1;
            }
            numArr[counter] = double.Parse(displayLbl.Content.ToString());
            counter++;
            //division operation
            if (((Button)sender).Content.ToString() == "÷")
            {

                if ((String)this.displayLbl.Content != "")
                {
                    if (counter == 2)
                    {   //division operation
                        if (operators == "÷")
                        {
                            numArr[0] = numArr[0] / numArr[1];
                            numArr[0] = Math.Round(numArr[0], 5);
                            numArr[1] = 0;
                            this.displayLbl.Content = numArr[0].ToString();
                            this.expressionLbl.Content = this.displayLbl.Content + "÷";
                            this.displayLbl.Content = "";
                            operators = "÷";
                        }
                        //multiplication operation
                        if (operators == "×")
                        {
                            numArr[0] = numArr[0] * numArr[1];
                            numArr[0] = Math.Round(numArr[0], 5);
                            numArr[1] = 0;
                            this.displayLbl.Content = numArr[0].ToString();
                            this.expressionLbl.Content = this.displayLbl.Content + "÷";
                            this.displayLbl.Content = "";
                            operators = "÷";
                        }
                        //addition operation
                        if (operators == "+")
                        {
                            numArr[0] = numArr[0] + numArr[1];
                            numArr[0] = Math.Round(numArr[0], 5);
                            numArr[1] = 0;
                            this.displayLbl.Content = numArr[0].ToString();
                            this.expressionLbl.Content = this.displayLbl.Content + "÷";
                            this.displayLbl.Content = "";
                            operators = "÷";
                        }
                        //subtraction operation
                        if (operators == "-")
                        {
                            numArr[0] = numArr[0] - numArr[1];
                            numArr[0] = Math.Round(numArr[0], 5);
                            numArr[1] = 0;
                            this.displayLbl.Content = numArr[0].ToString();
                            this.expressionLbl.Content = this.displayLbl.Content + "÷";
                            this.displayLbl.Content = "";
                            operators = "÷";
                        }
                        //modulus operation
                        if (operators == "%")
                        {
                            numArr[0] = numArr[0] % numArr[1];
                            numArr[0] = Math.Round(numArr[0], 5);
                            numArr[1] = 0;
                            this.displayLbl.Content = numArr[0].ToString();
                            this.expressionLbl.Content = this.displayLbl.Content + "÷";
                            this.displayLbl.Content = "";
                            operators = "÷";
                        }
                        if (operators == "")
                        {
                            numArr[0] = numArr[0] / numArr[1];
                            numArr[0] = Math.Round(numArr[0], 5);
                            numArr[1] = 0;
                            this.displayLbl.Content = numArr[0].ToString();
                            this.expressionLbl.Content = this.displayLbl.Content + "÷";
                            this.displayLbl.Content = "";
                            operators = "÷";
                        }
                    }
                    if (counter == 1)
                    {
                        this.expressionLbl.Content = this.displayLbl.Content + "÷";
                        this.displayLbl.Content = "";
                        operators = "÷";
                    }
                    if (counter == 0)
                    {
                        this.displayLbl.Content = "";
                        this.expressionLbl.Content = "";
                    }

                }
            }

            if (((Button)sender).Content.ToString() == "×")
            {
                if ((String)this.displayLbl.Content != "")
                {
                    if (counter == 2)
                    {
                        //division operation
                        if (operators == "÷")
                        {
                            numArr[0] = numArr[0] / numArr[1];
                            numArr[0] = Math.Round(numArr[0], 5);
                            numArr[1] = 0;
                            this.displayLbl.Content = numArr[0].ToString();
                            this.expressionLbl.Content = this.displayLbl.Content + "×";
                            this.displayLbl.Content = "";
                            operators = "×";
                        }
                        //multiplication operation
                        if (operators == "×")
                        {
                            numArr[0] = numArr[0] * numArr[1];
                            numArr[0] = Math.Round(numArr[0], 5);
                            numArr[1] = 0;
                            this.displayLbl.Content = numArr[0].ToString();
                            this.expressionLbl.Content = this.displayLbl.Content + "×";
                            this.displayLbl.Content = "";
                            operators = "×";
                        }
                        //addition operation
                        if (operators == "+")
                        {
                            numArr[0] = numArr[0] + numArr[1];
                            numArr[0] = Math.Round(numArr[0], 5);
                            numArr[1] = 0;
                            this.displayLbl.Content = numArr[0].ToString();
                            this.expressionLbl.Content = this.displayLbl.Content + "×";
                            this.displayLbl.Content = "";
                            operators = "×";
                        }
                        //subtraction operation
                        if (operators == "-")
                        {
                            numArr[0] = numArr[0] - numArr[1];
                            numArr[0] = Math.Round(numArr[0], 5);
                            numArr[1] = 0;
                            this.displayLbl.Content = numArr[0].ToString();
                            this.expressionLbl.Content = this.displayLbl.Content + "×";
                            this.displayLbl.Content = "";
                            operators = "×";
                        }
                        //modulus operation
                        if (operators == "%")
                        {
                            numArr[0] = numArr[0] % numArr[1];
                            numArr[0] = Math.Round(numArr[0], 5);
                            numArr[1] = 0;
                            this.displayLbl.Content = numArr[0].ToString();
                            this.expressionLbl.Content = this.displayLbl.Content + "×";
                            this.displayLbl.Content = "";
                            operators = "×";
                        }
                        if (operators == "")
                        {
                            numArr[0] = numArr[0] / numArr[1];
                            numArr[0] = Math.Round(numArr[0], 5);
                            numArr[1] = 0;
                            this.displayLbl.Content = numArr[0].ToString();
                            this.expressionLbl.Content = this.displayLbl.Content + "×";
                            this.displayLbl.Content = "";
                            operators = "×";
                        }
                    }
                    if (counter == 1)
                    {
                        this.expressionLbl.Content = this.displayLbl.Content + "×";
                        this.displayLbl.Content = "";
                        operators = "×";
                    }
                    if (counter == 0)
                    {
                        this.displayLbl.Content = "";
                        this.expressionLbl.Content = "";
                    }

                }
            }

            if (((Button)sender).Content.ToString() == "+")
            {
                if ((String)this.displayLbl.Content != "")
                {
                    if (counter == 2)
                    {
                        if (operators == "÷")
                        {
                            numArr[0] = numArr[0] / numArr[1];
                            numArr[0] = Math.Round(numArr[0], 5);
                            numArr[1] = 0;
                            this.displayLbl.Content = numArr[0].ToString();
                            this.expressionLbl.Content = this.displayLbl.Content + "+";
                            this.displayLbl.Content = "";
                            operators = "+";
                        }
                        if (operators == "×")
                        {
                            numArr[0] = numArr[0] * numArr[1];
                            numArr[0] = Math.Round(numArr[0], 5);
                            numArr[1] = 0;
                            this.displayLbl.Content = numArr[0].ToString();
                            this.expressionLbl.Content = this.displayLbl.Content + "+";
                            this.displayLbl.Content = "";
                            operators = "+";
                        }
                        if (operators == "+")
                        {
                            numArr[0] = numArr[0] + numArr[1];
                            numArr[0] = Math.Round(numArr[0], 5);
                            numArr[1] = 0;
                            this.displayLbl.Content = numArr[0].ToString();
                            this.expressionLbl.Content = this.displayLbl.Content + "+";
                            this.displayLbl.Content = "";
                            operators = "+";
                        }
                        if (operators == "-")
                        {
                            numArr[0] = numArr[0] - numArr[1];
                            numArr[0] = Math.Round(numArr[0], 5);
                            numArr[1] = 0;
                            this.displayLbl.Content = numArr[0].ToString();
                            this.expressionLbl.Content = this.displayLbl.Content + "+";
                            this.displayLbl.Content = "";
                            operators = "+";
                        }
                        if (operators == "%")
                        {
                            numArr[0] = numArr[0] % numArr[1];
                            numArr[0] = Math.Round(numArr[0], 5);
                            numArr[1] = 0;
                            this.displayLbl.Content = numArr[0].ToString();
                            this.expressionLbl.Content = this.displayLbl.Content + "+";
                            this.displayLbl.Content = "";
                            operators = "+";
                        }
                        if (operators == "")
                        {
                            numArr[0] = numArr[0] / numArr[1];
                            numArr[0] = Math.Round(numArr[0], 5);
                            numArr[1] = 0;
                            this.displayLbl.Content = numArr[0].ToString();
                            this.expressionLbl.Content = this.displayLbl.Content + "+";
                            this.displayLbl.Content = "";
                            operators = "+";
                        }
                    }
                    if (counter == 1)
                    {
                        this.expressionLbl.Content = this.displayLbl.Content + "+";
                        this.displayLbl.Content = "";
                        operators = "+";
                    }
                    if (counter == 0)
                    {
                        this.displayLbl.Content = "";
                        this.expressionLbl.Content = "";
                    }

                }
            }

            if (((Button)sender).Content.ToString() == "-")
            {
                if ((String)this.displayLbl.Content != "")
                {
                    if (counter == 2)
                    {
                        if (operators == "÷")
                        {
                            numArr[0] = numArr[0] / numArr[1];
                            numArr[0] = Math.Round(numArr[0], 5);
                            numArr[1] = 0;
                            this.displayLbl.Content = numArr[0].ToString();
                            this.expressionLbl.Content = this.displayLbl.Content + "-";
                            this.displayLbl.Content = "";
                            operators = "-";
                        }
                        if (operators == "×")
                        {
                            numArr[0] = numArr[0] * numArr[1];
                            numArr[0] = Math.Round(numArr[0], 5);
                            numArr[1] = 0;
                            this.displayLbl.Content = numArr[0].ToString();
                            this.expressionLbl.Content = this.displayLbl.Content + "-";
                            this.displayLbl.Content = "";
                            operators = "-";
                        }
                        if (operators == "+")
                        {
                            numArr[0] = numArr[0] + numArr[1];
                            numArr[0] = Math.Round(numArr[0], 5);
                            numArr[1] = 0;
                            this.displayLbl.Content = numArr[0].ToString();
                            this.expressionLbl.Content = this.displayLbl.Content + "-";
                            this.displayLbl.Content = "";
                            operators = "-";
                        }
                        if (operators == "-")
                        {
                            numArr[0] = numArr[0] - numArr[1];
                            numArr[0] = Math.Round(numArr[0], 5);
                            numArr[1] = 0;
                            this.displayLbl.Content = numArr[0].ToString();
                            this.expressionLbl.Content = this.displayLbl.Content + "-";
                            this.displayLbl.Content = "";
                            operators = "-";
                        }
                        if (operators == "%")
                        {
                            numArr[0] = numArr[0] % numArr[1];
                            numArr[0] = Math.Round(numArr[0], 5);
                            numArr[1] = 0;
                            this.displayLbl.Content = numArr[0].ToString();
                            this.expressionLbl.Content = this.displayLbl.Content + "-";
                            this.displayLbl.Content = "";
                            operators = "-";
                        }
                        if (operators == "")
                        {
                            numArr[0] = numArr[0] / numArr[1];
                            numArr[0] = Math.Round(numArr[0], 5);
                            numArr[1] = 0;
                            this.displayLbl.Content = numArr[0].ToString();
                            this.expressionLbl.Content = this.displayLbl.Content + "-";
                            this.displayLbl.Content = "";
                            operators = "-";
                        }
                    }
                    if (counter == 1)
                    {
                        this.expressionLbl.Content = this.displayLbl.Content + "-";
                        this.displayLbl.Content = "";
                        operators = "-";
                    }
                    if (counter == 0)
                    {
                        this.displayLbl.Content = "";
                        this.expressionLbl.Content = "";
                    }

                }
            }

            if (((Button)sender).Content.ToString() == "%")
            {

                if ((String)this.displayLbl.Content != "")
                {
                    if (counter == 2)
                    {
                        if (operators == "÷")
                        {
                            numArr[0] = numArr[0] / numArr[1];
                            numArr[0] = Math.Round(numArr[0], 5);
                            numArr[1] = 0;
                            this.displayLbl.Content = numArr[0].ToString();
                            this.expressionLbl.Content = this.displayLbl.Content + "%";
                            this.displayLbl.Content = "";
                            operators = "%";
                        }
                        if (operators == "×")
                        {
                            numArr[0] = numArr[0] * numArr[1];
                            numArr[0] = Math.Round(numArr[0], 5);
                            numArr[1] = 0;
                            this.displayLbl.Content = numArr[0].ToString();
                            this.expressionLbl.Content = this.displayLbl.Content + "%";
                            this.displayLbl.Content = "";
                            operators = "%";
                        }
                        if (operators == "+")
                        {
                            numArr[0] = numArr[0] + numArr[1];
                            numArr[0] = Math.Round(numArr[0], 5);
                            numArr[1] = 0;
                            this.displayLbl.Content = numArr[0].ToString();
                            this.expressionLbl.Content = this.displayLbl.Content + "%";
                            this.displayLbl.Content = "";
                            operators = "%";
                        }
                        if (operators == "-")
                        {
                            numArr[0] = numArr[0] - numArr[1];
                            numArr[0] = Math.Round(numArr[0], 5);
                            numArr[1] = 0;
                            this.displayLbl.Content = numArr[0].ToString();
                            this.expressionLbl.Content = this.displayLbl.Content + "%";
                            this.displayLbl.Content = "";
                            operators = "%";
                        }
                        if (operators == "%")
                        {
                            numArr[0] = numArr[0] % numArr[1];
                            numArr[0] = Math.Round(numArr[0], 5);
                            numArr[1] = 0;
                            this.displayLbl.Content = numArr[0].ToString();
                            this.expressionLbl.Content = this.displayLbl.Content + "%";
                            this.displayLbl.Content = "";
                            operators = "%";
                        }
                        if (operators == "")
                        {
                            numArr[0] = numArr[0] / numArr[1];
                            numArr[0] = Math.Round(numArr[0], 5);
                            numArr[1] = 0;
                            this.displayLbl.Content = numArr[0].ToString();
                            this.expressionLbl.Content = this.displayLbl.Content + "%";
                            this.displayLbl.Content = "";
                            operators = "%";
                        }
                    }
                    if (counter == 1)
                    {
                        this.expressionLbl.Content = this.displayLbl.Content + "%";
                        this.displayLbl.Content = "";
                        operators = "%";
                    }
                    if (counter == 0)
                    {
                        this.displayLbl.Content = "";
                        this.expressionLbl.Content = "";
                    }

                }
            }

            if (((Button)sender).Content.ToString() == "=")
            {
                if ((String)this.displayLbl.Content != "")
                {
                    if (counter == 2)
                    {
                        if (operators == "÷")
                        {
                            numArr[0] = numArr[0] / numArr[1];
                            numArr[0] = Math.Round(numArr[0], 5);
                            numArr[1] = 0;
                            this.displayLbl.Content = numArr[0].ToString();
                            this.expressionLbl.Content = "";
                            counter = 0;
                            return;
                        }
                        if (operators == "×")
                        {
                            numArr[0] = numArr[0] * numArr[1];
                            numArr[0] = Math.Round(numArr[0], 5);
                            numArr[1] = 0;
                            this.displayLbl.Content = numArr[0].ToString();
                            this.expressionLbl.Content = "";
                            counter = 0;
                            return;
                        }
                        if (operators == "+")
                        {
                            numArr[0] = numArr[0] + numArr[1];
                            numArr[0] = Math.Round(numArr[0], 5);
                            numArr[1] = 0;
                            this.displayLbl.Content = numArr[0].ToString();
                            this.expressionLbl.Content = "";
                            counter = 0;
                            return;
                        }
                        if (operators == "-")
                        {
                            numArr[0] = numArr[0] - numArr[1];
                            numArr[0] = Math.Round(numArr[0], 5);
                            numArr[1] = 0;
                            this.displayLbl.Content = numArr[0].ToString();
                            this.expressionLbl.Content = "";
                            counter = 0;
                            return;
                        }
                        if (operators == "%")
                        {
                            numArr[0] = numArr[0] % numArr[1];
                            numArr[0] = Math.Round(numArr[0], 5);
                            numArr[1] = 0;
                            this.displayLbl.Content = numArr[0].ToString();
                            this.expressionLbl.Content = "";
                            counter = 0;
                            return;
                        }

                    }
                    if (counter == 1)
                    {
                        MessageBox.Show("Complete the arithmetic expression first.");
                    }
                    if (counter == 0)
                    {
                        MessageBox.Show("Enter a valid arithmetic expression.");
                    }

                }
            }
        }
        /// <summary>
        /// Event handler for keyboard input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void window_KeyDown(object sender, KeyEventArgs e)
        {
            //valid keyboard keys 
            if (e.Key == Key.D0 || e.Key == Key.D1 || e.Key == Key.D2 || e.Key == Key.D3 || e.Key == Key.D4 || e.Key == Key.D5 || e.Key == Key.D6 || e.Key == Key.D7 || e.Key == Key.D8 || e.Key == Key.D9)
            {
                if (this.displayLbl.Content.ToString().Length < 8)
                {
                    if ((String)this.displayLbl.Content.ToString() == "0")
                    {
                        this.displayLbl.Content = "";
                    }
                    this.displayLbl.Content += e.Key.ToString().Substring(1);
                }
                else
                {
                    MessageBox.Show("Maximum operand size reached!");
                }
            }
            //to perform backspace operation using keyboard
            if (e.Key == Key.Back)
            {
                if (this.displayLbl.Content.ToString() != "")
                {
                    this.displayLbl.Content = this.displayLbl.Content.ToString().Remove(this.displayLbl.Content.ToString().Length - 1);
                }
                if (this.displayLbl.Content.ToString() == "")
                {
                    this.displayLbl.Content = "0";
                }
            }
        }
    }
}