using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Data;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using 

namespace Calculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public char search_oper(string str, int index)
        {
            if(index == 1)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == '-')
                    {
                        return '-';
                    }
                    if (str[i] == '+')
                    {
                        return '+';
                    }
                }
                return ' ';
            }
            else
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if(str[i] == '✕')
                    {
                        return '*';
                    }
                    if (str[i] == '+')
                    {
                        return '+';
                    }
                }
                return ' ';
            }
            
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Text.Text += (sender as Button).Content.ToString();
        }
        private void Computing(object sender, RoutedEventArgs e)
        {
            string str = Text.Text;
            str = str.Replace(',', '.');
            str = str.Replace('✕', '*');
            str = str.Replace('÷', '/');
            Text.Text = new DataTable().Compute(str, null).ToString();
        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            Text.Text = "";
        }
        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            if (Text.Text != "")
            {
                double help = Convert.ToInt32(Text.Text.ToString());
                Text.Text = Text.Text.Remove(0, Text.Text.Length);
                Text.Text += $"{1 / help}";
            }
        }
        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            if(Text.Text != "")
            {
                double help = Convert.ToInt32(Text.Text.ToString());
                Text.Text = Text.Text.Remove(0, Text.Text.Length);
                Text.Text += $"{help * help}";
            }
        }

        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            if (Text.Text != "")
            {
                double help = Convert.ToInt32(Text.Text.ToString());
                Text.Text = Text.Text.Remove(0, Text.Text.Length);
                Text.Text += $"{Math.Sqrt(help)}";
            }
        }
        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            if(search_oper(Text.Text.ToString(), 1) == '-')
            {
                Text.Text = Text.Text.Replace('-', '+');
            }
            else if(search_oper(Text.Text.ToString(), 1) == '+')
            {
                Text.Text = Text.Text.Replace('+', '-');
            }
            else
            {
                Text.Text = Text.Text.Insert(0, "-");
            }
        }
        private void Button_Click7(object sender, RoutedEventArgs e)
        {
            Text.Text = Text.Text.Remove(Text.Text.Length-1);
        }
        private void Prof_Computing(object sender, RoutedEventArgs e)
        {
            Exception ex = new Exception("2+2");
            Console.WriteLine(ex.Evaluete());
        }
    }
}
