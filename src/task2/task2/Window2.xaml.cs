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
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void number_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (number.Text != "")
            {
                int t = Convert.ToInt32(number.Text);
                int x = 35;
                int s = 36;
                int y = 50;
                int r = 100;
                if (t == 0 || t <= 14)
                {
                    notify.Content = "Числовой промежуток [0 - 14]";
                }
                else if (t >= 15 || t <= x)
                {
                    notify.Content = "Числовой промежуток [15 - 35]";
                }
                else if (t > x || t <= y)
                {
                    notify.Content = "Числовой промежуток [36 - 50]";
                }
                else if (t > y || t < r)
                {
                    notify.Content = "Числовой промежуток [50 - 100]";
                }
                else
                {
                    notify.Content = "Не входит ни в один из промежутков";
                }
            }
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 pW = new Window1();
            pW.Show();
            this.Close();
        }

        private void next_Click(object sender, RoutedEventArgs e)
        {
            Window3 pW = new Window3();
            pW.Show();
            this.Close();
        }
    }
}
