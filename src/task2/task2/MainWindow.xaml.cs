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

namespace task2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


           
        }

        private void russian_TextChanged(object sender, TextChangedEventArgs e)
        {
            switch (russian.Text)
            {
                case "Солнечно": // 1
                    english.Text = "Sunny";
                    break;
                case "Облачно": // 2
                    english.Text = "Cloudy";
                    break;
                case "Дождливо": // 3
                    english.Text = "Rainy";
                    break;
                case "Туманно": // 4
                    english.Text = "Foggy";
                    break;
                case "Безоблачно": // 5
                    english.Text = "Cloudless";
                    break;
                case "Ливень": // 6
                    english.Text = "Rainfall";
                    break;
                case "Ураган": // 7
                    english.Text = "Hurricane";
                    break;
                case "Шторм": // 8
                    english.Text = "Storm";
                    break;
                case "Град": // 9
                    english.Text = "Hail";
                    break;
                case "Снегопад":
                    english.Text = "Snowfall";
                    break;
                case "Вьюга":
                    english.Text = "Такого слова нет";
                    break;
            }
        }

        private void english_TextChanged(object sender, TextChangedEventArgs e)
        {
            switch (english.Text)
            {
                case "Sunny": // 1
                    russian.Text = "Солнечно";
                    break;
                case "Cloudy": // 2
                    russian.Text = "Облачно";
                    break;
                case "Rainy": // 3
                    russian.Text = "Дождливо";
                    break;
                case "Foggy": // 4
                    russian.Text = "Туманно";
                    break;
                case "Cloudless": // 5
                    russian.Text = "Безоблачно";
                    break;
                case "Rainfall": // 6
                    russian.Text = "Ливень";
                    break;
                case "Hurricane": // 7
                    russian.Text = "Ураган";
                    break;
                case "Storm": // 8
                    russian.Text = "Шторм";
                    break;
                case "Hail": // 9
                    russian.Text = "Град";
                    break;
                case "Snowfall":
                    russian.Text = "Снегопад";
                    break;
                
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 pW = new Window1();
            pW.Show();
            this.Close();
        }
    }
}