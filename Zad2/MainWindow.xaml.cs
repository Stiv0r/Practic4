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

namespace Zad2
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
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            int n = int.Parse(vod.Text);
            int m = int.Parse(vod2.Text);

            string rank;
            switch (n)
            {
                case 6:
                    rank = "Шестёрка";
                    break;
                case 7:
                    rank = "Семёрка";
                    break;
                case 8:
                    rank = "Восьмёрка";
                    break;
                case 9:
                    rank = "Девятка";
                    break;
                case 10:
                    rank = "Десятка";
                    break;
                case 11:
                    rank = "Вальет";
                    break;
                case 12:
                    rank = "Дама";
                    break;
                case 13:
                    rank = "король";
                    break;
                case 14:
                    rank = "Туз";
                    break;
                default:
                    rank = "";
                    break;
            }

            string suit;
            switch (m)
            {
                case 1:
                    suit = "Пик";
                    break;
                case 2:
                    suit = "Треф";
                    break;
                case 3:
                    suit = "Бубен";
                    break;
                case 4:
                    suit = "Червей";
                    break;
                default:
                    suit = "";
                    break;
            }

            otv.Text = (rank + " " + suit);
        }
    }
}
