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
using System.Windows.Shapes;

namespace task2
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }


        private void sign_TextChanged(object sender, TextChangedEventArgs e)
        {
            switch(sign.Text)
            {
                case "+":
                res.Content = Convert.ToInt32(number1.Content) + Convert.ToInt32(number2.Content); 
                break;
                case "-":
                    res.Content = Convert.ToInt32(number1.Content) - Convert.ToInt32(number2.Content);
                break;
                case "*":
                    res.Content = Convert.ToInt32(number1.Content) * Convert.ToInt32(number2.Content);
                break;
                case "/":
                    if (number1.Content != "0")
                    {
                        res.Content = Convert.ToDouble(number1.Content) / Convert.ToDouble(number2.Content);
                    }
                    else
                    {
                        res.Background = Brushes.Red;
                    }
                break;

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow pW = new MainWindow();
            pW.Show();
            this.Close();
        }

        private void next_Click(object sender, RoutedEventArgs e)
        {
            Window2 pW = new Window2();
            pW.Show();
            this.Close();
        }
    }
}
