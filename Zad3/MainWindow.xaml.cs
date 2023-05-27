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

namespace Zad3
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
            int elementNumber = int.Parse(vod.Text);
            double elementValue = double.Parse(vod2.Text);

            switch (elementNumber)
            {
                case 1:
                    double c1 = elementValue * Math.Sqrt(2);
                    double h1 = c1 / 2;
                    double s1 = c1 * h1 / 2;
                    otv.Text = ("Гипотенуза: " + c1);
                    otv.Text = ("Высота, опущенная на гипотенузу: " + h1);
                    otv.Text = ("Площадь: " + s1);
                    break;
                case 2:
                    double a2 = elementValue / Math.Sqrt(2);
                    double h2 = elementValue / 2;
                    double s2 = elementValue * h2 / 2;
                    otv.Text = ("Катет: " + a2);
                    otv.Text = ("Высота, опущенная на гипотенузу: " + h2);
                    otv.Text = ("Площадь: " + s2);
                    break;
                case 3:
                    double c3 = elementValue * 2;
                    double a3 = c3 / Math.Sqrt(2);
                    double s3 = elementValue * c3 / 4;
                    otv.Text = ("Катет: " + a3);
                    otv.Text = ("Гипотенуза: " + c3);
                    otv.Text = ("Площадь: " + s3);
                    break;
                case 4:
                    double c4 = Math.Sqrt(elementValue * 2);
                    double h4 = c4 / 2;
                    double a4 = c4 / Math.Sqrt(2);
                    otv.Text = ("Катет: " + a4);
                    otv.Text = ("Гипотенуза: " + c4);
                    otv.Text = ("Высота, опущенная на гипотенузу: " + h4);
                    break;
                default:
                    otv.Text = ("Некорректный номер элемента");
                    break;
            }
        }
    }
}
