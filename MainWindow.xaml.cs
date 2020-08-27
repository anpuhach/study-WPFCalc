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

namespace WPFCalc
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double[] values = new double[2];
        private char type;
        private bool isNew = true;
        private Random r = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            operand.Text += '0';
            ((Button)sender).Background = RandomRgbSolidColorBrush();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            operand.Text += '1';
            ((Button)sender).Background = RandomRgbSolidColorBrush();
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            operand.Text += '2';
            ((Button)sender).Background = RandomRgbSolidColorBrush();
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            operand.Text += '3';
            ((Button)sender).Background = RandomRgbSolidColorBrush();
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            operand.Text += '4';
            ((Button)sender).Background = RandomRgbSolidColorBrush();
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            operand.Text += '5';
            ((Button)sender).Background = RandomRgbSolidColorBrush();
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            operand.Text += '6';
            ((Button)sender).Background = RandomRgbSolidColorBrush();
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            operand.Text += '7';
            ((Button)sender).Background = RandomRgbSolidColorBrush();
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            operand.Text += '8';
            ((Button)sender).Background = RandomRgbSolidColorBrush();
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            operand.Text += '9';
            ((Button)sender).Background = RandomRgbSolidColorBrush();
        }

        private void btnComma_Click(object sender, RoutedEventArgs e)
        {
            if (operand.Text.IndexOf(',') == -1) operand.Text += ',';
            else MessageBox.Show("Навіщо дві коми?", "Халепа");
            ((Button)sender).Background = RandomRgbSolidColorBrush();
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            Execute('+');
            ((Button)sender).Background = RandomRgbSolidColorBrush();
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            Execute('-');
            ((Button)sender).Background = RandomRgbSolidColorBrush();
        }

        private void btnTimes_Click(object sender, RoutedEventArgs e)
        {
            Execute('*');
            ((Button)sender).Background = RandomRgbSolidColorBrush();
        }

        private void btnObelus_Click(object sender, RoutedEventArgs e)
        {
            Execute('/');
            ((Button)sender).Background = RandomRgbSolidColorBrush();
        }

        private void btnEqual_Click(object sender, RoutedEventArgs e)
        {
            Execute('=');
            ((Button)sender).Background = RandomRgbSolidColorBrush();
        }

        private double Math(char t, double[] v)
        {
            switch (t)
            {
                case '+':
                    return v[0] + v[1];
                case '-':
                    return v[0] - v[1];
                case '*':
                    return v[0] * v[1];
                case '/':
                    return v[0] / v[1];
                case '=':
                    return double.Parse(operand.Text);
                default:
                    return 0;
            }
        }

        private void Execute(char t)
        {
            try
            {
                if (isNew)
                {
                    values[0] = double.Parse(operand.Text);
                    result.Text = values[0].ToString();
                    isNew = false;
                }
                else
                {
                    values[1] = double.Parse(operand.Text);
                    values[0] = Math(type, values);
                    result.Text = values[0].ToString();
                }
                operand.Text = null;
                @operator.Text = t.ToString();
                type = t;
            }
            catch (Exception)
            {
                MessageBox.Show("Не кнопкодавте по оператору двічі поспіль", "Халепа!");
            }
        }

        private Brush RandomRgbSolidColorBrush()
        {
            return new SolidColorBrush(Color.FromRgb((byte)r.Next(256), (byte)r.Next(256), (byte)r.Next(256)));
        }
    }
}
